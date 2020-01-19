using System.IO;
using System.Collections.Generic;

namespace DC
{
    public static class FileUtil
    {
        public static void GetAllFile(DirectoryInfo dir, ref List<FileInfo> list)
        {
            var files = dir.GetFiles();
            list.AddRange(files);

            var infos = dir.GetDirectories();
            foreach (var info in infos)
            {
                GetAllFile(info, ref list);
            }
        }
    }
}
