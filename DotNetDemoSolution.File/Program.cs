using System;
using System.IO;

namespace DotNetDemoSolution.File
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            FileStream fileInput = null;
            try
            {
                fileInput = new FileStream("DotNetDemoSolution.File/test.dat", FileMode.Open);
                do
                {
                    i = fileInput.ReadByte();
                    if (i != -1) Console.Write((char)i);
                } while (i != -1);
            }
            catch (IOException exc)
            {
                Console.WriteLine("I/O Exception:");
                Console.WriteLine(exc.Message);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            finally
            {
                if (fileInput != null) fileInput.Close();
            }

            Console.WriteLine();

            FileStream fileOutput = null;
            char ch;
            try
            {
                fileOutput = new FileStream("DotNetDemoSolution.File/test.txt", FileMode.CreateNew);
                for (ch = 'A'; ch <= 'Z'; ch++)
                {
                    fileOutput.WriteByte((byte)ch);
                }

                fileOutput.Seek(0, SeekOrigin.Begin);
                ch = (char)fileOutput.ReadByte();
                Console.WriteLine("First letter: " + ch);
                fileOutput.Seek(1, SeekOrigin.Begin);
                ch = (char)fileOutput.ReadByte();
                Console.WriteLine("Second letter: " + ch);
                fileOutput.Seek(4, SeekOrigin.Begin);
                ch = (char)fileOutput.ReadByte();
                Console.WriteLine("Fifth letter: " + ch);
                Console.WriteLine();

                Console.WriteLine("Even alphabet letters:");
                for (i = 0; i < 26; i += 2)
                {
                    fileOutput.Position = i;
                    ch = (char)fileOutput.ReadByte();
                    Console.Write(ch + " ");
                }
            }
            catch (IOException exc)
            {
                Console.WriteLine("I/O Exception:");
                Console.WriteLine(exc.Message);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            finally
            {
                if (fileOutput != null) fileOutput.Close();
            }

            Console.WriteLine();

            string str;
            string stopToken = "stop";
            StreamWriter fileStringOutput = null;
            try
            {
                fileStringOutput = new StreamWriter("DotNetDemoSolution.File/test2.txt");
                Console.WriteLine("Input a text (input '{0}' to end)", stopToken);
                do
                {
                    Console.Write(": ");
                    str = Console.ReadLine();
                    if (str != stopToken)
                    {
                        str = str + "\n";
                        fileStringOutput.Write(str);
                    }
                } while (str != stopToken);
            }
            catch (IOException exc)
            {
                Console.WriteLine("I/O Exception:");
                Console.WriteLine(exc.Message);
            }
            finally
            {
                fileStringOutput.Close();
            }
        }
    }
}
