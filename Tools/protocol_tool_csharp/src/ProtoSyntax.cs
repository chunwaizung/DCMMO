using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DC
{
  public enum TokenType
  {
    word,
    left,
  }

  public class Token
  {
    public TokenType type;
    public StringBuilder buf;

    public Token()
    {
      buf = new StringBuilder();
    }
  }

  /// <summary>
  /// 读满5个token，如果发现 message Type {组合
  /// 如果第2个token是//id则找到
  /// 否则清空已读的token，重新搜索
  ///
  /// 元素类型：单词 {
  /// </summary>
  public class ProtoSyntax
  {
    private Dictionary<int, string> idToName = new Dictionary<int, string>();
    private Dictionary<int, string> idToComment = new Dictionary<int, string>();

    private List<Token> tokens = new List<Token>();

    private Token curToken;
    private TokenType state;

    public void ProcessDir(string rootDir, string outputPath)
    {
      var list = new List<FileInfo>();
      FileUtil.GetAllFile(new DirectoryInfo(rootDir), ref list);

      Console.WriteLine($"file cnt: {list.Count}");

      foreach (var file in list)
      {
        Process(file.FullName);
      }
      WriteTo(outputPath);
    }

    public void Process(string srcPath)
    {
      tokens.Clear();

      using(var reader = new StreamReader(File.OpenRead(srcPath), Encoding.UTF8))
      {
        if (reader.Peek() < 0)
        {
          return;
        }

        var intValue = reader.Read();
        if (intValue == '{')
        {
          state = TokenType.left;
        }
        else
        {
          state = TokenType.word;
        }

        curToken = Create();
        curToken.buf.Append(intValue);

        Add(curToken);

        intValue = reader.Read();

        while (intValue >= 0)
        {
          var c = (char)intValue;

          // Console.Write(c);
          switch (state)
          {
            case TokenType.word:
              Process_word(c);
              break;
            case TokenType.left:
              Process_left(c);
              break;
          }

          intValue = reader.Read();
        }
      }
    }

    public void WriteTo(string path)
    {
      var contentBuf = new StringBuilder();
      contentBuf.AppendLine("ProtoConfig = {}");
      contentBuf.AppendLine("ProtoConfigComment = {}");
      var ids = new List<int>(idToName.Keys);
      ids.Sort();
      foreach (var id in ids)
      {
        var val = idToName[id];
        Console.WriteLine(id + "," + val);
        contentBuf.AppendLine(string.Format($"ProtoConfig[{id}] = \"{val}\""));
        if (idToComment.TryGetValue(id, out var comment))
        {
          contentBuf.AppendLine(string.Format($"ProtoConfigComment[{id}] = \"{comment}\""));
        }
      }

      File.WriteAllText(path, contentBuf.ToString());
    }

    private void Process_left(char c)
    {
      switch (c)
      {
        //新token
        case '{':
          curToken = Create();
          curToken.buf.Append(c);
          Add(curToken);
          TryGetIdAndName();
          break;
          //新token
        case ' ':
        case '\n':
          state = TokenType.word;

          curToken = Create();
          Add(curToken);
          break;
        default:
          state = TokenType.word;

          curToken = Create();
          curToken.buf.Append(c);
          Add(curToken);
          break;
      }
    }

    private void Process_word(char c)
    {
      switch (c)
      {
        //新token
        case '{':
          state = TokenType.left;

          curToken = Create();
          curToken.buf.Append(c);
          Add(curToken);

          TryGetIdAndName();
          break;
          //新token
        case ' ':
        case '\n':
          curToken = Create();
          Add(curToken);
          break;
          //加到word
        default:
          curToken.buf.Append(c);
          break;
      }
    }

    private Token Create()
    {
      var token = new Token();
      token.type = state;
      return token;
    }

    private void Add(Token token)
    {
      if (tokens.Count > 0)
      {
        var lastToken = tokens[tokens.Count - 1];
        if (lastToken.buf.Length == 0)
        {
          tokens.Remove(lastToken);
        }
      }

      tokens.Add(token);
    }

    private void TryGetIdAndName()
    {
      var count = tokens.Count;
      if (count >= 4)
      {
        var t1 = tokens[count - 4]; //id
        var t2 = tokens[count - 3]; //nessage
        var t3 = tokens[count - 2]; //name
        var t4 = tokens[count - 1]; //{
        if (t4.type == TokenType.left && t3.type == TokenType.word && t2.type == TokenType.word &&
          t1.type == TokenType.word)
        {
          if (t1.buf[0] == '/' && t1.buf[1] == '/')
          {
            var id = int.Parse(t1.buf.ToString().Substring(2));
            var clsName = t3.buf.ToString();
            if (idToName.ContainsKey(id))
            {
              Console.WriteLine($"repeat: {id}, {clsName}");
            }
            idToName.Add(id, clsName);
            if (tokens.Count >= 5)
            {
              var t0 = tokens[count - 5]; //comment
              if (t0.buf.ToString().StartsWith("//"))
              {
                idToComment.Add(id, t0.buf.ToString().TrimEnd());
              }
            }
          }
        }
      }

      tokens.Clear();
    }

  }

}
