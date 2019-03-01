using System;
using System.IO;
namespace Document_Merger
{
    class Program
    {
        static void Main(string[] args)
        {
            bool conclusion = true;
            while (conclusion)
            {
                Console.WriteLine("Document Merger\n");
                string first = "";
                string second = "";
                string text = "";
                string text2 = "";
                bool tryagain = true;
                bool tryagain2 = true;
                while (tryagain)
                {
                    try
                    {
                        Console.WriteLine("Enter the name of the first text file");
                        string file = Console.ReadLine();
                        StreamReader str = new StreamReader(file + ".txt");
                        string t = System.IO.File.ReadAllText(file + ".txt");
                        first = first + file;
                        text = text + t;
                        tryagain = false;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("The file didn't exist,please do again");
                        tryagain = true;
                    }
                }
                while (tryagain2)
                {
                    try
                    {
                        Console.WriteLine("Enter the name of the second text file");
                        string file2 = Console.ReadLine();
                        StreamReader str2 = new StreamReader(file2 + ".txt");
                        string t = System.IO.File.ReadAllText(file2 + ".txt");
                        second = second + file2;
                        text2 = text2 + t;
                        tryagain2 = false;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("The file didn't exist,please do again");
                        tryagain2 = true;
                    }
                }
                string third = first + second + ".txt";
                string third_text = text + text2;
                Console.WriteLine(third_text);
                StreamWriter streamWriter = new StreamWriter(third);
                streamWriter.WriteLine(third_text);
                streamWriter.Close();
                Console.WriteLine("{0} was successfully saved. The document contains {1} characters.", third, third_text.Length);
                Console.WriteLine("Do you want to save another file?(yes/no)");
                string answer = Console.ReadLine();
                if (answer== "yes")
                {
                    conclusion = true;
                }
                else
                {
                    conclusion = false;
                }
            }
        }
    }
}
