using System;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Threads2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World! 1");
            //Thread.Sleep(1000); //Stops the main thread of a WPF UI
            //Console.WriteLine("Hello World! 2");
            //Thread.Sleep(1000);
            //Console.WriteLine("Hello World! 3");
            //Thread.Sleep(1000);
            //Console.WriteLine("Hello World! 4");

            //new Thread(() =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Thread 1");
            //}).Start();
            //new Thread(() =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Thread 2");
            //}).Start();
            //new Thread(() =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Thread 3");
            //}).Start();
            //new Thread(() =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Thread 4");
            //}).Start();

            //new Thread(() =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Thread 4");
            //})
            //{ IsBackground = true }.Start();

            //Enumerable.Range(0, 1000).ToList().ForEach(f =>
            // {
            //     ThreadPool.QueueUserWorkItem((o) => //run through a limited amount of work, close it then the next batch of work. Regular thread w/ Enumearable will try to do it as much as possible at the same time.
            //     {
            //         Console.WriteLine($"Thread number:{Thread.CurrentThread.ManagedThreadId} started");
            //         Thread.Sleep(1000);

            //         Console.WriteLine($"Thread number:{Thread.CurrentThread.ManagedThreadId} ended");
            //     });
            // });       

            //Console.ReadLine();
            Console.WriteLine("Main Thread started");
            Thread thread1= new Thread (Thread1Function);
            Thread thread2 = new Thread(Thread2Function);
            thread1.Start();
            thread2.Start();

            if (thread1.Join(1000))
            {
                Console.WriteLine("Thread1 Fnction done");
            }
            else
            {
                Console.WriteLine("Thread1 Function not done in one second");
            }
            //thread1.Join();
            //Console.WriteLine("Thread1 Function done");
            thread2.Join();
            Console.WriteLine("Thread2 Function done");
            for(int i =0;i<7; i++)
            {
                if (thread1.IsAlive)
                {
                    Console.WriteLine("Thread1 is still doing something");
                    Thread.Sleep(300);
                }
                else
                {
                    Console.WriteLine("Thread1 completed");
                }
            }
           

            Console.WriteLine("Main thread ended");
          
        }
        public static void Thread1Function()
        {
            Console.WriteLine("Thread1Function started");
            Thread.Sleep(3000);
            Console.WriteLine("Thread1 Function coming back to Caller");
        }
        public static void Thread2Function()
        {
            Console.WriteLine("Thread2Function started");
        }
    }
}
