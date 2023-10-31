
using System.ComponentModel.DataAnnotations;


namespace cv.entity.Concrete
{
    public class Skill
    {
        [Key]
        public int SkillId { get; set; }
        public string SkillName { get; set; }
        public string SkillImage { get; set; }
        [Range(0, 100)]
        public int Perfection { get; set; }
    }
}