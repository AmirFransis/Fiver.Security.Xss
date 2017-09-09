using System.ComponentModel.DataAnnotations;

namespace Fiver.Security.Xss.Models
{
    public class MovieInputModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public string Summary { get; set; }
    }
}
