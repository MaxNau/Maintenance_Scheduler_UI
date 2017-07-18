using log4net;
using Maintenance_Scheduler_UI.ViewModels;
using System.Windows.Forms;

namespace Maintenance_Scheduler_UI.TestForms
{
    public partial class JobsAndTriggersTestForm : Form
    {
        private ILog log;

        IJobsAndTriggersViewModel viewModel;

        public JobsAndTriggersTestForm()
        {
            InitializeComponent();
            StartLogging();
            viewModel = new JobsAndTriggersViewModel();
            jobsAndTriggersView1.IntitializeViewModel(viewModel, new AddMaintenanceSchedulerViewModel());
        }

        private void StartLogging()
        {
            log4net.Config.XmlConfigurator.Configure();
            log = LogManager.GetLogger(typeof(JobsAndTriggersTestForm));
        }
    }
}
