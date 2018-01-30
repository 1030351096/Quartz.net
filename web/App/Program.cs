using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
                
            CodeMethod();
        }

        private static void CodeMethod()
        {
            Console.WriteLine(DateTime.Now.ToString());
            //1.首先创建一个作业调度池
            ISchedulerFactory scheduler = new StdSchedulerFactory();
            IScheduler sched = scheduler.GetScheduler();
            //2.创建一个具体的作业
            IJobDetail job = JobBuilder.Create<jobDemo>().Build();
            //3.创建并配置一个触发器
            #region 每隔5秒执行一次Execute方法,无休止
            ISimpleTrigger trigger = (ISimpleTrigger)
            TriggerBuilder.Create().WithSimpleSchedule(r => r.WithIntervalInSeconds(5).WithRepeatCount(int.MaxValue)).Build();
            #endregion

            #region 程序每5秒执行一次，一共执行50次，开始执行时间设定在当前时间，结束时间设定在1小时后，不管50次有没有执行完，1小时后都不再继续执行
            //DateTimeOffset startTime = DateBuilder.NextGivenSecondDate(DateTime.Now.AddSeconds(1), 2);
            //DateTimeOffset endTime = DateBuilder.NextGivenSecondDate(DateTime.Now.AddHours(1), 5);
            //ISimpleTrigger trigger = (ISimpleTrigger)TriggerBuilder.Create().StartAt(startTime).EndAt(endTime).WithSimpleSchedule(r => r.WithIntervalInSeconds(5).WithRepeatCount(50)).Build();
            #endregion
            #region 实现各种时间纬度调用(使用cron-like):在每小时的第10.20.30分钟，每分钟的第11.27秒执行一次
            //ICronTrigger trigger = (ICronTrigger)TriggerBuilder.Create().StartAt(startTime).EndAt(endTime).WithCronSchedule("11,27 10,20,30 * * * ?").Build();
            #endregion

            //4.加入作业调度池中
            sched.ScheduleJob(job, trigger);
            //5.开始运行
            sched.Start();
            Console.ReadKey();
        }

        public class jobDemo : IJob
        {
            /// <summary>
            /// 作业调度每次定时执行方法
            /// </summary>
            /// <param name="context"></param>
            public void Execute(IJobExecutionContext context)
            {
                Console.WriteLine(DateTime.Now.ToString());
            }
        }




    }
}
