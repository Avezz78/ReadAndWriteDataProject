using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Diagnostics;


namespace taskproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for getting path of text file current directory
            string filepath = @"..\..\..\..\file.txt";//to see the current directory
            string file = File.ReadAllText(filepath);//Opens a text file, reads all the text in the file, and then closes the file.
            Console.WriteLine(file);

            //Read all the characters from text file
            int count = File.ReadAllText(filepath).Length;//Opens a text file, reads all the text in the file, and then closes the file.
            Console.WriteLine("total characters: "+count);
            
            //name and extension of text file
            FileInfo f= new FileInfo(filepath);
            string f1 = f.Name;
            string f2 = f.Extension;
            Console.WriteLine("FileName: "+f1);
            Console.WriteLine("FileExtension: "+f2);

            //count of words from text file
             /* int wordcount = 0;
              for (int i=0; i < file.Length; i++)
              {
                  if (file[i]==' ')
                  {
                      wordcount++;
                  }
              }
              Console.WriteLine("total words in a textfile : "+wordcount); */
            
            string[] Wcount = file.Split(' '); 
            int wordCount = 0;
            foreach (string str in Wcount)
            {
                if (str != string.Empty)
                {
                    wordCount++;
                }
            }
            Console.WriteLine("\n count of word from text file : " + wordCount);
            Console.ReadLine();

            // delete file
            //File.Delete(@"C:\Users\91720\Desktop\project4\sample.txtfile.txt");

            //Copy text file from one folder to another folder 
            string copyfile = @"..\..\..\..\copy\copyfile.txt";
            File.Copy(filepath,copyfile,true);
        }
    }
}
