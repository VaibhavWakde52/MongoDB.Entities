﻿namespace MongoDB.Entities.Tests
{
    public class Author : Entity
    {
        public string Name { get; set; }
        public One<Book> BestSeller { get; set; }
        public Many<Book> Books { get; set; }

        public Author() => this.InitProperty(() => Books);
    }
}
