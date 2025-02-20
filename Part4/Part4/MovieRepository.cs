using System.Collections.Generic;
using System.Threading.Tasks;
using static MovieSeries.DataAccessLayer.Program;



namespace MovieSeries.DataAccessLayer
{
    public class MovieRepository
    {
        private readonly AppDbContext _context;

        public MovieRepository(AppDbContext context)
        {
            _context = context;
        }

        // Get all movies
        public async Task<IEnumerable<Movie>> GetAllMoviesAsync()
        {
            return await _context.Movies.ToListAsync();
        }

        // Add a new movie
        public async Task AddMovieAsync(Movie movie)
        {
            await _context.Movies.AddAsync(movie);
            await _context.SaveChangesAsync();
        }
    }
}
