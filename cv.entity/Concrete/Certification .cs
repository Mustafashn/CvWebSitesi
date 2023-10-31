using System;
using System.ComponentModel.DataAnnotations;

namespace cv.entity.Concrete
{
    public class Certification
    {
        [Key]
        public int CertificationId { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}