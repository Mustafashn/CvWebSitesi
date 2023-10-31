using System;
using System.ComponentModel.DataAnnotations;

namespace cv.webui.Models
{
    public class ExperienceModel
    {
        public int ExperienceId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(100)]
        public string SubTitle { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime FirstDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime LastDate { get; set; }
    }
}