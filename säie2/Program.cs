using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace säie2
{
    class Program
    {
        static void Main(string[] args)
        {
            Testi t1 = new Testi(1);
            Testi t2 = new Testi(2);
            Testi t3 = new Testi(3);
            Testi t4 = new Testi(4);
            Thread thread1 = new Thread(t1.Tulosta);
            Thread thread2 = new Thread(t2.Tulosta);
            Thread thread3 = new Thread(t3.Tulosta);
            Thread thread4 = new Thread(t4.Tulosta);
            Console.WriteLine("Main asetetaan prioriteetit");
            thread1.Priority = ThreadPriority.Lowest;
            thread2.Priority = ThreadPriority.Lowest;
            thread3.Priority = ThreadPriority.Lowest;
            thread4.Priority = ThreadPriority.Highest;
            Console.WriteLine("Main käynnistetään säikeet");
          
            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();

            Console.WriteLine("Main valmis");
            Console.ReadKey();
        }
    }
    public class Testi
    {
        int a;
        public Testi(int j)
        {
            a = j;
        }
        public void Tulosta()
        {
            for (int i=0; i < 100; i++) { 
            Console.Write(a);
            }
        }
    }

}
