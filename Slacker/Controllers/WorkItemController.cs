using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using AngularJSWebApiEmpty.Models;
using Newtonsoft.Json;

namespace AngularJSWebApiEmpty.Controllers
{
    [RoutePrefix("api/Songs")]
    public class SongController : ApiController
    {
        [HttpGet, Route("Get")]
        public IHttpActionResult Get()
        {
            return Ok(GetHideousData());
        }

        private List<Song> GetHideousData()
        {
            var songs = new List<Song>()
            {
                new Song()
                {
                    SongId = 31196,
                    Name = "10,000 Reasons",
                    PlayCount = 13,
                    LastPlayed = new DateTime(2015, 10, 11)
                },
                new Song()
                {
                    SongId = 5618,
                    Name = "All The Earth Will Sing Your Praises",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2015, 11, 22)
                },
                new Song()
                {
                    SongId = 425,
                    Name = "All Who Are Thirsty",
                    PlayCount = 8,
                    LastPlayed = new DateTime(2015, 08, 30)
                },
                new Song() {SongId = 3730, Name = "Amazed", PlayCount = 1, LastPlayed = new DateTime(2015, 05, 17)},
                new Song()
                {
                    SongId = 3649,
                    Name = "Amazing Grace",
                    PlayCount = 2,
                    LastPlayed = new DateTime(2014, 07, 06)
                },
                new Song()
                {
                    SongId = 2589,
                    Name = "Amazing Grace (My Chains Are Gone)",
                    PlayCount = 6,
                    LastPlayed = new DateTime(2015, 10, 11)
                },
                new Song()
                {
                    SongId = 17018,
                    Name = "Angels We Have Heard on High",
                    PlayCount = 2,
                    LastPlayed = new DateTime(2015, 12, 26)
                },
                new Song()
                {
                    SongId = 3401,
                    Name = "Answer The Call",
                    PlayCount = 3,
                    LastPlayed = new DateTime(2014, 06, 29)
                },
                new Song()
                {
                    SongId = 12213,
                    Name = "Awesome God",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2015, 05, 02)
                },
                new Song()
                {
                    SongId = 57870,
                    Name = "Because He Lives (amen)",
                    PlayCount = 8,
                    LastPlayed = new DateTime(2015, 08, 30)
                },
                new Song()
                {
                    SongId = 5836,
                    Name = "Because Of Your Love",
                    PlayCount = 2,
                    LastPlayed = new DateTime(2015, 11, 22)
                },
                new Song()
                {
                    SongId = 38516,
                    Name = "Beneath The Waters (I Will Rise)",
                    PlayCount = 2,
                    LastPlayed = new DateTime(2015, 08, 02)
                },
                new Song() {SongId = 22990, Name = "Big House", PlayCount = 1, LastPlayed = new DateTime(2014, 12, 05)},
                new Song()
                {
                    SongId = 104,
                    Name = "Blessed Be Your Name",
                    PlayCount = 8,
                    LastPlayed = new DateTime(2015, 09, 19)
                },
                new Song()
                {
                    SongId = 35577,
                    Name = "Build Your Kingdom Here",
                    PlayCount = 9,
                    LastPlayed = new DateTime(2015, 09, 05)
                },
                new Song()
                {
                    SongId = 25605,
                    Name = "By His Wounds",
                    PlayCount = 3,
                    LastPlayed = new DateTime(2015, 07, 25)
                },
                new Song()
                {
                    SongId = 8115,
                    Name = "Carry The Call",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2014, 05, 04)
                },
                new Song()
                {
                    SongId = 51699,
                    Name = "Come As You Are",
                    PlayCount = 7,
                    LastPlayed = new DateTime(2015, 11, 22)
                },
                new Song()
                {
                    SongId = 35,
                    Name = "Come Now Is The Time To Worship",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2014, 07, 12)
                },
                new Song()
                {
                    SongId = 2612,
                    Name = "Come Thou Fount",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2015, 11, 22)
                },
                new Song()
                {
                    SongId = 36918,
                    Name = "Cornerstone",
                    PlayCount = 2,
                    LastPlayed = new DateTime(2015, 08, 02)
                },
                new Song()
                {
                    SongId = 2858,
                    Name = "Days Of Elijah",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2014, 05, 18)
                },
                new Song() {SongId = 25148, Name = "Doxology", PlayCount = 1, LastPlayed = new DateTime(2015, 10, 31)},
                new Song()
                {
                    SongId = 139,
                    Name = "Draw Me Close",
                    PlayCount = 2,
                    LastPlayed = new DateTime(2015, 06, 14)
                },
                new Song()
                {
                    SongId = 58801,
                    Name = "Even So Come",
                    PlayCount = 5,
                    LastPlayed = new DateTime(2016, 01, 09)
                },
                new Song() {SongId = 57181, Name = "Ever Be", PlayCount = 4, LastPlayed = new DateTime(2015, 11, 14)},
                new Song()
                {
                    SongId = 24647,
                    Name = "Everlasting God",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2014, 10, 19)
                },
                new Song()
                {
                    SongId = 3291,
                    Name = "For Who You Are",
                    PlayCount = 2,
                    LastPlayed = new DateTime(2015, 05, 17)
                },
                new Song() {SongId = 1536, Name = "Forever", PlayCount = 2, LastPlayed = new DateTime(2015, 01, 04)},
                new Song()
                {
                    SongId = 23587,
                    Name = "Forever Reign",
                    PlayCount = 3,
                    LastPlayed = new DateTime(2014, 09, 20)
                },
                new Song()
                {
                    SongId = 16637,
                    Name = "Give Us Clean Hands",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2015, 08, 08)
                },
                new Song()
                {
                    SongId = 22035,
                    Name = "Glorious Day",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2015, 04, 04)
                },
                new Song()
                {
                    SongId = 48494,
                    Name = "Go Tell It On The Mountain",
                    PlayCount = 5,
                    LastPlayed = new DateTime(2015, 12, 26)
                },
                new Song()
                {
                    SongId = 31378,
                    Name = "God Is Able",
                    PlayCount = 2,
                    LastPlayed = new DateTime(2014, 10, 19)
                },
                new Song()
                {
                    SongId = 6764,
                    Name = "God Of This City",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2014, 05, 04)
                },
                new Song()
                {
                    SongId = 6752,
                    Name = "God Of Wonders",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2014, 11, 16)
                },
                new Song()
                {
                    SongId = 10203,
                    Name = "God Rest Ye Merry Gentlemen",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2015, 12, 26)
                },
                new Song()
                {
                    SongId = 62323,
                    Name = "Good Good Father",
                    PlayCount = 4,
                    LastPlayed = new DateTime(2015, 11, 28)
                },
                new Song()
                {
                    SongId = 22166,
                    Name = "Grace Like Rain",
                    PlayCount = 11,
                    LastPlayed = new DateTime(2015, 10, 17)
                },
                new Song()
                {
                    SongId = 44445,
                    Name = "Great Are You Lord",
                    PlayCount = 3,
                    LastPlayed = new DateTime(2015, 11, 08)
                },
                new Song()
                {
                    SongId = 2804,
                    Name = "Hallelujah (Your Love Is Amazing)",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2014, 02, 16)
                },
                new Song()
                {
                    SongId = 46424,
                    Name = "Hallelujah, What a Savior",
                    PlayCount = 7,
                    LastPlayed = new DateTime(2015, 11, 28)
                },
                new Song() {SongId = 22183, Name = "Happy Day", PlayCount = 3, LastPlayed = new DateTime(2015, 06, 14)},
                new Song() {SongId = 2619, Name = "Happy Day", PlayCount = 3, LastPlayed = new DateTime(2015, 02, 28)},
                new Song()
                {
                    SongId = 41383,
                    Name = "Hark The Herald Angels Sing",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2014, 12, 14)
                },
                new Song()
                {
                    SongId = 8433,
                    Name = "Heart For The Nations",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2014, 05, 04)
                },
                new Song() {SongId = 31217, Name = "Holy", PlayCount = 2, LastPlayed = new DateTime(2014, 02, 09)},
                new Song()
                {
                    SongId = 1468,
                    Name = "Holy Is The Lord",
                    PlayCount = 5,
                    LastPlayed = new DateTime(2015, 08, 16)
                },
                new Song()
                {
                    SongId = 43855,
                    Name = "Holy Spirit",
                    PlayCount = 2,
                    LastPlayed = new DateTime(2015, 09, 13)
                },
                new Song()
                {
                    SongId = 35304,
                    Name = "Holy Spirit",
                    PlayCount = 2,
                    LastPlayed = new DateTime(2015, 09, 27)
                },
                new Song() {SongId = 137, Name = "Hosanna", PlayCount = 2, LastPlayed = new DateTime(2015, 08, 22)},
                new Song()
                {
                    SongId = 56249,
                    Name = "How Can It Be",
                    PlayCount = 11,
                    LastPlayed = new DateTime(2015, 10, 31)
                },
                new Song()
                {
                    SongId = 1469,
                    Name = "How Deep The Father's Love For Us",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2014, 04, 06)
                },
                new Song()
                {
                    SongId = 7520,
                    Name = "How Great Are You, Lord",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2014, 07, 12)
                },
                new Song()
                {
                    SongId = 17655,
                    Name = "How Great Is Our God",
                    PlayCount = 9,
                    LastPlayed = new DateTime(2015, 07, 05)
                },
                new Song()
                {
                    SongId = 17480,
                    Name = "How He Loves",
                    PlayCount = 2,
                    LastPlayed = new DateTime(2015, 02, 22)
                },
                new Song()
                {
                    SongId = 20643,
                    Name = "How He Loves",
                    PlayCount = 2,
                    LastPlayed = new DateTime(2016, 01, 02)
                },
                new Song() {SongId = 395, Name = "Hungry", PlayCount = 1, LastPlayed = new DateTime(2014, 02, 02)},
                new Song() {SongId = 7696, Name = "I Am Free", PlayCount = 7, LastPlayed = new DateTime(2015, 08, 22)},
                new Song()
                {
                    SongId = 6673,
                    Name = "I Can Only Imagine",
                    PlayCount = 4,
                    LastPlayed = new DateTime(2014, 11, 08)
                },
                new Song()
                {
                    SongId = 834,
                    Name = "I Could Sing Of Your Love Forever",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2015, 02, 08)
                },
                new Song()
                {
                    SongId = 11089,
                    Name = "I Extol You",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2014, 02, 16)
                },
                new Song()
                {
                    SongId = 7066,
                    Name = "I Give You My Heart",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2014, 05, 18)
                },
                new Song()
                {
                    SongId = 448,
                    Name = "I Love Your Presence",
                    PlayCount = 5,
                    LastPlayed = new DateTime(2015, 06, 14)
                },
                new Song()
                {
                    SongId = 25823,
                    Name = "I Will Follow",
                    PlayCount = 5,
                    LastPlayed = new DateTime(2015, 07, 25)
                },
                new Song()
                {
                    SongId = 10786,
                    Name = "I Will Rise",
                    PlayCount = 7,
                    LastPlayed = new DateTime(2015, 08, 22)
                },
                new Song()
                {
                    SongId = 2091,
                    Name = "If We Are The Body",
                    PlayCount = 4,
                    LastPlayed = new DateTime(2015, 10, 17)
                },
                new Song()
                {
                    SongId = 18129,
                    Name = "In Christ Alone",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2015, 03, 31)
                },
                new Song()
                {
                    SongId = 1794,
                    Name = "Indescribable",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2014, 11, 16)
                },
                new Song()
                {
                    SongId = 6329,
                    Name = "It Is Well With My Soul",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2015, 02, 08)
                },
                new Song()
                {
                    SongId = 6071,
                    Name = "Jesus Lover Of My Soul",
                    PlayCount = 3,
                    LastPlayed = new DateTime(2014, 01, 26)
                },
                new Song()
                {
                    SongId = 54252,
                    Name = "Jesus Loves Me",
                    PlayCount = 5,
                    LastPlayed = new DateTime(2015, 10, 31)
                },
                new Song()
                {
                    SongId = 10872,
                    Name = "Jesus Messiah",
                    PlayCount = 2,
                    LastPlayed = new DateTime(2015, 03, 31)
                },
                new Song()
                {
                    SongId = 2600,
                    Name = "Jesus Paid It All",
                    PlayCount = 3,
                    LastPlayed = new DateTime(2015, 03, 21)
                },
                new Song()
                {
                    SongId = 41844,
                    Name = "Jesus Son Of God",
                    PlayCount = 4,
                    LastPlayed = new DateTime(2014, 08, 24)
                },
                new Song()
                {
                    SongId = 1718,
                    Name = "Jesus You Are Worthy",
                    PlayCount = 6,
                    LastPlayed = new DateTime(2015, 08, 08)
                },
                new Song()
                {
                    SongId = 10870,
                    Name = "Joy to the World",
                    PlayCount = 4,
                    LastPlayed = new DateTime(2015, 12, 20)
                },
                new Song()
                {
                    SongId = 36805,
                    Name = "Lay Me Down",
                    PlayCount = 13,
                    LastPlayed = new DateTime(2015, 10, 03)
                },
                new Song()
                {
                    SongId = 5324,
                    Name = "Let Your Kingdom Come",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2015, 02, 15)
                },
                new Song()
                {
                    SongId = 28,
                    Name = "Light The Fire Again",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2014, 05, 04)
                },
                new Song()
                {
                    SongId = 11192,
                    Name = "Live Out Loud",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2014, 05, 04)
                },
                new Song()
                {
                    SongId = 6776,
                    Name = "Lord I Lift Your Name On High",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2015, 01, 31)
                },
                new Song()
                {
                    SongId = 29090,
                    Name = "Lord I Need You",
                    PlayCount = 13,
                    LastPlayed = new DateTime(2015, 10, 11)
                },
                new Song()
                {
                    SongId = 3719,
                    Name = "Love The Lord",
                    PlayCount = 5,
                    LastPlayed = new DateTime(2015, 09, 13)
                },
                new Song()
                {
                    SongId = 1759,
                    Name = "Made To Worship",
                    PlayCount = 10,
                    LastPlayed = new DateTime(2016, 01, 09)
                },
                new Song() {SongId = 29, Name = "Majesty", PlayCount = 1, LastPlayed = new DateTime(2014, 07, 12)},
                new Song()
                {
                    SongId = 3321,
                    Name = "Mighty To Save",
                    PlayCount = 6,
                    LastPlayed = new DateTime(2015, 04, 19)
                },
                new Song()
                {
                    SongId = 25441,
                    Name = "More Than Amazing",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2014, 02, 02)
                },
                new Song()
                {
                    SongId = 3535,
                    Name = "My Savior My God",
                    PlayCount = 3,
                    LastPlayed = new DateTime(2015, 11, 28)
                },
                new Song()
                {
                    SongId = 3604,
                    Name = "No Sweeter Name",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2014, 02, 02)
                },
                new Song()
                {
                    SongId = 3621,
                    Name = "Nothing But The Blood",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2014, 06, 07)
                },
                new Song()
                {
                    SongId = 3050,
                    Name = "O Come All Ye Faithful",
                    PlayCount = 5,
                    LastPlayed = new DateTime(2015, 12, 20)
                },
                new Song()
                {
                    SongId = 1557,
                    Name = "O Praise Him",
                    PlayCount = 8,
                    LastPlayed = new DateTime(2015, 06, 27)
                },
                new Song() {SongId = 43442, Name = "Oceans", PlayCount = 15, LastPlayed = new DateTime(2015, 10, 03)},
                new Song() {SongId = 6128, Name = "Offering", PlayCount = 1, LastPlayed = new DateTime(2015, 11, 22)},
                new Song()
                {
                    SongId = 17900,
                    Name = "Offering (Christmas)",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2014, 12, 14)
                },
                new Song()
                {
                    SongId = 12837,
                    Name = "On Bended Knee",
                    PlayCount = 2,
                    LastPlayed = new DateTime(2016, 01, 02)
                },
                new Song()
                {
                    SongId = 13220,
                    Name = "On The Third Day",
                    PlayCount = 3,
                    LastPlayed = new DateTime(2015, 04, 04)
                },
                new Song()
                {
                    SongId = 2564,
                    Name = "One Pure And Holy Passion",
                    PlayCount = 2,
                    LastPlayed = new DateTime(2015, 11, 08)
                },
                new Song()
                {
                    SongId = 27496,
                    Name = "One Thing Remains",
                    PlayCount = 14,
                    LastPlayed = new DateTime(2015, 10, 25)
                },
                new Song() {SongId = 20858, Name = "Our God", PlayCount = 7, LastPlayed = new DateTime(2015, 10, 11)},
                new Song() {SongId = 24618, Name = "Overcome", PlayCount = 3, LastPlayed = new DateTime(2015, 08, 02)},
                new Song() {SongId = 43904, Name = "Redeemed", PlayCount = 1, LastPlayed = new DateTime(2014, 04, 12)},
                new Song()
                {
                    SongId = 3606,
                    Name = "Revelation Song",
                    PlayCount = 14,
                    LastPlayed = new DateTime(2015, 07, 25)
                },
                new Song()
                {
                    SongId = 22167,
                    Name = "Romans 12:1",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2014, 05, 10)
                },
                new Song()
                {
                    SongId = 8277,
                    Name = "Salt And Light",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2015, 02, 22)
                },
                new Song()
                {
                    SongId = 33,
                    Name = "Shout To the Lord",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2015, 05, 02)
                },
                new Song()
                {
                    SongId = 8140,
                    Name = "Shout To The North",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2015, 02, 15)
                },
                new Song()
                {
                    SongId = 33353,
                    Name = "Silent Night",
                    PlayCount = 3,
                    LastPlayed = new DateTime(2015, 12, 26)
                },
                new Song() {SongId = 63441, Name = "Simplicity", PlayCount = 1, LastPlayed = new DateTime(2015, 10, 11)},
                new Song() {SongId = 1796, Name = "Son Of God", PlayCount = 1, LastPlayed = new DateTime(2014, 06, 15)},
                new Song()
                {
                    SongId = 66,
                    Name = "Sweetly Broken",
                    PlayCount = 4,
                    LastPlayed = new DateTime(2016, 01, 09)
                },
                new Song()
                {
                    SongId = 1690,
                    Name = "Take The World But Give Me Jesus",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2014, 03, 01)
                },
                new Song()
                {
                    SongId = 17322,
                    Name = "The Father's Love",
                    PlayCount = 4,
                    LastPlayed = new DateTime(2015, 04, 19)
                },
                new Song()
                {
                    SongId = 1556,
                    Name = "The Heart Of Worship",
                    PlayCount = 3,
                    LastPlayed = new DateTime(2015, 08, 08)
                },
                new Song()
                {
                    SongId = 3639,
                    Name = "The More I Seek You",
                    PlayCount = 9,
                    LastPlayed = new DateTime(2015, 10, 25)
                },
                new Song()
                {
                    SongId = 52689,
                    Name = "The Servant Song",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2014, 06, 29)
                },
                new Song()
                {
                    SongId = 1106,
                    Name = "There Is Power in the Blood",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2015, 02, 28)
                },
                new Song()
                {
                    SongId = 40235,
                    Name = "This Is Amazing Grace",
                    PlayCount = 14,
                    LastPlayed = new DateTime(2015, 11, 28)
                },
                new Song() {SongId = 32219, Name = "Tree", PlayCount = 5, LastPlayed = new DateTime(2015, 07, 18)},
                new Song()
                {
                    SongId = 59749,
                    Name = "Trust In You",
                    PlayCount = 4,
                    LastPlayed = new DateTime(2016, 01, 09)
                },
                new Song()
                {
                    SongId = 22186,
                    Name = "Wait For Your Rain",
                    PlayCount = 3,
                    LastPlayed = new DateTime(2014, 02, 15)
                },
                new Song() {SongId = 52296, Name = "We Believe", PlayCount = 9, LastPlayed = new DateTime(2015, 03, 21)},
                new Song() {SongId = 54039, Name = "We Believe", PlayCount = 1, LastPlayed = new DateTime(2015, 02, 07)},
                new Song() {SongId = 24649, Name = "We Cry Out", PlayCount = 2, LastPlayed = new DateTime(2015, 02, 15)},
                new Song()
                {
                    SongId = 1710,
                    Name = "We Fall Down",
                    PlayCount = 8,
                    LastPlayed = new DateTime(2015, 09, 19)
                },
                new Song()
                {
                    SongId = 1837,
                    Name = "We Want To See Jesus Lifted High",
                    PlayCount = 7,
                    LastPlayed = new DateTime(2016, 01, 02)
                },
                new Song()
                {
                    SongId = 3752,
                    Name = "What A Friend We Have In Jesus",
                    PlayCount = 2,
                    LastPlayed = new DateTime(2014, 11, 02)
                },
                new Song()
                {
                    SongId = 40912,
                    Name = "Whom Shall I Fear",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2014, 07, 27)
                },
                new Song()
                {
                    SongId = 13471,
                    Name = "Wonderful Maker",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2015, 05, 17)
                },
                new Song()
                {
                    SongId = 12360,
                    Name = "Worthy Is The Lamb",
                    PlayCount = 3,
                    LastPlayed = new DateTime(2015, 11, 22)
                },
                new Song()
                {
                    SongId = 36,
                    Name = "You Are My King",
                    PlayCount = 3,
                    LastPlayed = new DateTime(2015, 04, 19)
                },
                new Song()
                {
                    SongId = 2671,
                    Name = "You Are So Good To Me",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2015, 11, 08)
                },
                new Song()
                {
                    SongId = 51846,
                    Name = "You Make Me Brave",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2015, 07, 18)
                },
                new Song()
                {
                    SongId = 3601,
                    Name = "You, You Are God",
                    PlayCount = 8,
                    LastPlayed = new DateTime(2015, 09, 13)
                },
                new Song()
                {
                    SongId = 1866,
                    Name = "Your Grace Is Enough",
                    PlayCount = 15,
                    LastPlayed = new DateTime(2016, 01, 02)
                },
                new Song()
                {
                    SongId = 17759,
                    Name = "Your Love Never Fails",
                    PlayCount = 3,
                    LastPlayed = new DateTime(2015, 08, 30)
                },
                new Song() {SongId = 72, Name = "Your Name", PlayCount = 3, LastPlayed = new DateTime(2014, 09, 21)},
                new Song()
                {
                    SongId = 47308,
                    Name = "Your Name (Christmas Version)",
                    PlayCount = 1,
                    LastPlayed = new DateTime(2014, 12, 14)
                }
            };

            return songs;
        }

    }
    public class WorkItemController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }

    }
}