using System;
using System.Diagnostics;
using System.Threading;


Console.WriteLine("Give a Starting value");
double start = Convert.ToDouble(Console.ReadLine());
Stopwatch stopWatch = new Stopwatch();
stopWatch.Start();

Console.WriteLine("Give an Ending value");
double stop = Convert.ToDouble(Console.ReadLine());
stopWatch.Stop();

TimeSpan T = stopWatch.Elapsed;


Console.WriteLine("Time Taken to Print the End value :" + T);














