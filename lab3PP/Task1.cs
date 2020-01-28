using System;
using System.Collections.Generic;
using System.Text;
using static lab3PP.FindElem;


namespace lab3PP
{
    class Task1
    {
        Reader reader1 = new Reader(Program.filePath1);
        Reader reader2 = new Reader(Program.filePath2);

        public Task1()
        {
            var data = reader1.ReadChunk();
            var keys = reader2.ReadKey();
            var dic = FindKey(data, keys);
            Writer.WriteFile(dic, Program.resTask1);
        }


    }
}
