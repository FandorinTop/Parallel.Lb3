using System;
using System.Collections.Generic;
using System.Text;

namespace lab3PP
{
    static class FindElem
    {
        public static Dictionary<string, int> FindKey(string[] data, string[] keys)
        {
            var dic = new Dictionary<string, int>();
            for (int i = 0; i < keys.Length; i++)
            {

                for (int j = 0; j < data.Length; j++)
                {
                    if (keys[i] == data[j])
                    {
                        dic.Add(keys[i], j);
                        break;
                    }
                    if (j == (data.Length - 1))
                    {
                        dic.Add(keys[i], -1);
                    }
                }
            }
            return dic;

        }

    }

}
