using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace DC
{
    public class ResourceBuilder
    {
        public Dictionary<string,string> BuildAssetExtensionMap(string root)
        {
            var allFile = Directory.GetFiles(root,"*.*", SearchOption.AllDirectories).Where((item)=>!item.EndsWith("meta")).ToList();

            DCLog.Log(allFile.Count.ToString());

            var dic = new Dictionary<string, string>();
            foreach (var aFile in allFile)
            {
                var unixFilePath = aFile.Replace('\\', '/');
                var assetPath = unixFilePath.Replace(Application.dataPath, "Assets");

                var point = assetPath.LastIndexOf('.');
                var pathWithOutExt = assetPath.Substring(0, point);
                var ext = assetPath.Substring(point);
                dic.Add(pathWithOutExt, ext);
            }

            return dic;
        }

        public void BuildTest1(string root)
        {
            var outputPath = Path.Combine(Path.GetDirectoryName(Application.dataPath), "dcoutput/raw_bundles");
            if (Directory.Exists(outputPath))
            {
                Directory.Delete(outputPath);

            }
            Directory.CreateDirectory(outputPath);

            var builds = CollectAssetBundle(new DirectoryInfo(root));
            var options = BuildAssetBundleOptions.DeterministicAssetBundle | BuildAssetBundleOptions.ChunkBasedCompression;
            BuildPipeline.BuildAssetBundles(outputPath, builds.ToArray(), options, BuildTarget.StandaloneWindows);
        }

        public List<AssetBundleBuild> CollectAssetBundle(DirectoryInfo root)
        {
            var list = new List<AssetBundleBuild>();

            var files = Directory.GetFiles(root.FullName, "*.*", SearchOption.AllDirectories).Where(item=>!item.EndsWith(".meta"));

            var dataPath = Application.dataPath;

            foreach (var file in files)
            {
                var bundleBuild = new AssetBundleBuild();
                //                var fileName = Path.GetFileName(file);
                var fileName = Path.GetFileNameWithoutExtension(file);
                bundleBuild.assetBundleName = fileName;
                var unixPath = file.Replace('\\', '/');
                var assetPath = unixPath.Replace(dataPath,"Assets");
                bundleBuild.assetNames = new[]
                {
                    assetPath,
                };

                list.Add(bundleBuild);
            }

            return list;
        }
    }
}