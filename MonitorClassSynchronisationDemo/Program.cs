using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MonitorClassSynchronisationDemo
{
    public class SampleThreadDemo

    {

        public void M1()

        {

            Monitor.Enter(this);

            {

                for (int i = 1; i <= 5; i++)

                {

                    Console.WriteLine(i);

                    // Monitor.Wait(this, 2000);

                }



            }

            Monitor.Exit(this);

            //Monitor.Pulse(this);//OR

            Monitor.PulseAll(this);



        }

    }
    public  class Program
    {
        static void Main(string[] args)
        {
            SampleThreadDemo obj = new SampleThreadDemo();



            Thread t1 = new Thread(new ThreadStart(obj.M1));

            Thread t2 = new Thread(new ThreadStart(obj.M1));



            t1.Start();

            t2.Start();
        }
    }
}
