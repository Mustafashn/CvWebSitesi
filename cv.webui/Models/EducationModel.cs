using System;
using System.ComponentModel.DataAnnotations;
namespace cv.webui.Models
{
    public class EducationModel
    {
        public int EducationId { get; set; }
        [Required]
        public string Title { get; set; }
        public string SubTitle { get; set; }
        [Range(0, 100)]
        public decimal GPA { get; set; }
        [DataType(DataType.Date)]
        public DateTime FirstDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime LastDate { get; set; }
    }
}