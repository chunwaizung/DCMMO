using System.Diagnostics;
using System.IO;
using System.Text;

namespace DC
{
    public class DCDebug
    {
        static StringBuilder _traceSb = new StringBuilder();
        public static string TraceSavePath;
        public static int traceDumpLen = 128 * 1024;
        private static Stream _stream;

        public static void Trace(string msg, bool isNewLine = false, bool isNeedLogTrace = false)
        {
            if (isNewLine)
            {
                _traceSb.AppendLine(msg);
            }
            else
            {
                _traceSb.Append(msg);
            }

            if (isNeedLogTrace)
            {
                StackTrace st = new StackTrace(true);
                StackFrame[] sf = st.GetFrames();
                for (int i = 2; i < sf.Length; ++i)
                {
                    var frame = sf[i];
                    _traceSb.AppendLine(frame.GetMethod().DeclaringType.FullName + "::" + frame.GetMethod().Name);
                }
            }

            if (_traceSb.Length > traceDumpLen)
            {
                FlushTrace();
            }
        }

        public static void FlushTrace()
        {
            if (string.IsNullOrEmpty(TraceSavePath))
                return;
            if (_stream == null)
            {
                var dir = Path.GetDirectoryName(TraceSavePath);
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                _stream = File.Open(TraceSavePath, FileMode.OpenOrCreate, FileAccess.Write);
            }

            var bytes = UTF8Encoding.Default.GetBytes(_traceSb.ToString());
            _stream.Write(bytes, 0, bytes.Length);
            _stream.Flush();
            _traceSb.Clear();
        }
    }
}