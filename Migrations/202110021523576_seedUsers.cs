namespace JoeMovies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedUsers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0b9c66b5-6b74-4b56-8e12-22b21b90843f', N'guest@joemovies.com', 0, N'ABuiMPf0yaaXDSn+TMxk01UtpWBI1v0bAsnL6Gikvvr9bZH+Tz+fxL9oHXY8WKJr3A==', N'8d274c11-7165-415e-b882-4d8f8b16ed50', NULL, 0, 0, NULL, 1, 0, N'guest@joemovies.com')\r\nINSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'60f986c4-94da-4b58-bde8-d04d6f26ffb4', N'admin2@joemovies.com', 0, N'APhATt5t4IIz2eYpPAVASF/e0Hf/J6GIdPSTpEP9292WKQsrRTR3nGeMEUXqK4F5IQ==', N'309b3ce0-79ec-46dc-9285-1cf7eb629cd1', NULL, 0, 0, NULL, 1, 0, N'admin2@joemovies.com')\r\nINSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'938b14bc-c154-4f4e-abfe-76f4f5ae004f', N'tikane@domain.co.za', 0, N'AH4KhTIakZmnMQ74Q6zwX/Ri6sAbeig/2b3uxAsv2eiJE5fBNg7uHw1SOSTYzfFBeA==', N'18ba4070-9d36-439b-81c0-4ee5b6e3fd5d', NULL, 0, 0, NULL, 1, 0, N'tikane@domain.co.za')\r\n");
            Sql("INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'34a529ae-0cf6-484f-87c4-66672c687ed0', N'CanManageMovies')");
            Sql("INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'60f986c4-94da-4b58-bde8-d04d6f26ffb4', N'34a529ae-0cf6-484f-87c4-66672c687ed0')");
        }
        
        public override void Down()
        {
        }
    }
}
