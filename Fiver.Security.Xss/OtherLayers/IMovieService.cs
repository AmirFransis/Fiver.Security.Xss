using System.Collections.Generic;

namespace Fiver.Security.Xss.OtherLayers
{
    public interface IMovieService
    {
        List<Movie> GetMovies();
        List<Movie> GetMovies(string filter);
        Movie GetMovie(int id);
        void AddMovie(Movie item);
        void UpdateMovie(Movie item);
        void DeleteMovie(int id);
        bool MovieExists(int id);
    }
}
