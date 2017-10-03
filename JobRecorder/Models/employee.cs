namespace JobRecorder.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("employee")]
    public partial class employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public employee()
        {
            jobs = new HashSet<job>();
        }

        [Key]
        public int employee_id { get; set; }

        [Required]
        [StringLength(255)]
        public string employee_name { get; set; }

        [Required]
        [StringLength(255)]
        public string employee_email { get; set; }

        [Required]
        [StringLength(255)]
        public string employee_phone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<job> jobs { get; set; }
    }
}
