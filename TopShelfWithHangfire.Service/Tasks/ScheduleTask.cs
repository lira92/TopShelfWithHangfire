using Hangfire;
using System;

namespace TopShelfWithHangfire.Service.Tasks
{
    public class ScheduleTask : ITask
    {
        public string Name => "Schedule Task";

        public string CronExpression => Cron.Minutely();

        public void Run()
        {
            Console.WriteLine("Running a schedule task");
        }
    }
}
