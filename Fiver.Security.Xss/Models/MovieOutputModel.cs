using Fiver.Security.Xss.OtherLayers;
using System.Collections.Generic;

namespace Fiver.Security.Xss.Models
{
    public class MovieOutputModel
    {
        public string Filter { get; set; } = "";
        public List<Movie> Movies { get; set; } = new List<Movie>();
    }
}
