using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEditor;

namespace DC
{

    public class AssetPathMenu : Editor
    {
        [MenuItem("Assets/DC/CopyAssetPath")]
        public static void CopyAssetPath()
        {
            var targetObj = Selection.activeObject;
            if (null == targetObj) return;

            var assetPath = AssetDatabase.GetAssetPath(targetObj);
            var textEditor = new TextEditor();
            textEditor.text = assetPath;
            textEditor.SelectAll();
            textEditor.Copy();
        }

        [MenuItem("Assets/DC/CopyDirAssetPath")]
        public static void CopyDirAssetPath()
        {
            var textEditor = new TextEditor();
            textEditor.text = GetSelectedPathOrFallback();
            textEditor.SelectAll();
            textEditor.Copy();
        }

        public static string GetSelectedPathOrFallback()
        {
            string path = "Assets";

            foreach (UnityEngine.Object obj in Selection.GetFiltered(typeof(UnityEngine.Object), SelectionMode.Assets))
            {
                path = AssetDatabase.GetAssetPath(obj);
                if (!string.IsNullOrEmpty(path) && File.Exists(path))
                {
                    //如果是目录获得目录名，如果是文件获得文件所在的目录名
                    path = Path.GetDirectoryName(path);
                    break;
                }
            }

            return path;
        }
    }


}
