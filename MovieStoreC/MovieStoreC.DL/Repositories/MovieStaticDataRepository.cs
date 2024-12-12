using MovieStoreC.DL.Interfaces;
using MovieStoreC.DL.StaticData;
using MovieStoreC.Models.DTO;

namespace MovieStoreC.DL.Repositories
{
    internal class MovieStaticDataRepository : IMovieRepository
    {
        public void Add(Movie movie)
        {
            throw new NotImplementedException();
        }

        public List<Movie> GetAll()
        {

            return StaticDb.Movie;
        }

        public Movie? GetById(int id)
        {
            if (id <= 0) return null;

            return StaticDb.Movie
                .FirstOrDefault(x => x.Id == id);
        }
    }

    internal class MovieMongoRepository : IMovieRepository
    {
        public void Add(Movie movie)
        {
            throw new NotImplementedException();
        }

        public List<Movie> GetAll()
        {
            return StaticDb.Movies;

        }

        public Movie? GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
