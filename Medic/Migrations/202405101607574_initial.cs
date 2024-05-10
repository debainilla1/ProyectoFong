namespace Medic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ActualizationPatients",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PatientCode = c.String(nullable: false, maxLength: 100),
                        PatientStatus = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.AssignedMedics",
                c => new
                    {
                        ProfessionalLicense = c.Int(nullable: false, identity: true),
                        ID = c.Int(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 100),
                        LastName = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ProfessionalLicense);
            
            CreateTable(
                "dbo.MedicStays",
                c => new
                    {
                        ChildBearingAgeWoman = c.Int(nullable: false, identity: true),
                        ID = c.Int(nullable: false),
                        DateOfEntry = c.DateTime(nullable: false),
                        DateOfDischarge = c.DateTime(nullable: false),
                        MedicalRecord = c.String(nullable: false, maxLength: 100),
                        TypeOfService = c.String(nullable: false, maxLength: 100),
                        Origin = c.String(nullable: false, maxLength: 100),
                        ReasonForDischarge = c.String(nullable: false, maxLength: 100),
                        ConditionsTreated = c.String(nullable: false, maxLength: 100),
                        Comorbidities = c.String(nullable: false, maxLength: 100),
                        ExternalCause = c.String(nullable: false, maxLength: 100),
                        HospitalAcquiredInfection = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ChildBearingAgeWoman);
            
            CreateTable(
                "dbo.PatientCompanions",
                c => new
                    {
                        Age = c.Int(nullable: false, identity: true),
                        ID = c.Int(nullable: false),
                        Gender = c.Boolean(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 100),
                        LastName = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100),
                        PhoneNumber = c.String(nullable: false, maxLength: 100),
                        CellPhoneNumber = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Age);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        SocialSecuritynumber = c.Int(nullable: false, identity: true),
                        ID = c.Int(nullable: false),
                        MaritalStatus = c.Int(nullable: false),
                        Weight = c.Int(nullable: false),
                        ZipCode = c.Int(nullable: false),
                        PhoneNumber = c.Int(nullable: false),
                        Gender = c.Boolean(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 100),
                        LastName = c.String(nullable: false, maxLength: 100),
                        Curp = c.String(nullable: false, maxLength: 100),
                        BirthPlace = c.String(nullable: false, maxLength: 100),
                        Address = c.String(nullable: false, maxLength: 100),
                        Country = c.String(nullable: false, maxLength: 100),
                        State = c.String(nullable: false, maxLength: 100),
                        Municipality = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.SocialSecuritynumber);
            
            CreateTable(
                "dbo.PatientStatus",
                c => new
                    {
                        PatientNumber = c.Int(nullable: false, identity: true),
                        ID = c.Int(nullable: false),
                        PatientCode = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.PatientNumber);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PatientStatus");
            DropTable("dbo.Patients");
            DropTable("dbo.PatientCompanions");
            DropTable("dbo.MedicStays");
            DropTable("dbo.AssignedMedics");
            DropTable("dbo.ActualizationPatients");
        }
    }
}
