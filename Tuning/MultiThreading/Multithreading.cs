using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tuning.MultiThreading
{
    public class Multithreading
    {
        public async Task<int> GetMessageLengthAsync()
        {
            Task<string> stringTask = GetTimeTakingMessageAsync();

            DoIndependentWork(); // does some independent work meanwhile

            string message = await stringTask;
            Console.WriteLine($"After await {Thread.CurrentThread.ManagedThreadId}");

            int lengtht = message.Length; // suspends & awaits the result
            return lengtht;



            //Console.WriteLine($"Inner method {Thread.CurrentThread.ManagedThreadId}");
            //string stringTask = await GetTimeTakingMessageAsync(); // calls a long running operation

            //Console.WriteLine($"Inner method {Thread.CurrentThread.ManagedThreadId}");
            //DoIndependentWork(); // does some independent work meanwhile

            //Console.WriteLine($"Inner method {Thread.CurrentThread.ManagedThreadId}");
            ////string message = await stringTask; // suspends & awaits the result

            //Console.WriteLine($"2 method {Thread.CurrentThread.ManagedThreadId}");
            ////int length = message.Length; // once done, does some work on the awaited result

            //Console.WriteLine($"2 method {Thread.CurrentThread.ManagedThreadId}");
            //return stringTask.Length; // then returns the final int result to the caller
        }

        private async Task<string> GetTimeTakingMessageAsync()
        {
            Console.WriteLine($"Async method {Thread.CurrentThread.ManagedThreadId}");
            await Task.Delay(5000);
            //await Task.Run(() => DoIndependentWork(1));
            Console.WriteLine($"Async method {Thread.CurrentThread.ManagedThreadId}");
            return "Some message";
        }

        private void DoIndependentWork(int id) 
        {
        }

        private void DoIndependentWork()
        {
            Console.WriteLine($"Sync Method {Thread.CurrentThread.ManagedThreadId}");
        }
    }

    public class program
    {
        public static async Task Main(string[] args) 
        {
            Console.WriteLine($"Main method {Thread.CurrentThread.ManagedThreadId}");
            Multithreading mul = new Multithreading();
            Task<int> res = mul.GetMessageLengthAsync();
            await res;

            Console.WriteLine($"Main method {Thread.CurrentThread.ManagedThreadId}");
            //Console.WriteLine($"1 Main method {Thread.CurrentThread.ManagedThreadId}");
            //await res;
            //Console.WriteLine($"1 Main method {Thread.CurrentThread.ManagedThreadId}");

        }

        #region Threadpool
        static async Task Main13()
        {
            for (int i = 0; i < 10; i++)
            {
                int index = i; // Create a local copy to avoid closure-related issues
                await Task.Run(() => DoWork(index));
                ThreadPool.QueueUserWorkItem(DoWork, index);
            }
        }
        static void DoWork(Object index)
        {

            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is processing item {index}.");
            // Do some work here...
        }
        #endregion
    }
}
