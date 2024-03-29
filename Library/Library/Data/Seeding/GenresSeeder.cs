﻿namespace Library.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Models;

    public class GenresSeeder : ISeeder
    {
        public void Seed(LibraryDbContext data, IServiceProvider serviceProvider)
        {
            if (!data.Genres.Any())
            {
                var genres = new List<string>()
                {
                    "Fantasy Fiction",
                    "Mystery",
                    "Thriller",
                    "Horror",
                    "Historical",
                    "Science Fiction",
                    "Fantasy"
                };

                var genresDbModels = new List<Genre>();

                foreach (var genreName in genres)
                {
                    var genre = new Genre()
                    {
                        Name = genreName
                    };
                    genresDbModels.Add(genre);
                }

                data.Genres.AddRange(genresDbModels);
                data.SaveChanges();
            }
        }
    }
}
