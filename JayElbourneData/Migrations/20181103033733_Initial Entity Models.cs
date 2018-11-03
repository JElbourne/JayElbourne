using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JayElbourneData.Migrations
{
    public partial class InitialEntityModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectStatus",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "Slug",
                table: "Projects",
                newName: "UrlSlug");

            migrationBuilder.RenameColumn(
                name: "Posted",
                table: "Projects",
                newName: "PostedOn");

            migrationBuilder.AlterColumn<string>(
                name: "Body",
                table: "Projects",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Area",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Classification",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Floors",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PlayableUrl",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RepositoryUrl",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "TrailerId",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DemoVideoId",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Programming_RepositoryUrl",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Projects",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Projects",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ProjectStatusId",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Published",
                table: "Projects",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Projects",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Credits",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    JobTitle = table.Column<string>(maxLength: 50, nullable: false),
                    FullName = table.Column<string>(maxLength: 50, nullable: false),
                    ProjectId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Credits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Credits_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImageUrl = table.Column<string>(nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    ProjectId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "References",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Url = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    ProjectId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_References", x => x.Id);
                    table.ForeignKey(
                        name: "FK_References_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Description = table.Column<string>(maxLength: 140, nullable: false),
                    UrlSlug = table.Column<string>(nullable: true),
                    ProjectId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tags_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Videos",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VideoUrl = table.Column<string>(nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    AnimationId = table.Column<long>(nullable: true),
                    FilmId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Videos_Projects_AnimationId",
                        column: x => x.AnimationId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Videos_Projects_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_TrailerId",
                table: "Projects",
                column: "TrailerId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_DemoVideoId",
                table: "Projects",
                column: "DemoVideoId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProjectStatusId",
                table: "Projects",
                column: "ProjectStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Credits_ProjectId",
                table: "Credits",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProjectId",
                table: "Images",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_References_ProjectId",
                table: "References",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_ProjectId",
                table: "Tags",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Videos_AnimationId",
                table: "Videos",
                column: "AnimationId");

            migrationBuilder.CreateIndex(
                name: "IX_Videos_FilmId",
                table: "Videos",
                column: "FilmId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Videos_TrailerId",
                table: "Projects",
                column: "TrailerId",
                principalTable: "Videos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Videos_DemoVideoId",
                table: "Projects",
                column: "DemoVideoId",
                principalTable: "Videos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Statuses_ProjectStatusId",
                table: "Projects",
                column: "ProjectStatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Videos_TrailerId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Videos_DemoVideoId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Statuses_ProjectStatusId",
                table: "Projects");

            migrationBuilder.DropTable(
                name: "Credits");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "References");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Videos");

            migrationBuilder.DropIndex(
                name: "IX_Projects_TrailerId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_DemoVideoId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_ProjectStatusId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Area",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Classification",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Floors",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "PlayableUrl",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "RepositoryUrl",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "TrailerId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "DemoVideoId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Programming_RepositoryUrl",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectStatusId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Published",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "UrlSlug",
                table: "Projects",
                newName: "Slug");

            migrationBuilder.RenameColumn(
                name: "PostedOn",
                table: "Projects",
                newName: "Posted");

            migrationBuilder.AlterColumn<string>(
                name: "Body",
                table: "Projects",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectStatus",
                table: "Projects",
                nullable: false,
                defaultValue: 0);
        }
    }
}
