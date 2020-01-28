using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace lab3PP
{
    static class Writer
    {

       static public void PrintKeys(Dictionary<string,int> dic)
        {
            foreach(var k in dic)
            {
                if(k.Value==-1)
                    Console.WriteLine(k.Key + " is NOT FOUND");
                else
                    Console.WriteLine(k.Key + " is found at index "+ k.Value);
            }
        }

       static public void WriteFile(Dictionary<string, int> dic, string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (var k in dic)
                {
                    if (k.Value == -1)
                        sw.WriteLine(k.Key + " is NOT FOUND");
                    else
                        sw.WriteLine(k.Key + " is found at index " + k.Value);
                }
            }
        }
    }
}
