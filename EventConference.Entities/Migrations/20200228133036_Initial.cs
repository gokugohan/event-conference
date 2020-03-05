using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EventConference.Entities.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 2, 28, 22, 30, 34, 495, DateTimeKind.Local).AddTicks(9235)),
                    UpdatedAt = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 2, 28, 22, 30, 34, 504, DateTimeKind.Local).AddTicks(2089))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    SubTitle = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    TrailerVideoLink = table.Column<string>(nullable: true),
                    HeaderBanner = table.Column<string>(nullable: true),
                    Quote = table.Column<string>(nullable: true),
                    Summary = table.Column<string>(nullable: true),
                    About = table.Column<string>(nullable: true),
                    When = table.Column<string>(nullable: true),
                    Venue = table.Column<string>(nullable: true),
                    Latitude = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    OrganizedBy = table.Column<string>(nullable: true),
                    EndorsedBy = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 2, 28, 22, 30, 34, 537, DateTimeKind.Local).AddTicks(1760)),
                    UpdatedAt = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 2, 28, 22, 30, 34, 537, DateTimeKind.Local).AddTicks(2694)),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                });

            migrationBuilder.CreateTable(
                name: "Faqs",
                columns: table => new
                {
                    FaqId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(nullable: true),
                    Answer = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 2, 28, 22, 30, 34, 552, DateTimeKind.Local).AddTicks(787)),
                    UpdatedAt = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 2, 28, 22, 30, 34, 552, DateTimeKind.Local).AddTicks(2194))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faqs", x => x.FaqId);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    SettingId = table.Column<Guid>(nullable: false),
                    Key = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Group = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 2, 28, 22, 30, 34, 545, DateTimeKind.Local).AddTicks(3607)),
                    UpdatedAt = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 2, 28, 22, 30, 34, 545, DateTimeKind.Local).AddTicks(4614))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.SettingId);
                });

            migrationBuilder.CreateTable(
                name: "Venues",
                columns: table => new
                {
                    VenueId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Latitude = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 2, 28, 22, 30, 34, 578, DateTimeKind.Local).AddTicks(8574)),
                    UpdatedAt = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 2, 28, 22, 30, 34, 579, DateTimeKind.Local).AddTicks(156))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venues", x => x.VenueId);
                });

            migrationBuilder.CreateTable(
                name: "Participants",
                columns: table => new
                {
                    ParticipantId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    JobTitle = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    CountryId = table.Column<int>(nullable: false, defaultValue: 1),
                    CreatedAt = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 2, 28, 22, 30, 34, 575, DateTimeKind.Local).AddTicks(6040)),
                    UpdatedAt = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 2, 28, 22, 30, 34, 575, DateTimeKind.Local).AddTicks(7337))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participants", x => x.ParticipantId);
                    table.ForeignKey(
                        name: "FK_Participants_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Galleries",
                columns: table => new
                {
                    GalleryId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 2, 28, 22, 30, 34, 557, DateTimeKind.Local).AddTicks(4687)),
                    UpdatedAt = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 2, 28, 22, 30, 34, 557, DateTimeKind.Local).AddTicks(5658)),
                    EventId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galleries", x => x.GalleryId);
                    table.ForeignKey(
                        name: "FK_Galleries_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Speakers",
                columns: table => new
                {
                    SpeakerId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    CountryId = table.Column<int>(nullable: false, defaultValue: 1),
                    Description = table.Column<string>(nullable: true),
                    Biography = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true),
                    Twitter = table.Column<string>(nullable: true),
                    Facebook = table.Column<string>(nullable: true),
                    LinkedIn = table.Column<string>(nullable: true),
                    FullDescription = table.Column<string>(nullable: true),
                    Avatar = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 2, 28, 22, 30, 34, 532, DateTimeKind.Local).AddTicks(767)),
                    UpdatedAt = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 2, 28, 22, 30, 34, 532, DateTimeKind.Local).AddTicks(2122)),
                    EventId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speakers", x => x.SpeakerId);
                    table.ForeignKey(
                        name: "FK_Speakers_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Speakers_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sponsors",
                columns: table => new
                {
                    SponsorId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Link = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    EventId = table.Column<Guid>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 2, 28, 22, 30, 34, 548, DateTimeKind.Local).AddTicks(7873)),
                    UpdatedAt = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 2, 28, 22, 30, 34, 548, DateTimeKind.Local).AddTicks(9375))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sponsors", x => x.SponsorId);
                    table.ForeignKey(
                        name: "FK_Sponsors_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Volunteers",
                columns: table => new
                {
                    VolunteerId = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    CountryId = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    AgeRange = table.Column<string>(nullable: true),
                    HasVolunteered = table.Column<bool>(nullable: false),
                    AgreeTermAndCondigion = table.Column<bool>(nullable: false),
                    EventId = table.Column<Guid>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Volunteers", x => x.VolunteerId);
                    table.ForeignKey(
                        name: "FK_Volunteers_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Volunteers_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Media",
                columns: table => new
                {
                    MediaId = table.Column<Guid>(nullable: false),
                    ImagePath = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    GalleryId = table.Column<Guid>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 2, 28, 22, 30, 34, 559, DateTimeKind.Local).AddTicks(3278)),
                    UpdatedAt = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 2, 28, 22, 30, 34, 559, DateTimeKind.Local).AddTicks(4322))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Media", x => x.MediaId);
                    table.ForeignKey(
                        name: "FK_Media_Galleries_GalleryId",
                        column: x => x.GalleryId,
                        principalTable: "Galleries",
                        principalColumn: "GalleryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    SessionId = table.Column<Guid>(nullable: false),
                    DayNumber = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Abstract = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    StartTime = table.Column<DateTimeOffset>(nullable: true),
                    EndTime = table.Column<DateTimeOffset>(nullable: true),
                    SpeakerId = table.Column<Guid>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 2, 28, 22, 30, 34, 614, DateTimeKind.Local).AddTicks(9461)),
                    UpdatedAt = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 2, 28, 22, 30, 34, 615, DateTimeKind.Local).AddTicks(755)),
                    EventId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.SessionId);
                    table.ForeignKey(
                        name: "FK_Sessions_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sessions_Speakers_SpeakerId",
                        column: x => x.SpeakerId,
                        principalTable: "Speakers",
                        principalColumn: "SpeakerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SessionParticipant",
                columns: table => new
                {
                    ParticipantId = table.Column<Guid>(nullable: false),
                    SessionId = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 2, 28, 22, 30, 34, 607, DateTimeKind.Local).AddTicks(1652)),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SessionParticipant", x => new { x.SessionId, x.ParticipantId });
                    table.ForeignKey(
                        name: "FK_SessionParticipant_Participants_ParticipantId",
                        column: x => x.ParticipantId,
                        principalTable: "Participants",
                        principalColumn: "ParticipantId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SessionParticipant_Sessions_SessionId",
                        column: x => x.SessionId,
                        principalTable: "Sessions",
                        principalColumn: "SessionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "Name" },
                values: new object[,]
                {
                    { 1, "Timor-Leste" },
                    { 2, "Indonesia" },
                    { 3, "Portugal" },
                    { 4, "Australia" },
                    { 5, "New Zealand" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "About", "Active", "Date", "Description", "EndorsedBy", "HeaderBanner", "Latitude", "Longitude", "OrganizedBy", "Quote", "SubTitle", "Summary", "Title", "TrailerVideoLink", "Venue", "When" },
                values: new object[,]
                {
                    { new Guid("d021a8e6-14c7-4aaa-88f9-ff7d33043a06"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", true, new DateTime(2020, 2, 28, 13, 30, 34, 538, DateTimeKind.Utc).AddTicks(3786), "", "LOREM IPSUM", null, "-8.560096", "125.579218", "LOREM IPSUM", "“There is no one who loves pain itself, who seeks after it and wants to have it, simply because it is pain...” - <span>Lorem Ipsum.</span>", "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...", "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...", "“There is no one who loves pain itself, who seeks after it and wants to have it, simply because it is pain...” - <span>Lorem Ipsum.</span>", "https://www.youtube.com/watch?v=jDDaplaOz7Q", "Díli Convention Center, Mercado Lama, Caicoli, Timor-Leste", "Monday to Wednesday<br>10-12 December" },
                    { new Guid("4e97c256-a162-44c6-b79c-c950c15cfe5e"), "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo", false, new DateTime(2020, 2, 28, 13, 30, 34, 541, DateTimeKind.Utc).AddTicks(1336), "", "GERASAUN OSSO-HUNA", null, "-8.656648", "126.625446", "OSSO-HUNA ANAN", "“Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...” - <span>Lorem Ipsum.</span>", "Lorem Ipsum is simply dummy text of the printing and typesetting industry", "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium", "“Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...” - <span>Lorem Ipsum.</span>", "https://www.youtube.com/watch?v=jDDaplaOz7Q", "Baguia Convention Center, Osso-Huna, Baguia, Timor-Leste", "Wednesday to Friday<br>10-12 December" }
                });

            migrationBuilder.InsertData(
                table: "Faqs",
                columns: new[] { "FaqId", "Answer", "Question" },
                values: new object[,]
                {
                    { 6, "Enim qui fuga aliquid et recusandae porro ipsam. Praesentium molestiae qui nisi illum praesentium quia accusamus dolores. Ut aut sed magnam sit dolorum dolores nesciunt.", "Occaecati a et sapiente et veritatis sunt ea." },
                    { 5, "Est sit sint modi fugit a voluptate. Incidunt qui impedit blanditiis sint animi nobis. Esse mollitia autem sunt quia aliquid.", "Voluptatem culpa odit repudiandae at omnis magni." },
                    { 4, "Occaecati doloremque aut nulla ut ut repudiandae. Quam sed saepe omnis sit.", "Dolorem dolores iusto accusamus qui illum qui ipsum." },
                    { 2, "Est et occaecati asperiores natus. Quia aut velit omnis. Fugiat necessitatibus natus quo ratione in voluptas minus quam. Quia et quam autem est aut et.", "Sint deleniti dolorem enim ipsum.	" },
                    { 1, "Aut sequi aliquam deleniti. Dolore rerum aliquid maiores velit laudantium nam. Perspiciatis dignissimos culpa non et natus laboriosam. Quisquam eos eveniet et facere.", "Unde a ut eligendi dolor ducimus." },
                    { 3, "Corrupti qui ad dolorem quos quod quaerat. Dolorem adipisci in sint doloremque eum ut ut. Fuga eos quod qui optio illum. Et totam officiis culpa.", "Provident sit tempore blanditiis et aut est." }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "SessionId", "Abstract", "Date", "DayNumber", "EndTime", "EventId", "SpeakerId", "StartTime", "Title" },
                values: new object[,]
                {
                    { new Guid("25b314c7-0d41-4824-a836-ac6e52605e41"), "Abstract of session 01", new DateTime(2020, 2, 28, 22, 30, 34, 649, DateTimeKind.Local).AddTicks(894), 2, new DateTimeOffset(new DateTime(2020, 10, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)), null, null, new DateTimeOffset(new DateTime(2020, 10, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)), "Session 05" },
                    { new Guid("eeadf9a5-97d7-4a9c-9d42-4d1fee4cdb69"), "Abstract of session 01", new DateTime(2020, 2, 28, 22, 30, 34, 649, DateTimeKind.Local).AddTicks(1152), 3, new DateTimeOffset(new DateTime(2020, 10, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)), null, null, new DateTimeOffset(new DateTime(2020, 10, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)), "Session 05" },
                    { new Guid("2f39764f-3482-4950-97ec-db5a601b3d71"), "Abstract of session 01", new DateTime(2020, 2, 28, 22, 30, 34, 649, DateTimeKind.Local).AddTicks(1116), 3, new DateTimeOffset(new DateTime(2020, 10, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)), null, null, new DateTimeOffset(new DateTime(2020, 10, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)), "Session 05" },
                    { new Guid("3129cb2b-1e9a-4994-b2d0-2d849779e7ab"), "Abstract of session 01", new DateTime(2020, 2, 28, 22, 30, 34, 649, DateTimeKind.Local).AddTicks(1038), 3, new DateTimeOffset(new DateTime(2020, 10, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)), null, null, new DateTimeOffset(new DateTime(2020, 10, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)), "Session 04" },
                    { new Guid("3f28760e-41d6-4cf9-b907-0f7adb787488"), "Abstract of session 01", new DateTime(2020, 2, 28, 22, 30, 34, 649, DateTimeKind.Local).AddTicks(983), 3, new DateTimeOffset(new DateTime(2020, 10, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)), null, null, new DateTimeOffset(new DateTime(2020, 10, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)), "Session 03" },
                    { new Guid("fc05b41d-fb4a-473e-aa5e-2721a16db1ff"), "Abstract of session 01", new DateTime(2020, 2, 28, 22, 30, 34, 649, DateTimeKind.Local).AddTicks(954), 3, new DateTimeOffset(new DateTime(2020, 10, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)), null, null, new DateTimeOffset(new DateTime(2020, 10, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)), "Session 02" },
                    { new Guid("d5edcd77-ce0a-4f0f-863a-68cf93e27acd"), "Abstract of session 01", new DateTime(2020, 2, 28, 22, 30, 34, 649, DateTimeKind.Local).AddTicks(924), 3, new DateTimeOffset(new DateTime(2020, 10, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)), null, null, new DateTimeOffset(new DateTime(2020, 10, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)), "Session 01" },
                    { new Guid("3bab72d5-faef-4890-acb4-4caacc5d4e16"), "Abstract of session 01", new DateTime(2020, 2, 28, 22, 30, 34, 649, DateTimeKind.Local).AddTicks(834), 2, new DateTimeOffset(new DateTime(2020, 10, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)), null, null, new DateTimeOffset(new DateTime(2020, 10, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)), "Session 04" },
                    { new Guid("cf04a340-4574-4c37-bf6e-59d42162c4aa"), "Abstract of session 01", new DateTime(2020, 2, 28, 22, 30, 34, 649, DateTimeKind.Local).AddTicks(865), 2, new DateTimeOffset(new DateTime(2020, 10, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)), null, null, new DateTimeOffset(new DateTime(2020, 10, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)), "Session 05" },
                    { new Guid("39e99574-dca6-48c0-8ca1-f93126b0d447"), "Abstract of session 01", new DateTime(2020, 2, 28, 22, 30, 34, 649, DateTimeKind.Local).AddTicks(769), 2, new DateTimeOffset(new DateTime(2020, 10, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)), null, null, new DateTimeOffset(new DateTime(2020, 10, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)), "Session 02" },
                    { new Guid("91ef1872-97f9-42b9-bf85-3c622d08f273"), "Abstract of session 01", new DateTime(2020, 2, 28, 22, 30, 34, 649, DateTimeKind.Local).AddTicks(683), 2, new DateTimeOffset(new DateTime(2020, 10, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)), null, null, new DateTimeOffset(new DateTime(2020, 10, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)), "Session 01" },
                    { new Guid("641def96-632c-432a-8415-e46df3807349"), "Abstract of session 01", new DateTime(2020, 2, 28, 22, 30, 34, 649, DateTimeKind.Local).AddTicks(649), 1, new DateTimeOffset(new DateTime(2020, 10, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)), null, null, new DateTimeOffset(new DateTime(2020, 10, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)), "Session 05" },
                    { new Guid("f8c2fa68-77d9-4e51-9c42-2865c672e7c7"), "Abstract of session 01", new DateTime(2020, 2, 28, 22, 30, 34, 649, DateTimeKind.Local).AddTicks(604), 1, new DateTimeOffset(new DateTime(2020, 10, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)), null, null, new DateTimeOffset(new DateTime(2020, 10, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)), "Session 05" },
                    { new Guid("bd781183-83eb-4f39-bcda-486d4fd64062"), "Abstract of session 01", new DateTime(2020, 2, 28, 22, 30, 34, 649, DateTimeKind.Local).AddTicks(572), 1, new DateTimeOffset(new DateTime(2020, 10, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)), null, null, new DateTimeOffset(new DateTime(2020, 10, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)), "Session 04" },
                    { new Guid("f61805d8-67bd-4872-a2a7-29e391fd4170"), "Abstract of session 01", new DateTime(2020, 2, 28, 22, 30, 34, 649, DateTimeKind.Local).AddTicks(537), 1, new DateTimeOffset(new DateTime(2020, 10, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)), null, null, new DateTimeOffset(new DateTime(2020, 10, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)), "Session 03" },
                    { new Guid("f19c989b-2bd2-4ca2-8b70-037ffd7e1676"), "Abstract of session 01", new DateTime(2020, 2, 28, 22, 30, 34, 649, DateTimeKind.Local).AddTicks(471), 1, new DateTimeOffset(new DateTime(2020, 10, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)), null, null, new DateTimeOffset(new DateTime(2020, 10, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)), "Session 02" },
                    { new Guid("1db3f940-0b1b-44c0-80d2-af19ed7ab770"), "Abstract of session 01", new DateTime(2020, 2, 28, 22, 30, 34, 648, DateTimeKind.Local).AddTicks(8572), 1, new DateTimeOffset(new DateTime(2020, 10, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)), null, null, new DateTimeOffset(new DateTime(2020, 10, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)), "Session 01" },
                    { new Guid("45be8f78-40ea-4253-a330-9aaca9a2314f"), "Abstract of session 01", new DateTime(2020, 2, 28, 22, 30, 34, 649, DateTimeKind.Local).AddTicks(799), 2, new DateTimeOffset(new DateTime(2020, 10, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)), null, null, new DateTimeOffset(new DateTime(2020, 10, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)), "Session 03" }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "SettingId", "Group", "Key", "Name", "Type", "Value" },
                values: new object[,]
                {
                    { new Guid("d15cd319-e151-4f79-a762-e5c273817206"), "Footer", "linkedin", "LinkedIn", "text", "#!" },
                    { new Guid("250f5da5-38fa-40af-ad50-e1143650568b"), "Footer", "instagram", "Instagram", "text", "#!" },
                    { new Guid("fb7d9447-fb2c-4b35-8786-ff62bcd3d97f"), "Footer", "facebook", "Facebook", "text", "#!" },
                    { new Guid("3785682b-314b-4bc2-9a6e-93e4b05da6d8"), "Footer", "twitter", "Twitter", "text", "#!" },
                    { new Guid("ae98a0e5-df67-4a7d-ac74-8ac6b78e2e00"), "Footer", "footer_description", "Footer Description", "textarea", "In alias aperiam. Placeat tempore facere. Officiis voluptate ipsam vel eveniet est dolor et totam porro. Perspiciatis ad omnis fugit molestiae recusandae possimus. Aut consectetur id quis. In inventore consequatur ad voluptate cupiditate debitis accusamus repellat cumque.	" },
                    { new Guid("67fe7cdf-0460-4bca-a829-46a3acbde541"), "Contact", "contact_phone", "Contact phone", "text", "+(670) 331 017 9" },
                    { new Guid("b93cf308-62fa-479d-9d9a-7c2c35d53257"), "Contact", "contact_address", "Contact address", "text", "Rua Delta 1, Aimutin Comoro, Dili. Timor-Leste" },
                    { new Guid("4c4108de-b0c4-45e4-9ed8-0c56fa09757d"), "Site", "site_header_image", "Site Background Header", "file", null },
                    { new Guid("90939d8c-0bb2-484f-9c8d-67c6036e31a9"), "Site", "site_name", "Site Name", "text", "LOREM-IPSUM" },
                    { new Guid("a70ce964-7419-4c4f-9a6e-b9e06c5f37b0"), "Contact", "contact_email", "Contact email", "email", "helder@chebre.net" }
                });

            migrationBuilder.InsertData(
                table: "Speakers",
                columns: new[] { "SpeakerId", "Avatar", "Biography", "Description", "Email", "EventId", "Facebook", "FullDescription", "LinkedIn", "Name", "Phone", "Twitter", "Website" },
                values: new object[,]
                {
                    { new Guid("721b883b-0242-4525-ae82-bccefb538aed"), "/img/goku.png", null, "Description of Speaker 5", null, null, "#!", "FullDescription of Speaker 5", "#!", "Speaker 5", null, "#!", "#!" },
                    { new Guid("38245951-eded-43f5-b03c-c6dfd395475a"), "/img/goku.png", null, "Description of Speaker 1", null, null, "#!", "FullDescription of Speaker 1", "#!", "Speaker 1", null, "#!", "#!" },
                    { new Guid("c68f084d-f011-402c-9916-8275b2a265c6"), "/img/goku.png", null, "Description of Speaker 2", null, null, "#!", "FullDescription of Speaker 2", "#!", "Speaker 2", null, "#!", "#!" },
                    { new Guid("c4978272-223a-409a-9885-1038cdaa52b1"), "/img/goku.png", null, "Description of Speaker 3", null, null, "#!", "FullDescription of Speaker 3", "#!", "Speaker 3", null, "#!", "#!" },
                    { new Guid("1a3952ef-4844-41ff-94c8-f3d3873d652c"), "/img/goku.png", null, "Description of Speaker 4", null, null, "#!", "FullDescription of Speaker 4", "#!", "Speaker 4", null, "#!", "#!" }
                });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "VenueId", "Address", "Description", "Latitude", "Longitude", "Name" },
                values: new object[] { 1, "Mercado Lama, Caicoli, Timor-Leste", "Iste nobis eum sapiente sunt enim dolores labore accusantium autem. Cumque beatae ipsam. Est quae sit qui voluptatem corporis velit. Qui maxime accusamus possimus. Consequatur sequi et ea suscipit enim nesciunt quia velit.", "-8.560096", "125.579218", "Díli Convention Center" });

            migrationBuilder.CreateIndex(
                name: "IX_Events_Active",
                table: "Events",
                column: "Active",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Galleries_EventId",
                table: "Galleries",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Media_GalleryId",
                table: "Media",
                column: "GalleryId");

            migrationBuilder.CreateIndex(
                name: "IX_Participants_CountryId",
                table: "Participants",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Participants_Email",
                table: "Participants",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Participants_Name",
                table: "Participants",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SessionParticipant_ParticipantId",
                table: "SessionParticipant",
                column: "ParticipantId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_EventId",
                table: "Sessions",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_SpeakerId",
                table: "Sessions",
                column: "SpeakerId");

            migrationBuilder.CreateIndex(
                name: "IX_Speakers_CountryId",
                table: "Speakers",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Speakers_EventId",
                table: "Speakers",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Speakers_Name",
                table: "Speakers",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sponsors_EventId",
                table: "Sponsors",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Volunteers_CountryId",
                table: "Volunteers",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Volunteers_EventId",
                table: "Volunteers",
                column: "EventId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Faqs");

            migrationBuilder.DropTable(
                name: "Media");

            migrationBuilder.DropTable(
                name: "SessionParticipant");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "Sponsors");

            migrationBuilder.DropTable(
                name: "Venues");

            migrationBuilder.DropTable(
                name: "Volunteers");

            migrationBuilder.DropTable(
                name: "Galleries");

            migrationBuilder.DropTable(
                name: "Participants");

            migrationBuilder.DropTable(
                name: "Sessions");

            migrationBuilder.DropTable(
                name: "Speakers");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Events");
        }
    }
}
