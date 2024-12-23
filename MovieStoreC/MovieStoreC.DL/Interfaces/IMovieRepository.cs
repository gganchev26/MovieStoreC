﻿using MovieStoreC.Models.DTO;

namespace MovieStoreC.DL.Interfaces
{
    public interface IMovieRepository
    {
        void Add(Movie movie);
        List<Movie> GetAll();

        Movie? GetById(int id);

    }


    public interface IActorRepository
    {
        List<Actor> GetAll();
        object GetAll(object actorId);
        Actor? GetById(int id);
        object GetById(object actorId);
    }

}


