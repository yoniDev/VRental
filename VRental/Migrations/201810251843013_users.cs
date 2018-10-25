namespace VRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class users : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5620e630-5795-4139-bcdb-9019e48a0091', N'admin2@vrental.com', 0, N'AHY5fGPCD0dMpRD61UDqGKSLuim0yrpOs6YQVQ2o7luRp8wxOJAyol7BZFxFU3c0dg==', N'2bb5bfb3-5d33-4b59-b4cb-b3e3624d18f6', NULL, 0, 0, NULL, 1, 0, N'admin2@vrental.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'cf0ab5dd-77db-4253-a6ee-c6fd78c9a201', N'guest@vrental.com', 0, N'AFeX9G62vFctcifXLKY6+i5Hkybjl2gECXqmjBMJk5UCVpLh6AsC4PdeWi/4ipJA/w==', N'af6db64d-3a42-4bbf-9563-5dab1a052767', NULL, 0, 0, NULL, 1, 0, N'guest@vrental.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'10e7bcff-9823-49cf-a1f0-6932c7d2a043', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5620e630-5795-4139-bcdb-9019e48a0091', N'10e7bcff-9823-49cf-a1f0-6932c7d2a043')

");
        }

        public override void Down()
        {
        }
    }
}
