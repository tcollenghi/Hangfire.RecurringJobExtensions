using System;
using System.Linq;
using System.Threading;
using Hangfire.RecurringJobExtensions;
using Hangfire.Server;

namespace Hangfire.Samples
{
	[AutomaticRetry(Attempts = 0)]
	[DisableConcurrentExecution(90)]
	public class LongRunningJob : IRecurringJob
	{
		public void Execute(PerformContext context)
		{




				Thread.Sleep(1000);

		}
	}
}
