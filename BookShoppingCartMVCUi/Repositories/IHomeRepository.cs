﻿namespace BookShoppingCartMVCUi.Repositories
{
    public interface IHomeRepository
    {
        public Task<IEnumerable<Genre>> Genres();

        public Task<IEnumerable<Book>> GetBooks(string sTerm = "", int genreId = 0);

    }
}