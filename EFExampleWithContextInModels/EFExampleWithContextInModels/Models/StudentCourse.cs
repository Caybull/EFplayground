namespace EFExampleWithContextInModels.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StudentCourse")]
    public partial class StudentCourse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentId { get; set; }

        public int CourseId { get; set; }

        public virtual Course Course { get; set; }

        public virtual Course Course1 { get; set; }

        public virtual Course Course2 { get; set; }

        public virtual Course Course3 { get; set; }

        public virtual Student Student { get; set; }
    }
}
