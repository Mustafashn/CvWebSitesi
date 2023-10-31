using System.ComponentModel.DataAnnotations;
namespace cv.webui.Models
{
    public class InterestModel
    {
        public int InterestId { get; set; }
        [Required]
        public string Description { get; set; }
    }
}