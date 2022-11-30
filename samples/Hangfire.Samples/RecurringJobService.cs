using System;
using Hangfire.RecurringJobExtensions;
using Hangfire.Server;

namespace Hangfire.Samples
{
	public class RecurringJobService
	{
		[RecurringJob("*/1 * * * *")]
		[Queue("jobs")]
		public void TestJob1(PerformContext context)
		{
            
		}
		[RecurringJob("*/2 * * * *", RecurringJobId = "TestJob2")]
		[Queue("jobs")]
		public void TestJob2(PerformContext context)
		{
		}
		[RecurringJob("*/2 * * * *", "China Standard Time", "jobs")]
		public void TestJob3(PerformContext context)
		{
		}
		[RecurringJob("*/5 * * * *", "jobs")]
		public void InstanceTestJob(PerformContext context)
		{
		}

		[RecurringJob("*/6 * * * *", "UTC", "jobs")]
		public static void StaticTestJob(PerformContext context)
		{
		}
	}
}
