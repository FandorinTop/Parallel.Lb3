using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace lab3PP
{
    class Reader 
    {
        string path;
        byte[] arr;
        
        public Reader(string path)
        {
            this.path = path;
           // File.OpenRead(path);
            
        }
        public string[] ReadChunk()
        {

            string[] str=null;
            using (StreamReader fs = new StreamReader(path))
            {
                for (int i = -1; true; i++)
                {
                    string temp = fs.ReadLine();

                    if (i == -1)
                    {
                        int length = Convert.ToInt32(temp);
                        str = new string[length];
                    }
                    else
                        str[i] = temp;
                    if (i == (str?.Length-1))
                        break;
                   
                }

            }

            return str;
        }
        public string[] ReadKey(int size=10)
        {
            var str = new List<string>();
            using (StreamReader fs = new StreamReader(path))
            {
                for (int i=0; true;i++)
                {
                    string temp = fs.ReadLine();


                    if (temp == null) break;

                    str.Add(temp);
                }

            }

            return str.ToArray();
        }

    }
}
