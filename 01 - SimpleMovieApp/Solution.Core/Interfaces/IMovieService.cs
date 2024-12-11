using Solution.Core.Models;

namespace Solution.Core.Interfaces;

public interface IMovieService
{
    Task CreateAsync(MovieModel movie);
}
