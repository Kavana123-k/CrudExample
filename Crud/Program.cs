using System;

namespace Crud
{
    class Program
    {
        static void Main(string[] args)
        {
            CrudConsole c = new CrudConsole();
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("enter the choice");
                Console.WriteLine("1.create file");
                Console.WriteLine("2.read file");
                Console.WriteLine("3.update file");
                Console.WriteLine("4. delete  file");
                Console.WriteLine("--------------------");
                int a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Console.WriteLine("file created");
                        Console.WriteLine("*************************************");
                        c.CreateFile();
                        break;
                    case 2:
                        String text = c.ReadFile();
                        Console.WriteLine(text);
                        Console.WriteLine("File is read");
                        Console.WriteLine("*************************************");
                        break;
                    case 3:
                        Console.WriteLine("enter the text");
                        string s = Console.ReadLine();
                        string r = c.UpdateFile(s);
                        Console.WriteLine("File got updated");
                        Console.WriteLine("*************************************");
                        break;
                    case 4:
                        c.DeleteFile();
                        Console.WriteLine("File deleted.");
                        Console.WriteLine("*************************************");
                        break;
                    default:
                        Console.WriteLine("no file exit");
                        Console.WriteLine("*************************************");
                        break;
                }
            }
        }
    }
}
