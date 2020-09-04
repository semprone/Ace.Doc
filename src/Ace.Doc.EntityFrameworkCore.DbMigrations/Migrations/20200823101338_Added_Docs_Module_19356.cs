using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ace.Doc.Migrations
{
    public partial class Added_Docs_Module_19356 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DocsDocuments",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(maxLength: 40, nullable: true),
                    ProjectId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    Version = table.Column<string>(maxLength: 128, nullable: false),
                    LanguageCode = table.Column<string>(maxLength: 128, nullable: false),
                    FileName = table.Column<string>(maxLength: 128, nullable: false),
                    Content = table.Column<string>(nullable: false),
                    Format = table.Column<string>(maxLength: 128, nullable: true),
                    EditLink = table.Column<string>(maxLength: 2048, nullable: true),
                    RootUrl = table.Column<string>(maxLength: 2048, nullable: true),
                    RawRootUrl = table.Column<string>(maxLength: 2048, nullable: true),
                    LocalDirectory = table.Column<string>(maxLength: 512, nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    LastUpdatedTime = table.Column<DateTime>(nullable: false),
                    LastSignificantUpdateTime = table.Column<DateTime>(nullable: true),
                    LastCachedTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocsDocuments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocsProjects",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(maxLength: 40, nullable: true),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    ShortName = table.Column<string>(maxLength: 32, nullable: false),
                    Format = table.Column<string>(nullable: true),
                    DefaultDocumentName = table.Column<string>(maxLength: 128, nullable: false),
                    NavigationDocumentName = table.Column<string>(maxLength: 128, nullable: false),
                    ParametersDocumentName = table.Column<string>(maxLength: 128, nullable: false),
                    MinimumVersion = table.Column<string>(nullable: true),
                    DocumentStoreType = table.Column<string>(nullable: true),
                    MainWebsiteUrl = table.Column<string>(nullable: true),
                    LatestVersionBranchName = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocsProjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocsDocumentContributors",
                columns: table => new
                {
                    DocumentId = table.Column<Guid>(nullable: false),
                    Username = table.Column<string>(nullable: false),
                    UserProfileUrl = table.Column<string>(nullable: true),
                    AvatarUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocsDocumentContributors", x => new { x.DocumentId, x.Username });
                    table.ForeignKey(
                        name: "FK_DocsDocumentContributors_DocsDocuments_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "DocsDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DocsDocumentContributors");

            migrationBuilder.DropTable(
                name: "DocsProjects");

            migrationBuilder.DropTable(
                name: "DocsDocuments");
        }
    }
}
