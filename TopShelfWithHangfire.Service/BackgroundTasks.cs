using Hangfire;
using System;
using System.Collections.Generic;
using TopShelfWithHangfire.Service.Tasks;

namespace TopShelfWithHangfire.Service
{
    public static class BackgroundTasks
    {
        public static void Configure()
        {
            var tasks = new List<ITask>() { new ScheduleTask() };
            tasks.ForEach(task =>
            {
                RecurringJob.AddOrUpdate(task.Name, () => task.Run(), task.CronExpression);
            });
        }
    }
}
