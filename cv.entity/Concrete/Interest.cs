using System.ComponentModel.DataAnnotations;

namespace cv.entity.Concrete
{
    public class Interest
    {
        [Key]
        public int InterestId { get; set; }
        public string Description { get; set; }
    }
}