using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using ReadersWriters;


namespace ReadersWriters
{
    static class Program
    {
        public static volatile Semaphore SemX = new Semaphore(1, 1);
        public static volatile Semaphore WSem = new Semaphore(1, 1);

        static readonly object _object = new object();

        public static int[] Array = new int[4] { 1, 2, 3, 4 };
        public static int readercount, readable = 0, wrtr, rdr1, rdr2, rdr3, total;
        //public string[] readables = new string[3] {rdr1,rdr2,rdr3 };

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Thread[] ThreadArray = new Thread[Array.Length];


            for (int i = 1; Array.Length > i; i++)
            {
                int aux = Array[i];
                int eux = 0;
                switch (i)
                {
                    case 1:
                        eux = rdr1;
                        break;
                    case 2:
                        eux = rdr2;
                        break;
                    case 3:
                        eux = rdr3;
                        break;
                }


                ThreadArray[i] = new Thread(() => ReadMethod(aux, eux));
                ThreadArray[i].Start();
            }

            ThreadArray[0] = new Thread(() => WriteMethod(0));
            ThreadArray[0].Start();

           
        }

        public static void WriteMethod(int id)
        {
            Random rand = new Random();
            int RH = 200;

            while (true)
            {
                WSem.WaitOne();
                //start writing
                Thread.Sleep(RH * (10 - wrtr));
                readable++;
                total++;
                //end writing
                WSem.Release();
            }
        }

        public static void ReadMethod(int id, int ridir)
        {
            Random rand = new Random();
            int RH = 200, readinternal = 0;

            while (true)
            {
                //critical section
                SemX.WaitOne();
                readercount++;
                if (readercount == 1)
                {
                    WSem.WaitOne();
                }
                SemX.Release();

                //reader section
                Thread.Sleep(RH * (10 - ridir));
                readinternal++;


                //end reader section
                SemX.WaitOne();
                readercount--;
                if (readercount == 0)
                {
                    WSem.Release();
                }
                SemX.Release();




            }
        }
    }

        


        
}
