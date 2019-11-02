namespace CursoMVCUdemy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class observacao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produto", "observacao", c => c.String(maxLength: 8000, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produto", "observacao");
        }
    }
}
