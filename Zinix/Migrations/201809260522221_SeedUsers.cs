namespace Zinix.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7a54bf9f-00fc-483a-9cc3-760fb98b5bda', N'guest@thantzinoo.net', 0, N'ANiXbNGLcl+pf78vE7/6vaJcLfiQ4BOgBKkxiJKnpOjfuF++GpGjz8GNRq0K/DBOCQ==', N'a3b7b1ce-7e82-4764-9cb1-12414d47e92c', NULL, 0, 0, NULL, 1, 0, N'guest@thantzinoo.net')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'925a5046-fcf6-4604-a2bf-58bb489ea7b8', N'admin@thantzinoo.net', 0, N'AFyiTsLbOEW+vG45KXgxcjE1brsWQVLDrqd96tITJ2Xy5ZskV5doxumd9tg6tBslbQ==', N'c7eb464e-5ef3-409c-8ede-4365fb1420bc', NULL, 0, 0, NULL, 1, 0, N'admin@thantzinoo.net')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'6487422b-e214-4221-95bf-8d031122d500', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'925a5046-fcf6-4604-a2bf-58bb489ea7b8', N'6487422b-e214-4221-95bf-8d031122d500')
                ");
        }

        public override void Down()
        {
        }
    }
}