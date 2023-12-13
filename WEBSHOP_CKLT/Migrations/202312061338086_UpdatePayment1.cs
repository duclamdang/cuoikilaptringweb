﻿namespace WEBSHOP_CKLT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePayment1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_Order", "CustomerName", c => c.String(nullable: false));
            AlterColumn("dbo.tb_Order", "Phone", c => c.String(nullable: false));
            AlterColumn("dbo.tb_Order", "Address", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_Order", "Address", c => c.String());
            AlterColumn("dbo.tb_Order", "Phone", c => c.String());
            AlterColumn("dbo.tb_Order", "CustomerName", c => c.String());
        }
    }
}
