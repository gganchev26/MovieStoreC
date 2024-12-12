using Microsoft.VisualBasic.FileIO;
using MovieStoreC.DL.Interfaces;
using MovieStoreC.Models.configurations;
using MovieStoreC.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreC.DL.Repositories.MongoDB
{
    internal class MovieMongoRepository : IMovieRepository
    {
        private readonly IMongoCollection<Movie> _movieCollection;
        private readonly Ilogger<MovieMongoRepository> _logger;
        public MovieMongoRepository(IOptionsMonitor<MongoDBconfiguration>
            ILogger<MovieMongoRepository> logger)
        {
            _logger = _logger;

            var client =new MongoClient(mongoConfig.CurrentValue.ConnecionString);
            var database = client.GetDatabase(mongoConfig.CurrentValue.DatabaseName);
            _movieCollection = database.GetCollection<Movie>("MoviesDb");
        }

        public List<Movie> GetAll() {
            return _movieCollection.Find(mbox => true).ToList();
        }


        public void Add(Movie movie)
        {
            throw new NotImplementedException();
        }

        public List<Movie> GetAll()
        {
            throw new NotImplementedException();
        }

        public Movie? GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
