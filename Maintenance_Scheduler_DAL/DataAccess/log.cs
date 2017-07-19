namespace Maintenance_Scheduler_DAL.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("maintenance_scheduler.log")]
    public partial class log
    {
        [Key]
        public int log_id { get; set; }

        public DateTime log_date { get; set; }

        [Required]
        [StringLength(255)]
        public string log_thread { get; set; }

        [Required]
        [StringLength(150)]
        public string log_level { get; set; }

        [Required]
        [StringLength(255)]
        public string log_logger { get; set; }

        [Required]
        [StringLength(4000)]
        public string log_message { get; set; }

        [StringLength(2000)]
        public string log_exception { get; set; }
    }
}
