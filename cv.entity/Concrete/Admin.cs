using System.ComponentModel.DataAnnotations;

namespace cv.entity.Concrete
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}