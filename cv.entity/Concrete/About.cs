using System.ComponentModel.DataAnnotations;

namespace cv.entity.Concrete
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string Mail { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; }

    }
}