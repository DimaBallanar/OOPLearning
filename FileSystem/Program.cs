using System;
using System.Text;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* StreamWriter sw1= null;
               try
               {
                   sw1 = new StreamWriter("D:\\ДЗ С#\\hschool\\hschool_beggining_csh\\OOPLearning\\FileSystem1.txt",true);
                   sw1.WriteLine("Hello World!");
                   sw1.WriteLine("From the StreamWriter class");


                   using StreamWriter sw2=new StreamWriter("D:\\ДЗ С#\\hschool\\hschool_beggining_csh\\OOPLearning\\FileSystem2.txt",false,Encoding.UTF8);
                   sw2.WriteLine("人人 都 爱 喝可乐");
                   sw2.WriteLine("From the StreamWriter class");
                   sw2.Close();
               }
               catch(Exception e) 
               {
                   Console.WriteLine("Exeption :" +e.Message);
               }
               finally
               {
                   sw1?.Close();
                   Console.WriteLine("人人 都 爱 喝可乐");
               }

          StreamReader sr1 = null;
          try
          {
              StringBuilder stringBuilder = new StringBuilder();
              sr1 = new StreamReader("D:\\ДЗ С#\\hschool\\hschool_beggining_csh\\OOPLearning\\FileSystem1.txt");
              string line = sr1.ReadLine();

              while (line != null)
              {
                  stringBuilder.AppendLine(line);
                  line = sr1.ReadLine();
              }

              Console.WriteLine(stringBuilder.ToString());
              //или
              using StreamReader sr2 = new StreamReader("D:\\ДЗ С#\\hschool\\hschool_beggining_csh\\OOPLearning\\FileSystem2.txt",Encoding.UTF8);
              string result = sr2.ReadToEnd();
              Console.WriteLine(result);
          }
          catch (Exception e)
          { Console.WriteLine("Exeption: " + e.Message); }
          finally
          {
              sr1?.Close();
              Console.WriteLine("Executing finally block");
          }*/

            string filePath = "D:\\ДЗ С#\\hschool\\hschool_beggining_csh\\OOPLearning\\FileSystem1.txt";
            try
            {
                string json = "........";
                System.Console.WriteLine(Path.GetDirectoryName(filePath));
                if (!Directory.Exists(Path.GetDirectoryName(filePath)) {
                    Directory.CreateDirectory(filePath);
                }
                File.WriteAllTextAsync(filePath, json);
            }
            catch(Exception e) {
                System.Console.WriteLine(e);
            }
        }
    }
}