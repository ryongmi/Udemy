using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments14
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Clubs> ronaldoClubs = new List<Clubs>();
            ronaldoClubs.Add(Clubs.ManchesterUnited);
            ronaldoClubs.Add(Clubs.RealMadrid);

            List<Clubs> rooneyClubs = new List<Clubs>();
            rooneyClubs.Add(Clubs.Everton);
            rooneyClubs.Add(Clubs.ManchesterUnited);

            var listofPlayers = new List<(int playerNo, string playerName, int playerGoals, List<Clubs> clubs, Countries country)>();

            listofPlayers.Add((7, "Ronaldo", 55, ronaldoClubs, Countries.Portugal));
            listofPlayers.Add((10, "Rooney", 35, rooneyClubs, Countries.UnitedKingdom));

            foreach (var player in listofPlayers)
            {
                Console.Write($"\n" +
                    $"Player no : {player.playerNo} \nPlayer name : {player.playerName} " +
                    $"\nPlayer goals : {player.playerGoals} \nCountry : {player.country} \nClubs : ");

                foreach (var club in player.clubs)
                {
                    Console.Write(club + "  ");
                }
                Console.WriteLine("\n___________________________");
            }
        }
    }

    enum Clubs
    {
        RealMadrid,
        Barcelona,
        ManchesterUnited,
        Chelsea,
        Arsenal,
        NewcastleUnited,
        Everton,
        Schalke,
        InterMilan,
        ASRoma,
        TottenhamHotspur,
        AtleticoMadrid,
        BorussiaDortmund,
        ManchesterCity,
        Juventus,
        ParisSaintGermain,
        ACMilan,
        Liverpool,
        BayernMunich

    }

    enum Countries
    {
        Afghanistan,
        Albania,
        Algeria,
        Angola,
        Argentina,
        Australia,
        Austria,
        Bahamas,
        Bahrain,
        Bangladesh,
        Belarus,
        Belgium,
        Bolivia,
        Botswana,
        Brazil,
        Brunei,
        Bulgaria,
        BurkinaFaso,
        Burundi,
        Cambodia,
        Cameroon,
        Canada,
        Chad,
        Chile,
        China,
        Colombia,
        Comoros,
        CostaRica,
        Croatia,
        Cuba,
        Cyprus,
        CzechRepublic,
        Denmark,
        Ecuador,
        Egypt,
        ElSalvador,
        Estonia,
        Ethiopia,
        Finland,
        France,
        Gabon,
        Gambia,
        Georgia,
        Germany,
        Ghana,
        Greece,
        Greenland,
        Guatemala,
        Haiti,
        Honduras,
        HongKong,
        Hungary,
        Iceland,
        India,
        Indonesia,
        Iran,
        Iraq,
        Ireland,
        Israel,
        Italy,
        Jamaica,
        Japan,
        Jordan,
        Kazakhstan,
        Kenya,
        Kosovo,
        Kuwait,
        Latvia,
        Lebanon,
        Liberia,
        Libya,
        Liechtenstein,
        Lithuania,
        Luxembourg,
        Macedonia,
        Madagascar,
        Malawi,
        Malaysia,
        Maldives,
        Mali,
        Malta,
        Mauritius,
        Mexico,
        Moldova,
        Monaco,
        Mongolia,
        Montenegro,
        Morocco,
        Mozambique,
        Namibia,
        Nepal,
        Netherlands,
        NewZealand,
        Nicaragua,
        Niger,
        Nigeria,
        NorthKorea,
        Norway,
        Oman,
        Pakistan,
        Palestine,
        Panama,
        Paraguay,
        Peru,
        Philippines,
        Poland,
        Portugal,
        PuertoRico,
        Qatar,
        Romania,
        Russia,
        Rwanda,
        SaudiArabia,
        Senegal,
        Serbia,
        Seychelles,
        SierraLeone,
        Singapore,
        Slovakia,
        Slovenia,
        Somalia,
        SouthAfrica,
        SouthKorea,
        SouthSudan,
        Spain,
        SriLanka,
        Sudan,
        Swaziland,
        Sweden,
        Switzerland,
        Syria,
        Taiwan,
        Tanzania,
        Thailand,
        Togo,
        Tonga,
        Tunisia,
        Turkey,
        Uganda,
        Ukraine,
        UnitedArabEmirates,
        UnitedKingdom,
        UnitedStatesofAmerica,
        Uruguay,
        Uzbekistan,
        VaticanCity,
        Venezuela,
        Vietnam,
        Yemen,
        Zambia,
        Zimbabwe
    }
}
