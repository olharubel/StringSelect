using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// "c: \ WebServers \ home\ww\myfile.txt"

namespace StringSelect
{
    class Program
    { 
         static string GetFileName(string path)
         {
            int index = path.LastIndexOf('.');
            int index2 = path.LastIndexOf('\\');
            int length = index - index2 - 1;
            return path.Substring(index2 + 1, length);
         }

        static string GetRootFolder(string path)
        {
            int startIndex = 0;
            int lastIndex = path.IndexOf('\\');
            int length2 = lastIndex - startIndex + 1;
            return path.Substring(startIndex, length2); 
        }
    
        static void Main(string[] args)
        {
            string path = @"c: \ WebServers \ home \ ww \ myfile.txt";

            string fileName = GetFileName(path);
            Console.WriteLine("File name:" + fileName);

            string folder = GetRootFolder(path);
           
            Console.WriteLine("Root folder name: " + folder);
            Console.ReadLine();
        }
    }
}
