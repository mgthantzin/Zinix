namespace Zinix.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateMembershipTypeNames : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes Set Name = 'Pay-as-you-go' Where Id = 1");
            Sql("Update MembershipTypes Set Name = 'Monthly' Where Id = 2");
            Sql("Update MembershipTypes Set Name = 'Quarterly' Where Id = 3");
            Sql("Update MembershipTypes Set Name = 'Annually' Where Id = 4");
        }

        public override void Down()
        {
        }
    }
}