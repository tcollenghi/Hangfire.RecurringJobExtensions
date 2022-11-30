using System;
using Hangfire.RecurringJobExtensions;
using Hangfire.Server;

namespace Hangfire.Samples
{
	public class MyJob1 : IRecurringJob
	{
		public void Execute(PerformContext context)
		{
			context.SetJobData("NewIntVal", 99);

			var newIntVal = context.GetJobData<int>("NewIntVal");

		}
	}
}
