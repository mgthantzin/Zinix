namespace Zinix.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SetCustomerDOBNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "DateOfBirth", c => c.DateTime());
        }

        public override void Down()
        {
            AlterColumn("dbo.Customers", "DateOfBirth", c => c.DateTime(nullable: false));
        }
    }
}