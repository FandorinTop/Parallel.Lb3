using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static lab3PP.FindElem;

namespace lab3PP
{
    class Task2
    {
        Reader reader1 = new Reader(Program.filePath1);
        Reader reader2 = new Reader(Program.filePath2);

        public Task2()
        {
            string[] data=null;
            string[] keys=null;
            //data = reader1.ReadChunk();
            //keys = reader2.ReadKey();

            Parallel.Invoke(
                () => data = reader1.ReadChunk(),
                () => keys = reader2.ReadKey()
                );
            FindElem_ParallelFor_ find = new FindElem_ParallelFor_(data, keys); ;
            var dic = find.FindKey();
            Writer.WriteFile(dic, Program.resTask2);
        }
    }
}
