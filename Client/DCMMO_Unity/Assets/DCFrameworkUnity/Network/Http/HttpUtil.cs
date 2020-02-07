using System.Collections.Generic;
using System.Text;
using UnityEngine.Networking;

namespace DC
{
    public static class HttpUtil
    {
        public static string CreateUrlParams(Dictionary<string, object> paramDic)
        {
            var sbd = new StringBuilder();
            foreach (var kv in paramDic)
            {
                var value = kv.Value.ToString();
                var escapeUrl = UnityWebRequest.EscapeURL(value, Encoding.UTF8);
                sbd.Append(kv.Key).Append('=').Append(escapeUrl).Append('&');
            }
            sbd.Remove(sbd.Length - 1, 1);
            return sbd.ToString();
        }

        public static string CreateUrl(string baseUrl, Dictionary<string, object> paramDic)
        {
            return baseUrl + "?" + CreateUrlParams(paramDic);
        }
    }
}