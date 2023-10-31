using System;
using System.ComponentModel.DataAnnotations;

namespace cv.webui.Models
{
    public class ContactModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Message { get; set; }
        public DateTime Date { get; set; }
    }
}