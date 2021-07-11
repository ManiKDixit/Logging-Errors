using System;
using System.IO;

namespace LogTesting_app
{
    class Program
    {
        static void Main(string[] args)
        { 
            
            Logging lg = new Logging();
            int[] arr = new int[5] { 99 ,98 ,92 ,97 , 95 };
            for(int i = 0; i < arr.Length; i++)
            {
                try
                {
                    Console.WriteLine(arr[i]);
                }

                catch(Exception ex)
                {
                    lg.LogError(ex);
                }
            }




        }

       /* public static void LogError(Exception ex)
        {
            
                string filepath = @"C:\Users\man5\Documents";
                using (StreamWriter writer = new StreamWriter(filepath, true))
                {
                    writer.WriteLine("----------------------------------------");
                    writer.WriteLine("Date :" + DateTime.Now.ToString());
                    writer.WriteLine();

                    while (ex != null)
                    {
                        writer.WriteLine(ex.GetType().FullName);
                        writer.WriteLine("Message :" + ex.Message);
                        writer.WriteLine("StackTrace :" + ex.StackTrace);

                        ex = ex.InnerException;
                    }
                }
            

            
            } */
    }
}


//new StreamWriter(filepath, true)