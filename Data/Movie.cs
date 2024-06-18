namespace C.Data
{

        public class Auditorium
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Capacity { get; set; }
            public DateTime? CreatedAt { get; set; }
            public DateTime? UpdatedAt { get; set; }
        }

        public class Customer
        {
            public int Id { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string PhoneNumber { get; set; }
            public string Address { get; set; }
            public int? Status { get; set; }
            public DateTime? CreatedAt { get; set; }
            public DateTime? UpdatedAt { get; set; }
            public int? Gender { get; set; }
        }


        public class Age
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime? CreatedAt { get; set; }
            public DateTime? UpdatedAt { get; set; }
        }


        public class Movie
        {
            public int Id { get; set; }
            public required string Title { get; set; }
            public required string Director { get; set; }
            public string? Description { get; set; }
            public required string Image { get; set; }
            public required TimeSpan Duration { get; set; }
            public required DateTime ReleaseDate { get; set; }
            public required string Language { get; set; }
            public float Price { get; set; }
            public required string IsFeatured { get; set; }
            public int Status { get; set; }

            public Movie(string title, string director, string description,
                string image, TimeSpan duration, DateTime releaseDate, 
                string language, float price,
                string isFeatured, int status
                )
            {
            Title = title;
            Director = director;
            Description = description;
            Image = image;
            Duration = duration;
            ReleaseDate = releaseDate;
            Language = language;
            Price = price;
            IsFeatured = isFeatured;
            Status = status;
            }
        }

        public class Cast
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Slug { get; set; }
            public string Image { get; set; }
            public int Status { get; set; }
            public DateTime? CreatedAt { get; set; }
            public DateTime? UpdatedAt { get; set; }
        }

        public class Screening
        {
            public int Id { get; set; }
            public int MovieId { get; set; }
            public int AuditoriumId { get; set; }
            public DateTime ScreeningStart { get; set; }
            public DateTime ScreeningEnd { get; set; }
            public DateTime? CreatedAt { get; set; }
            public DateTime? UpdatedAt { get; set; }

            // Foreign key references
            public Movie Movie { get; set; }
            public Auditorium Auditorium { get; set; }
        }


        public class Genre
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public int Status { get; set; }
            public DateTime? CreatedAt { get; set; }
            public DateTime? UpdatedAt { get; set; }
        }

        public class MovieGenre
        {
            public int MovieId { get; set; }
            public int GenreId { get; set; }

            // Foreign key references
            public Movie Movie { get; set; }
            public Genre Genre { get; set; }
        }

        public class MovieAge
        {
            public int MovieId { get; set; }
            public int AgeId { get; set; }

            // Foreign key references
            public Movie Movie { get; set; }
            public Age Age { get; set; }
        }

        public class MovieCast
        {
            public int MovieId { get; set; }
            public int CastId { get; set; }

            // Foreign key references
            public Movie Movie { get; set; }
            public Cast Cast { get; set; }
        }
    }

