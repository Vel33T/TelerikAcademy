namespace StudentSystem.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Homework
    {
        public Homework()
        {
        }

        public int HomeworkID { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime? TimeSent { get; set; }

        public int CourseID { get; set; }

        public Course Course { get; set; }

        public int StudentID { get; set; }

        public Student Student { get; set; }
    }
}
