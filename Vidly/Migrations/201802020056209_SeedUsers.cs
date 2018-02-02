namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'639ccf12-9944-4705-99f1-e3a9a4e5699f', N'admin@vidly.com', 0, N'AFwQ+zHT5VS4VDvoAgIvhiNe8Eb2p6E85ScCPkYxjd0iyy26YYvRE7edd/WF6ALx6Q==', N'960827a3-1de7-4c12-90fe-a817b4a5fb89', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a1226231-476f-44cf-9ff9-7caea7e24f87', N'Aubrey@vidly.com', 0, N'AElZz4e2Y5P3d00j71qazxPjRTrk8sbu10jHDQfopo8Obc3Aj8axRVQCazTfbwc9Eg==', N'9fddd789-c2fd-4b18-8f2a-32e46731c710', NULL, 0, 0, NULL, 1, 0, N'Aubrey@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e37fbe2e-59c3-42b2-bed5-2ebcac5b47c0', N'guest@vidly.com', 0, N'AI2LcA924cdYVFw+PLqEP2XpyLTioR4ipYzE62XjOBe9V+RQ6lUmbL6TuZA5rqEIag==', N'9fb40b73-09b3-4f39-bc00-842dfe33eac2', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'6794a73c-7069-4049-8295-44c82060be3c', N'CanManageMovie')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'873c87f7-6ff1-4df5-94df-16b129a9be53', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a1226231-476f-44cf-9ff9-7caea7e24f87', N'873c87f7-6ff1-4df5-94df-16b129a9be53')

");
        }

        public override void Down()
        {
        }
    }
}
