using System;
using System.Collections.Generic;
using System.Text;

namespace BasicThread
{
    internal class MyThreadClass
    {


        public static void Thread1()
        {
            Thread thread = Thread.CurrentThread;

            for (int loopCount = 0; loopCount < 6; loopCount++)
            {
                
                Console.WriteLine("Name of the thread: " + thread.Name + " = " + loopCount);
                Thread.Sleep(1500);
            }

            
        }




    }
}
