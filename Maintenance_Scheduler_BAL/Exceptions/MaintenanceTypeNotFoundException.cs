using System;

namespace Maintenance_Scheduler_BAL.Exceptions
{
    public class MaintenanceTypeNotFoundException : Exception
    {
        public MaintenanceTypeNotFoundException()
        {
        }

        public MaintenanceTypeNotFoundException(string message)
            : base(message)
        {
        }

        public MaintenanceTypeNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
