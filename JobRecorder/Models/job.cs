namespace JobRecorder.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class job
    {
        [Key]
        public int job_id { get; set; }

        public int employee_id { get; set; }

        [Required]
        [StringLength(255)]
        public string job_position { get; set; }

        [Required]
        [StringLength(255)]
        public string job_description { get; set; }

        public double job_salary { get; set; }

        public virtual employee employee { get; set; }
    }
}
