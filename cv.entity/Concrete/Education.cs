using System;
using System.ComponentModel.DataAnnotations;

namespace cv.entity.Concrete
{
    public class Education
    {
        [Key]
        public int EducationId { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public decimal GPA { get; set; }
        public DateTime FirstDate { get; set; }
        public DateTime LastDate { get; set; }

    }
}