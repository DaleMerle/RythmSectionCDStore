using RythmSectionCDStore.Data.Enums;
using RythmSectionCDStore.Models;

namespace RythmSectionCDStore.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Stages
                if (!context.Stages.Any())
                {
                    context.Stages.AddRange(new List<Stage> {
                        new Stage()
                        {
                            Name = "Classical",
                            StageLogoURL = "https://images.pexels.com/photos/210854/pexels-photo-210854.jpeg?auto=compress&cs=tinysrgb&w=600",
                            Description = "Strings, horns, and woodwinds. Relax to the sound of Classical Music."
                        },
                        new Stage()
                        {
                            Name = "Country",
                            StageLogoURL = "https://images.pexels.com/photos/11259782/pexels-photo-11259782.jpeg?auto=compress&cs=tinysrgb&w=600",
                            Description = "Trains and twang, mount up and ride with Country Music."
                        },
                        new Stage()
                        {
                            Name = "Rock",
                            StageLogoURL = "https://images.pexels.com/photos/167629/pexels-photo-167629.jpeg?auto=compress&cs=tinysrgb&w=600",
                            Description = "Long hair, ripped jeans, and your Mom's makeup, Rock out on the Rock Stage."
                        },
                        new Stage()
                        {
                            Name = "HipHop",
                            StageLogoURL = "https://images.pexels.com/photos/122635/pexels-photo-122635.jpeg?auto=compress&cs=tinysrgb&w=600",
                            Description = "Get loose and enjoy some beats on the HipHop stage."
                        },
                    }
                        );
                    context.SaveChanges();
                }
                //Artist_Band
                if (!context.Artists.Any())
                {
                    context.Artists.AddRange(new List<Artist_Band> {
                        new Artist_Band()
                        {
                            FullName = "Liberace",
                            Bio = "Famous entertainer and pianist.",
                            ArtistPictureURL = "https://media.gettyimages.com/id/83777886/photo/american-pianist-and-entertainer-liberace-sitting-at-a-piano-wearing-a-gold-lame-suit-1950s.jpg?s=612x612&w=0&k=20&c=Dg9hsXKGNAlwDfAPRs9abEOrtnBWjx4xfhiVYdsM91c="
                        },
                        new Artist_Band()
                        {
                            FullName = "George Strait",
                            Bio = "Dubbed the King of Country music with over 90 number one hits in his professional career.",
                            ArtistPictureURL = "https://media.gettyimages.com/id/186895946/photo/musician-george-strait-speaks-during-a-press-conference-at-the-51st-annual-ascap-country-music.jpg?s=612x612&w=0&k=20&c=Vb8J3xzdVFTnKPL59-nhaMaZD-wfsQCtsFwFZ3caRDM="
                        },
                        new Artist_Band()
                        {
                            FullName = "Elvis Presley",
                            Bio = "The King of Rock-n-Roll...uh-huh.",
                            ArtistPictureURL = "https://media.gettyimages.com/id/517255590/photo/elvis-presley-runs-a-comb-through-his-famous-tresses-at-the-draftee-receiving-depot-here-on.jpg?s=612x612&w=0&k=20&c=ezwg_ODka9TbaWeYyCj39gwCvVi9AvAFfUodQ45cyXw="
                        },
                        new Artist_Band()
                        {
                            FullName = "Snoop Dogg",
                            Bio = "Was introduced at Death Row Records by Dr. Dre on his first solo single, \"Deep Cover\".",
                            ArtistPictureURL = "https://media.gettyimages.com/id/459799946/photo/rapper-snoop-dogg-poses-for-a-portrait-session-underneath-a-sign-that-warns-beward-of-the-dog.jpg?s=612x612&w=0&k=20&c=E480cjqy43Dq45dyqGDZgYz357iSFft9IelGOI9dguw="
                        },
                    });
                    context.SaveChanges();
                }
                //RecordLabel
                if (!context.RecordLabels.Any())
                {
                    context.RecordLabels.AddRange(new List<RecordLabel> {
                        new RecordLabel()
                        {
                            FullName = "Columbia Records",
                            Bio = "First record label bio.",
                            LabelPictureURL = "https://media.gettyimages.com/id/1142868749/photo/a-45-rpm-recording-of-the-1979-hit-single-you-may-be-right-on-the-columbia-record-label.jpg?s=612x612&w=0&k=20&c=ISQw1tedh09QtMtlBf-DiIpuVNqmN3c_1mVdMaswmpc="
                        },
                        new RecordLabel()
                        {
                            FullName = "MCA Records",
                            Bio = "MCA, originally Decca Records, and is now called Universal Music Group.",
                            LabelPictureURL = "https://media.gettyimages.com/id/134119615/photo/vinyl-record.jpg?s=612x612&w=0&k=20&c=HTM3tPy_xTq2ea-dXz7bO6mUOqzwO_qE6EZWNyfySEE="
                        },
                        new RecordLabel()
                        {
                            FullName = "RCA Victor Records",
                            Bio = "Third record label bio.",
                            LabelPictureURL = "https://media.gettyimages.com/id/3202170/photo/record-label-logo-for-victrola-rca-victor-showing-the-dog-nipper-looking-into-the-horn-of-a.jpg?s=612x612&w=0&k=20&c=MDfqzjkoPsldn7F-mq58aNDy_mcRfkzneTGt_SiHKug="
                        },
                        new RecordLabel()
                        {
                            FullName = "Death Row Records",
                            Bio = "Fourth record label bio.",
                            LabelPictureURL = "https://media.gettyimages.com/id/474391067/photo/snoop-lion-a-k-a-snoop-dogg-performs-live-onstage-at-the-vogue-on-february-22-2014-in.jpg?s=612x612&w=gi&k=20&c=Skvei7St1H4rcMyhK79xLUeMWBKLTH7x7dSPkC9t1Io="
                        },

                    });
                    context.SaveChanges();
                }
                //Albums
                if (!context.Albums.Any()) 
                {
                    context.Albums.AddRange(new List<Album> {
                        new Album()
                        {
                            AlbumName = "Liberace by Candlelight",
                            Year = 1953,
                            AlbumDescription = "Soothing on the ears. Liberace his piano and orchestra.",
                            Price = 24.99,
                            AlbumImageURL = "https://media.gettyimages.com/id/888836282/photo/liberace-entertains-the-audience-at-the-royal-variety-show-held-in-the-presence-of-her-her.jpg?s=612x612&w=0&k=20&c=_e2ZRvfEU2RjEnHx4ps4t_kSpQDYJrTMKp-MMdLsHr4=",
                            StartDate = DateTime.Now.AddDays(-3),
                            EndDate = DateTime.Now.AddDays(23),
                            StageId = 1,
                            RecordLabelId = 1,
                            AlbumGenre = AlbumGenre.Classical
                        },
                        new Album()
                        {
                            AlbumName = "Ocean Front Property",
                            Year = 1987,
                            AlbumDescription = "Containing hit songs, \"Ocean Front Property,\" and \"All My Exes Live In Texas.\"",
                            Price = 24.99,
                            AlbumImageURL = "https://media.gettyimages.com/id/470394254/photo/singer-musician-george-strait-poses-backstage-during-the-50th-academy-of-country-music-awards.jpg?s=612x612&w=0&k=20&c=513bKlm66A9Hku995ulWyYqJkrmyncdPN9XS9zgF_44=",
                            StartDate = DateTime.Now.AddDays(-3),
                            EndDate = DateTime.Now.AddDays(23),
                            StageId = 2,
                            RecordLabelId = 2,
                            AlbumGenre = AlbumGenre.Country
                        },
                        new Album()
                        {
                            AlbumName = "Elvis",
                            Year = 1956,
                            AlbumDescription = "Elvis debut album from 1956 featuring, \"Rip It Up.\"",
                            Price = 24.99,
                            AlbumImageURL = "https://media.gettyimages.com/id/74289877/photo/american-actor-and-singer-elvis-presley-dancing-in-a-stylized-prison-uniform-in-a-promotional.jpg?s=612x612&w=0&k=20&c=Zyn9a2GJJOsB5MABdnbwIgh8lxS2RQm3zRaWh4WjdtM=",
                            StartDate = DateTime.Now.AddDays(-3),
                            EndDate = DateTime.Now.AddDays(23),
                            StageId = 3,
                            RecordLabelId = 3,
                            AlbumGenre = AlbumGenre.Rock
                        },
                        new Album()
                        {
                            AlbumName = "Doggystyle",
                            Year = 1993,
                            AlbumDescription = "Snoop Dogg's debut album featuring, \"Lodi Dodi\" and \"Murder Was The Case.\"",
                            Price = 24.99,
                            AlbumImageURL = "https://media.gettyimages.com/id/467066492/photo/snoop-dogg-attends-hbo-game-of-thrones-presents-snoop-dogg-catch-the-throne-event-at-sxsw-on.jpg?s=612x612&w=0&k=20&c=tfnPID8Z3yXF9GdZK2D2WKuAEFD1vcvHkh9GR2s0iuQ=",
                            StartDate = DateTime.Now.AddDays(-3),
                            EndDate = DateTime.Now.AddDays(23),
                            StageId = 1,
                            RecordLabelId = 2,
                            AlbumGenre = AlbumGenre.Rock
                        },
                    });
                    context.SaveChanges();
                }
                //Artists & Albums
                if (!context.Artists_Albums.Any())
                {
                    context.Artists_Albums.AddRange(new List<Artist_Album> {
                        new Artist_Album()
                        {
                            ArtistId = 0,
                            AlbumId = 0
                        },
                        new Artist_Album()
                        {
                            ArtistId = 1,
                            AlbumId = 1
                        },
                        new Artist_Album()
                        {
                            ArtistId = 2,
                            AlbumId = 2
                        },
                        new Artist_Album()
                        {
                            ArtistId = 3,
                            AlbumId = 3
                        },
                    });
                    context.SaveChanges();
                }
            }

        }
    }
}
