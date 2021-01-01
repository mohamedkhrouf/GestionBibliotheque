namespace GB.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adherents",
                c => new
                    {
                        Id_Adherent = c.Int(nullable: false, identity: true),
                        Nom = c.String(nullable: false),
                        Prenom = c.String(nullable: false),
                        Login = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Bibliotheque_Id_Bibliotheque = c.Int(),
                    })
                .PrimaryKey(t => t.Id_Adherent)
                .ForeignKey("dbo.Bibliotheques", t => t.Bibliotheque_Id_Bibliotheque)
                .Index(t => t.Bibliotheque_Id_Bibliotheque);
            
            CreateTable(
                "dbo.Emprunt",
                c => new
                    {
                        DateEmprunt = c.DateTime(nullable: false),
                        AdherentFK = c.Int(nullable: false),
                        DocumentFK = c.Int(nullable: false),
                        DateRetour = c.DateTime(),
                        DureeEmprunt = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.DateEmprunt, t.AdherentFK, t.DocumentFK })
                .ForeignKey("dbo.Adherents", t => t.AdherentFK, cascadeDelete: true)
                .ForeignKey("dbo.Documents", t => t.DocumentFK, cascadeDelete: true)
                .Index(t => t.AdherentFK)
                .Index(t => t.DocumentFK);
            
            CreateTable(
                "dbo.Documents",
                c => new
                    {
                        Id_Document = c.Int(nullable: false, identity: true),
                        Titre = c.String(),
                        Resume = c.String(),
                        BibliothequeFK = c.Int(nullable: false),
                        DateParution = c.DateTime(),
                        Auteur = c.String(),
                        Dessinateur = c.String(),
                        Langue = c.String(),
                        NbPages = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id_Document)
                .ForeignKey("dbo.Bibliotheques", t => t.BibliothequeFK)
                .Index(t => t.BibliothequeFK);
            
            CreateTable(
                "dbo.Bibliotheques",
                c => new
                    {
                        Id_Bibliotheque = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id_Bibliotheque);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Emprunt", "DocumentFK", "dbo.Documents");
            DropForeignKey("dbo.Documents", "BibliothequeFK", "dbo.Bibliotheques");
            DropForeignKey("dbo.Adherents", "Bibliotheque_Id_Bibliotheque", "dbo.Bibliotheques");
            DropForeignKey("dbo.Emprunt", "AdherentFK", "dbo.Adherents");
            DropIndex("dbo.Documents", new[] { "BibliothequeFK" });
            DropIndex("dbo.Emprunt", new[] { "DocumentFK" });
            DropIndex("dbo.Emprunt", new[] { "AdherentFK" });
            DropIndex("dbo.Adherents", new[] { "Bibliotheque_Id_Bibliotheque" });
            DropTable("dbo.Bibliotheques");
            DropTable("dbo.Documents");
            DropTable("dbo.Emprunt");
            DropTable("dbo.Adherents");
        }
    }
}
