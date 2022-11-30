using System;
using Hangfire.RecurringJobExtensions;


using Hangfire.Server;

namespace Hangfire.Samples
{
	public class MyJob2 : IRecurringJob
	{
		class SimpleObject
		{
			public string Name { get; set; }
			public int Age { get; set; }
		}

		public void Execute(PerformContext context)
		{
            Console.WriteLine("MyJob2.Execute()");
        }
	}
}
