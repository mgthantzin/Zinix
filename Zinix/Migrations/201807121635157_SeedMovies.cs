namespace Zinix.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedMovies : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Movies (Name, GenreId, ReleasedDate, DateAdded, NumberInStock) Values ('Hang Over', 2, '15 May 2007', '01 Jun 2007', 5)");
            Sql("Insert Into Movies (Name, GenreId, ReleasedDate, DateAdded, NumberInStock) Values ('Die Hard', 1, '21 May 2006', '01 Jun 2007', 3)");
            Sql("Insert Into Movies (Name, GenreId, ReleasedDate, DateAdded, NumberInStock) Values ('The Terminator', 1, '05 Jun 2007', '20 Jun 2007', 1)");
            Sql("Insert Into Movies (Name, GenreId, ReleasedDate, DateAdded, NumberInStock) Values ('Toy Story', 3, '18 Jun 2007', '20 Jun 2007', 4)");
            Sql("Insert Into Movies (Name, GenreId, ReleasedDate, DateAdded, NumberInStock) Values ('Titanic', 4, '11 Jul 2007', '15 Jul 2007', 2)");
        }

        public override void Down()
        {
        }
    }
}