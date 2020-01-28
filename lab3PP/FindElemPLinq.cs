using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace lab3PP
{
    class FindElemPLinq
    {
        public Dictionary<string,int> FindElem(string[] data, string[] keys)
        {
            var dic = new Dictionary<string, int>();
            var res = from k in keys.AsParallel()
                      where IsContain(data, k)
                      select k ;
            var rrr = keys.Where(element =>
            data.ToList().Contains(element)
            ).ToDictionary(element => new
            KeyValuePair<string, int>(element, data.ToList().IndexOf(element)));

            return null;
        }

        public bool IsContain(string[] data,string key)
        {
            var res = data.Select((i, index) =>
                new { index, i })
                .Where(n => n.i == key)
                .Select(n => n.index)
                .ToArray();


            bool ovan=false;
            return true;
        }
    }

}
