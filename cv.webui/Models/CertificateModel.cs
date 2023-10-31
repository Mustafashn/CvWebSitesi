using System;
using System.ComponentModel.DataAnnotations;

namespace cv.webui.Models
{
    public class CertificateModel
    {
        public int CertificationId { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}