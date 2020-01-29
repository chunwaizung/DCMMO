using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
                var point = aFile.LastIndexOf('.');
                var pathWithOutExt = aFile.Substring(0, point);
                var ext = aFile.Substring(point);
                dic.Add(pathWithOutExt, ext);
            }

            return dic;
        }


    }
}