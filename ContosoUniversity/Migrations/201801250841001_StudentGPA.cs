namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentGPA : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Student", "GPA", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Student", "GPA");
        }
    }
}
