using System;
using Quartz;
using MailingModule;

namespace Maintenance_Scheduler_BAL.SchedulerJobs
{
    public class MailingJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            /*
             foreach(string email in EmailListFromDatabase)
            {
            EmailServerConfiguration configuration = new EmailServerConfiguration(
                "company@email.adress",
                "smpt.example.domain.com",
                 25,
                 true,
                 "password");
            EmailModule mailingModule = new EmailModule(configuration);
            mailingModule.Send(email, "hello", "<body> Her goes the message from the mailing job </body>");
            }
            */
        }
    }
}
