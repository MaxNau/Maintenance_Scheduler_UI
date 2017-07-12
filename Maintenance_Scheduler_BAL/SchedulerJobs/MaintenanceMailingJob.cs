using System;
using Quartz;
using MailingModule;

namespace Maintenance_Scheduler_BAL.SchedulerJobs
{
    public class MailingJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            /*EmailServerConfiguration configuration = new EmailServerConfiguration(
                "test@email.com",
                "smtp.mail.test.com",
                 587,
                 true,
                 "password");
            EmailModule mailingModule = new EmailModule(configuration);
            mailingModule.Send("simensjohn@yahoo.com", context.JobDetail.JobDataMap.GetString("MailSubject"), context.JobDetail.JobDataMap.GetString("MailBody"));
            */
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
