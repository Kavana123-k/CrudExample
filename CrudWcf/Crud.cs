using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace CrudWcf
{
    public class Crud
    {
        string path = @"d:\data.txt";
        public void CreateFile()
        {
            try
            {
                if (!File.Exists(path))
                {
                    File.Create(path).Close();
                    //  Console.WriteLine("file created");
                }
                else
                {
                    // Console.WriteLine("file already exist");---
                }
            }
            catch (Exception)
            {
                //Console.WriteLine("create error" + ex.Message);
            }
        }
        public string ReadFile()
        {
            string text;
            try
            {
                text = File.ReadAllText(path);
                // Console.WriteLine(text);--
                return text;
                //Console.WriteLine("File is read");--
            }
            catch (Exception)
            {
                // Console.WriteLine("read error" + ex.Message);               
            }
            return "1";
        }

        public string UpdateFile(String s)
        {
            try
            {
                //Write a line of text
                // string s;--
                //Console.WriteLine("enter the text");---
                // s = Console.ReadLine();--
                File.WriteAllText(path, s);
                return path;
            }
            catch (Exception)
            {
                // Console.WriteLine("update error" + ex.Message);
                return "1";
            }
        }
        public void DeleteFile()
        {
            try
            {
                if (File.Exists(Path.Combine(path)))
                {
                    File.Delete(Path.Combine(path));
                    // Console.WriteLine("File deleted.");---
                }
            }
            catch (Exception)
            {
                //Console.WriteLine("delete error" + ex.Message);
            }
        }
    }
}