using System;
using System.IO;

namespace DC
{
    public class ConfigUtil
    {
        public static string CfgFilesRoot;

        public static byte[] GetBin(Type type)
        {
            return GetBin(type.Name);
        }

        public static byte[] GetBin(string binFileName)
        {
            var path = Path.Combine(CfgFilesRoot, binFileName + ".bytes");
            return File.ReadAllBytes(path);
        }

    }

}
