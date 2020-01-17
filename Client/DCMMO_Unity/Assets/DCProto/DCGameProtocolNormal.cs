using System;
using System.Collections.Generic;
using System.Text;
using Google.Protobuf;

namespace Dcgameprotobuf
{
    public static partial class DCGameProtocol
    {
        public static byte[] Convert<T>(int id, T t) where T : IMessage<T>
        {
            if (id == 0)
            {
                //todo log error
                return new byte[1] { 0 };
            }

            var idByidByte = GetIntBuf(id);

            var objBytes = t.ToByteArray();
            var contentBytes = new byte[4 + objBytes.Length];
            Array.Copy(idByidByte, 0, contentBytes, 0, 4);
            Array.Copy(objBytes, 4, contentBytes, 4, objBytes.Length);
            return contentBytes;
        }

        public static byte[] GetUshortBuf(ushort val)
        {
            var bytes = BitConverter.GetBytes(val);
            if (!BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }

            return bytes;
        }

        public static byte[] GetIntBuf(int val)
        {
            var bytes = BitConverter.GetBytes(val);
            if (!BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }

            return bytes;
        }

        public static ushort GetUshort(byte[] buf, int offset)
        {
            s_buf[0] = buf[offset];
            s_buf[1] = buf[offset + 1];

            if (!BitConverter.IsLittleEndian)
            {
                Array.Reverse(s_buf, 0, 2);
            }
            return BitConverter.ToUInt16(s_buf, 0);
        }

        public static ushort GetUshort(byte[] buf)
        {
            return GetUshort(buf, 0);
        }

        private static readonly byte[] s_buf = new byte[4];
        public static int GetInt(byte[] buf, int offset)
        {
            s_buf[0] = buf[offset];
            s_buf[1] = buf[offset + 1];
            s_buf[2] = buf[offset + 2];
            s_buf[3] = buf[offset + 3];

            if (!BitConverter.IsLittleEndian)
            {
                Array.Reverse(s_buf);
            }

            return BitConverter.ToInt32(s_buf, 0);
        }

        public static int GetInt(byte[] buf)
        {
            return GetInt(buf, 0);
        }
    }
}

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
/// 读满4个token，如果发现 message Type {组合
/// 如果第一个token是//id则找到
/// 否则清空已读的token，重新搜索
///
/// 单词 空格 {
/// </summary>
public class ProtoSyntax
{
    private TokenType state;

    Dictionary<int, string> idToName = new Dictionary<int, string>();

    private int buf_len = 128;

    private List<char> mBuf = new List<char>();

    private List<Token> tokens = new List<Token>();

    Token curToken = new Token();

    public void Process()
    {
        var c = Next();
        tokens.Add(curToken);

        while (c >= char.MinValue)
        {
            switch (state)
            {
                case TokenType.word:
                    Process_word(c);
                    break;
                case TokenType.left:
                    Process_left(c);
                    break;
            }
        }
    }

    private void Process_left(char c)
    {
        switch (c)
        {
            //新token
            case '{':
                curToken = new Token();
                curToken.buf.Append(c);
                tokens.Add(curToken);
                break;
            //新token
            case ' ':
            case '\n':
                curToken = new Token();
                tokens.Add(curToken);
                state = TokenType.word;
                break;
            default:
                curToken = new Token();
                curToken.buf.Append(c);
                tokens.Add(curToken);
                state = TokenType.word;
                break;
        }
    }

    private void Process_word(char c)
    {
        switch (c)
        {
            //新token
            case '{':
                curToken = new Token();
                curToken.buf.Append(c);
                tokens.Add(curToken);
                state = TokenType.left;
                break;
            //新token
            case ' ':
            case '\n':
                curToken = new Token();
                tokens.Add(curToken);
                break;
            //加到word
            default:
                curToken.buf.Append(c);
                break;
        }
    }

    private void TryGetIdAndName()
    {
        var count = tokens.Count;
        if (count > 4)
        {
            var t1 = tokens[count - 4];
            var t2 = tokens[count - 3];
            var t3 = tokens[count - 2];
            var t4 = tokens[count - 1];

        }
    }

    public char Next()
    {
        return 'c';
    }

}
