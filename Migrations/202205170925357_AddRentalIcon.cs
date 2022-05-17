namespace S00209545_Exam_2022_OOD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRentalIcon : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RentalProperties", "RentalIcon", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.RentalProperties", "RentalIcon");
        }
    }
}
