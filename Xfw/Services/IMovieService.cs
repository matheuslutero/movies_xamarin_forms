﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Xfw.Models;
using Xfw.Repositories;

namespace Xfw.Services
{
    public interface IMovieService
    {
        Task<(string error, List<Movie>)> GetUpcoming();
    }

    public sealed class MovieService : IMovieService
    {
        private readonly IMovieRepository movieRepository;
        public MovieService()
        {
            movieRepository = new MovieRepository();
        }

        public Task<(string error, List<Movie>)> GetUpcoming()
            => movieRepository.GetUpcoming();
    }
}
