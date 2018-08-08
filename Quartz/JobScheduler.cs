using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz.Impl;

namespace Quartz
{
    public class JobScheduler
    {
        public void Start()
        {
            IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler();
            scheduler.Start();

            IJobDetail job = JobBuilder.Create<TestJob>().Build();

            ITrigger trigger = TriggerBuilder.Create()
                .WithSimpleSchedule(a => a.WithIntervalInMinutes(1).RepeatForever())
                .Build();

            scheduler.ScheduleJob(job, trigger);
        }

        public void Stop()
        {
            IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler();
            scheduler.Shutdown();
        }

    }
}
