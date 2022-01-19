namespace EFExampleWithContextInModels.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Teacher")]
    public partial class Teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StaffId { get; set; }

        [StringLength(200)]
        public string Specialty { get; set; }

        [StringLength(10)]
        public string TeacherName { get; set; }

        public int? TeacherAge { get; set; }

        public virtual Staff Staff { get; set; }
    }
}
