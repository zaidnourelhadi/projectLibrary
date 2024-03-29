﻿namespace Library.Global
{
    public static class GlobalConstants
    {
        public static class DataValidations
        {
            public const int GenreNameMaxLength = 60;

            public const int GenreNameMinLength = 3;

            public const int TitleMaxLength = 100;

            public const int TitleMinLength = 5;

            public const int AuthorNameMaxLength = 100;

            public const int AuthorNameMinLength = 3;

            public const int ShortDescriptionMaxLength = 300;

            public const int ShortDescriptionMinLength = 20;

            public const int LongDescriptionMaxLength = 1000;

            public const int LongDescriptionMinLength = 100;

            public const string UrlRegex = @"^https?:\/\/(www\.)?[-a-zA-Z0-9@:%._\+~#=]{1,256}\.[a-zA-Z0-9()]{1,6}\b([-a-zA-Z0-9()@:%_\+.~#?&//=]*)$";
        }

        public static class Paging
        {
            public const int CurrentPageStart = 1;

            public const int ThreeCardsPerPage = 3;
        }

        public static class ErrorMessages
        {
            public const string SomethingWentWrong = "Ups... something went wrong!";

            public const string NoBooksFound = "No books found!";

            public const string BookNotFound = "The book was not found!";

            public const string TitleLength = "The provided title must be at least {2} and {1} characters long!";

            public const string AuthorNameLength = "The provided author's name must be at least {2} and {1} characters long!";

            public const string ShortDescriptionLength = "The provided short description must be at least {2} and {1} characters long!";

            public const string LongDescriptionLength = "The provided long description must be at least {2} and {1} characters long!";

            public const string GenreNameLength = "The provided genre must be at least {2} and {1} characters long!";

            public const string TitleAlreadyExists = "A book with the provided title already exists!";

            public const string GenreDoesNotExists = "The provied genre does not exists in our database!";

            public const string GenreNameAlreadyExists = "The provied genre already exists!";
        }

        public static class Recommendations
        {
            public const string ImageUrl =
                "We recommend to upload it on imgur.com and then right click over the post -> Copy image address. The URL should end with .jpg / .png etc...";
        }

        public static class MemoryCacheKeys
        {
            public const string GenresCacheKey = nameof(GenresCacheKey);
        }

        public static class Notifications
        {
            public const string SuccessfullyAddedBookKey =
                "SABK";

            public const string SuccessfullyAddedBook = "The book added successfully!";

            public const string SuccessfullyEditedBookKey =
                "SEBK";

            public const string SuccessfullyEditedBook = "The book was edited successfully!";

            public const string SuccessfullyDeletedBookKey =
                "SDBK";

            public const string SuccessfullyDeletedBook = "The book was deleted successfully!";

            public const string UnsuccessfullyDeletedBookKey =
                "UDBK";

            public const string UnsuccessfullyDeletedBook = "The book was not deleted successfully!";

            public const string SuccessfullyAddedGenreKey =
                "SDBK";

            public const string SuccessfullyAddedGenre = "The genre was added successfully!";
        }
    }
}

