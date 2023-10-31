using System;
using System.ComponentModel.DataAnnotations;


namespace cv.webui.Models
{
    public class SkillModel
    {
        public int SkillId { get; set; }
        [Required]
        [MaxLength(50)]
        public string SkillName { get; set; }
        [FileExtensions(Extensions = "jpg,jpeg")]
        public string SkillImage { get; set; }
        [Range(0, 100)]
        public int Perfection { get; set; }
    }
}