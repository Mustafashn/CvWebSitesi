
using System.ComponentModel.DataAnnotations;

namespace cv.webui.Models
{
    public class AboutModel
    {
        public int AboutId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }
        [Required]
        public string Description { get; set; }
        [FileExtensions(Extensions = "jpg,jpeg,png")]
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; }
    }
}