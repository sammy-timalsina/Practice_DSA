using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Maps
{
    public partial class cMap
    {
        public string DecodeMessage(string key, string message)
        {
            key = key.Replace(" ", "");
            Dictionary<string, string> kv = new Dictionary<string, string>();
            int lenKey = key.Length;
            int counter = 0;
            for(int i=0;i<=lenKey-1;i++)
            {
                if(!kv.ContainsKey(key[i].ToString()))
                {

                    char data = (char)(97 + counter);
                    kv.Add(key[i].ToString(), data.ToString());
                    counter++;
                }
            }
            string secretMsg = string.Empty;
            for(int i=0;i<message.Length;i++)
            {
                if(char.IsWhiteSpace(message[i]))
                {
                    secretMsg = secretMsg + " ";
                    continue;
                }
                secretMsg = secretMsg + kv[message[i].ToString()];
            }
            return secretMsg;
        }
    }
}
