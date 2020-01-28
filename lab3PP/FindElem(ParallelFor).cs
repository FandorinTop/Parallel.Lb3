using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace lab3PP
{
    class FindElem_ParallelFor_
    {
        private string[] data;
        private string[] keys;
        //ConcurrentDictionary<string, int> dic = new ConcurrentDictionary<string, int>();
        Dictionary<string, int> dic=new Dictionary<string, int>();
        //SortedDictionary<string, int> fff;
        public FindElem_ParallelFor_(string[] data, string[] keys)
        {
            this.data = data;
            this.keys = keys;
        }

        public Dictionary<string, int> FindKey()
        {
            dic.Clear();
            foreach (var k in keys)
            {
                dic.TryAdd(k, -1);
            }
            Parallel.For(0, keys.Length, (x) => FindKeyInData(keys[x]));
            return dic;
        }

        private void FindKeyInData(string key)
        {
            System.Threading.Thread.Sleep(15);
            for (int j = 0; j < data.Length; j++)
            {
                if (key == data[j])
                {
                    dic[key] = j;
                    //dic.TryAdd(key, j);
                    break;
                }
                //if (j == (data.Length - 1))
                //{
                //    dic.TryAdd(key, -1);
                //}
            }
        }
    }
}
