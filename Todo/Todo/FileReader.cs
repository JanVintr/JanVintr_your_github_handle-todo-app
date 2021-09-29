using System;
using System.Collections.Generic;
using System.IO;

namespace Todo
{
    public class FileReader
    {
         string[] fourLine = { "4 - next task" };
        //string[] name1 = { "walk the dog" };
        //string[] name2 = { "buy milk" };
        //string[] name3 = { "do homework" };

        string listTasks = "-l";
        string add = "-a";
        string remove = "r";
        string complete = "c";

        public FileReader()
        {
         
        }


        public void ReadFile()
        {
            string path = @"./todoTasks.txt";
            try
            {
                string[] content = File.ReadAllLines(path);
                Console.WriteLine(content[4]);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to read file");
            }
        }
        public void WriteFile()
        {
            string path = @"./todoTasks.txt";
            try
            {// \n nám plní funkci enteru, ale abychom to mohli zavolat ve funkci, která bere parametr
             // typu pole stringu neboli string[] nebol array stringu, tak jsme z toho museli
             // udělat string []
                File.AppendAllLines(path, new string[]{"\n"});
                File.AppendAllLines(path, fourLine);
                Console.WriteLine(fourLine);
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to read file");
            }

        }
    }
}
