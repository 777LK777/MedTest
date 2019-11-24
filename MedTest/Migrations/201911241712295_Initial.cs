namespace MedTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        DateOfVisit = c.DateTime(nullable: false),
                        Diagnosis = c.String(nullable: false),
                        Patient_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Patients", t => t.Patient_Id)
                .Index(t => t.Patient_Id);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Patronymic = c.String(),
                        Sex = c.String(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        Address = c.String(nullable: false),
                        TelephoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Appointments", new[] { "Patient_Id" });
            DropForeignKey("dbo.Appointments", "Patient_Id", "dbo.Patients");
            DropTable("dbo.Patients");
            DropTable("dbo.Appointments");
        }
    }
}
