using System;
using System.Threading;

namespace problemaFilosofos
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread h1 = new Thread(new ThreadStart(hilo1));
                h1.Start();
                Thread h2 = new Thread(new ThreadStart(hilo2));
                h2.Start();
                Thread h3 = new Thread(new ThreadStart(hilo3));
                h3.Start();
                Thread h4 = new Thread(new ThreadStart(hilo4));
                h4.Start();
                Thread h5 = new Thread(new ThreadStart(hilo5));
                h5.Start();

            }
            


        }

        private static int[] tenedor = new int[5];
        private static int[] comidas = new int[5];

        static Semaphore semaforoP1 = new Semaphore(2, 2);

        public static void hilo1()
        {
            semaforoP1.WaitOne();
            Console.WriteLine("Filosofo 1 tiene tenedor" + tenedor[1]);

            Thread.Sleep(1500);
            Console.WriteLine("Filosofo 1 tiene tenedor" + tenedor[0]);

            Thread.Sleep(1500);
            Console.WriteLine("Ha comido Filosofo 1");

            comidas[0] += 1;

            Thread.Sleep(1500);
            Console.WriteLine("Filosofo 1 dejo tenedor");
            Console.WriteLine("Filosofo 1 dejo tenedor");

            Thread.Sleep(1500);
            semaforoP1.Release();

        }

        public static void hilo2()
        {
            semaforoP1.WaitOne();
            Console.WriteLine("Filosofo 2 tiene tenedor" + tenedor[2]);

            Thread.Sleep(1500);
            Console.WriteLine("Filosofo 2 tiene tenedor" + tenedor[1]);

            Thread.Sleep(1500);
            Console.WriteLine("Ha comido Filosofo 2");

            comidas[1] += 1;

            Thread.Sleep(1500); ;
            Console.WriteLine("Filosofo 2 dejo tendor" + tenedor[2]);
            Console.WriteLine("Filosofo 2 dejo tendor" + tenedor[1]);

            Thread.Sleep(1500);
            semaforoP1.Release();
        }
        public static void hilo3()
        {
            semaforoP1.WaitOne();
            Console.WriteLine("Filosofo 3 tiene tenedor" + tenedor[3]);

            Thread.Sleep(1500);
            Console.WriteLine("Filosofo 3 tiene tenedor" + tenedor[2]);

            Thread.Sleep(1500);
            Console.WriteLine("Ha comido Filosofo 3");

            comidas[2] += 1;

            Thread.Sleep(1500);
            Console.WriteLine("Filosofo 3 dejo tenedor" + tenedor[2]);
            Console.WriteLine("Filosofo 3 dejo tenedor" + tenedor[1]);

            Thread.Sleep(1500);
            semaforoP1.Release();
        }
        public static void hilo4()
        {
            semaforoP1.WaitOne();
            Console.WriteLine("Filosofo 4 tiene tenedor" + tenedor[4]);

            Thread.Sleep(1500);
            Console.WriteLine("Filosofo 4 tiene tenedor" + tenedor[3]);

            Thread.Sleep(1500);
            Console.WriteLine("Ha comido Filosofo 4");

            comidas[3] += 1;

            Thread.Sleep(1500);
            Console.WriteLine("Filosofo 4 dejo tenedor" + tenedor[2]);
            Console.WriteLine("Filosofo 4 dejo tenedor" + tenedor[1]);

            Thread.Sleep(1500);
            semaforoP1.Release();
        }
        public static void hilo5()
        {

            semaforoP1.WaitOne();
            Console.WriteLine("Filosofo 5 tiene tenedor" + tenedor[0]);

            Thread.Sleep(1500);
            Console.WriteLine("Filosofo 5 tiene tenedor" + tenedor[4]);

            Thread.Sleep(1500);
            Console.WriteLine("Ha comido Filosofo 5");

            comidas[4] += 1;

            Thread.Sleep(1500);
            Console.WriteLine("Filosofo 5 dejo tenedor" + tenedor[2]);
            Console.WriteLine("Filosofo 5 dejo tenedor" + tenedor[1]);

            Thread.Sleep(1500);
            semaforoP1.Release();
        }
    }
}

