namespace PVO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'33ca5509-9395-4972-8030-3e99cd6fc1d9', N'admin@pvo.com', 0, N'AGhaLq9tTIUxrF27PXdxJmdixbmLjJC6gKuSNq1u101PXsOcFK3Ly7uVgEoZtcLGcg==', N'545fe644-6bf1-44ba-ab87-163b35ea3bf1', NULL, 0, 0, NULL, 1, 0, N'admin@pvo.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f5ffab20-591b-4ff2-8731-8da897ac4467', N'guest@pvo.com', 0, N'ANihX1OiGYNotOLsK9WQY9lTdoxtVXBQ877PxcJZLfqsesdp1mZJdV1AhOXZAxcu9g==', N'1b6b7e2c-9550-40eb-8bc8-b2eb3567b37c', NULL, 0, 0, NULL, 1, 0, N'guest@pvo.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'caa61ab2-039c-4b9c-a54c-31f34449d7bf', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'33ca5509-9395-4972-8030-3e99cd6fc1d9', N'caa61ab2-039c-4b9c-a54c-31f34449d7bf')

                ");
        }
        
        public override void Down()
        {
        }
    }
}
