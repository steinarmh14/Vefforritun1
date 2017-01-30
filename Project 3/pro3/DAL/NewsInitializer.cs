using pro3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pro3.DAL
{
    public class NewsInitializer : System.Data.Entity.DropCreateDatabaseAlways<NewsContext>
    {
        protected override void Seed(NewsContext context)
        {

            var news = new List<NewsItem>
            {
                new NewsItem
                {
                    Title = "Lögmaður tveggja ein­stak­linga vill lög­bann á um­fjöll­un Kast­ljóss í kvöld",
                    Text = "„Við telj­um að fjöl­miðlalög heim­ili svona hluti þegar al­manna­hags­mun­ir krefj­ist og við telj­um að þarna eigi al­manna­hags­mun­ir við. Við telj­um mjög brýnt að al­menn­ing­ur viti af því hvernig svona sölu­starf­semi fer fram,“ seg­ir Sig­mar Guðmunds­son, rit­stjóri Kast­ljóss, í sam­tali við mbl.is.",
                    Category ="Politics",
                    DateCreated = DateTime.Parse("2014-02-20 14:30:31") 
                },
                                new NewsItem
                {
                    Title = "Sér­sveit­in yf­ir­bugaði kon­una",
                    Text = "Sér­sveit rík­is­lög­reglu­stjóra var kölluð út fyr­ir há­degið í dag til að aðstoða lög­regl­una á Sel­fossi. Sam­kvæmt heim­ild­um mbl.is eru lög­regluaðgerðir í gangi við fjöl­býl­is­hús á Sel­fossi. Lög­regl­an verst allra frétta af aðgerðinni en staðfesti við mbl.is að sér­sveit­in væri í bæn­um.",
                    Category ="News",
                    DateCreated = DateTime.Parse("2014-02-20 14:30:32") 
                },
                                new NewsItem
                {
                    Title = "„Popp og kók“ aðeins í tveim­ur bíó­um",
                    Text = "Hin gamla teng­ing „popp og kók“ í bíó­menn­ing­unni gild­ir nú aðeins í tveim­ur kvik­mynda­hús­um í Reykja­vík. Annað þeirra er Laug­ar­ás­bíó og þar á bæ hafa menn gripið tæki­færið og aug­lýst þessa sér­stöðu. Rætt er við fram­kvæmda­stjóra bíós­ins og sýn­ing­ar­stjóra í greina­flokkn­um Heim­sókn á höfuðborg­ar­svæðið í blaðinu í dag. Í um­fjöll­un um Laug­ar­dal og ná­grenni er enn­frem­ur sagt frá fyr­ir­huguðum fram­kvæmd­um á Kirkju­sandi og í Skeif­unni og fjallað um aðsókn að Laug­ar­dals­laug.",
                    Category ="News",
                    DateCreated = DateTime.Parse("2014-02-20 14:30:33") 
                },
                                new NewsItem
                {
                    Title = "Persie ekk­ert að koma til",
                    Text = "Robin van Persie fram­herji Manchester United miss­ir af leik liðsins gegn Newcastle á morg­un en óvíst er hvenær hann snýr aft­ur á knatt­spyrnu­völl­inn þar sem Hol­lend­ing­ur­inn glím­ir við meiðsli á ökkla.",
                    Category ="Sports",
                    DateCreated = DateTime.Parse("2014-02-20 14:30:34") 
                },
                                new NewsItem
                {
                    Title = "Veit ekki hvenær di María mun aðlag­ast",
                    Text = "Lou­is van Gaal knatt­spyrn­u­stjóri Manchester United seg­ir Arg­entínu­mann­inn hjá fé­lag­inu, Ángel di María, þurfa meiri tíma til að aðlag­ast líf­inu á Englandi en kapp­inn hef­ur spilað veru­lega und­ir getu í und­an­förn­um leikj­um og var tek­inn af velli í hálfleik í sig­ur­leikn­um gegn Sund­erland um síðustu helgi.",
                    Category ="Sports",
                    DateCreated = DateTime.Parse("2014-02-20 14:30:35") 
                },
                                new NewsItem
                {
                    Title = "Kara­batic á för­um til PSG?",
                    Text = "Frakk­inn Ni­kola Kara­batic, sem í síðustu viku var út­nefnd­ur besti hand­knatt­leiksmaður heims, verður að öll­um lík­ind­um liðsfé­lagi Ró­berts Gunn­ars­son­ar hjá Par­is Saint Germain á næstu leiktíð ef marka má frétt TV 2 í Dan­mörku.",
                    Category ="Sports",
                    DateCreated = DateTime.Parse("2014-02-20 14:30:36") 
                },
                                new NewsItem
                {
                    Title = "Þarf ekki að vinna einn titil á ári",
                    Text = "Manu­el Pell­egrini knatt­spyrn­u­stjóri Manchester City þver­tók fyr­ir þær sögu­sagn­ir sem heyra mátti í ensk­um fjöl­miðlum í dag að hann myndi missa starf sitt ynni hann ekki að minnsta kosti einn bik­ar á leiktíðinni.",
                    Category ="Sports",
                    DateCreated = DateTime.Parse("2014-02-20 14:30:37") 
                },
                                new NewsItem
                {
                    Title = "36 stig eru í pott­in­um og við þurf­um 31",
                    Text = "José Mour­in­ho knatt­spyrn­u­stjóri Chel­sea var ómyrk­ur í máli á blaðamanna­fundi í dag þegar hann talaði um titil­mögu­leika síns liðs en Chel­sea spil­ar við West Ham á morg­un.",
                    Category ="Sports",
                    DateCreated = DateTime.Parse("2014-02-20 14:30:38") 
                },
                                new NewsItem
                {
                    Title = "Við getum náð City",
                    Text = "Arsé­ne Wenger knatt­spyrn­u­stjóri Arsenal seg­ir bar­átt­una um fjórða sætið vera gríðarlega harða en seg­ir lið sitt jafn­framt vel geta náð Mancheser City að stig­um en liðið er fjór­um stig­um á eft­ir City sem er í 2. sæt­inu. ",
                    Category ="Sports",
                    DateCreated = DateTime.Parse("2014-02-20 14:30:39") 
                },
                                new NewsItem
                {
                    Title = "Barna­barnið orðið stjórn­ar­formaður Wig­an",
                    Text = "Dave Whel­an hef­ur stigið úr stóli stjórn­ar­for­manns enska knatt­spyrnuliðsins Wig­an en hann sæk­ir arf­taka sinn ekki langt þar sem barna­barn Whel­ans, Dav­id Sharpe, tek­ur við en sá er aðeins 23 ára gam­all.",
                    Category ="Sports",
                    DateCreated = DateTime.Parse("2014-02-20 14:30:40") 
                }

            };

            news.ForEach(s => context.News.Add(s));
            context.SaveChanges();
        
        }
    }
}