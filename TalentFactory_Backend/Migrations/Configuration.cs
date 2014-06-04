namespace TalentFactory_Backend.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TalentFactory_Backend.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TalentFactory_Backend.DataAccess.Context.TFContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TalentFactory_Backend.DataAccess.Context.TFContext context)
        {
            /*
         * Award        OK
         * Contact      OK
         * Flickralbum
         * HallOfFame   OK
         * Home         OK
         * Jurykeuze
         * Jurylid      OK
         * NieuwsItem   OK
         * Nominaties
         * Page
         * Richting     OK
         * Setup        OK
         * Sponsor      OK
         * Sponsortype  OK
         * Twitterfeed  OK
         */



            //de setup
            context.Setup.AddOrUpdate(new Setup()
            {
                Jaar = 2014,
                EventDateTime = new DateTime(2014, 6, 25, 20, 00, 00),
                EventBride = "http://www.eventbrite.com/e/tickets-talent-factory-2014-25-juni-2014-11001719439?aff=es2&rank=0",
                AccentKleur = "#FBAD26",
                Logo = "http://www.talent-factory.eu/2014/sites/all/themes/multimania/logo.png",
                Twitter = "https://twitter.com/TFkortrijk",
                Facebook = "https://www.facebook.com/TFKortrijk",
                Flickr = "https://www.flickr.com/photos/clokortrijk/sets/72157633431327735/",
                GooglePlus = "https://plus.google.com/"

            });
            context.SaveChanges();


            //Sponsortype
            context.SponsorType.AddOrUpdate(new SponsorType() { Naam = "Gold" });
            context.SponsorType.AddOrUpdate(new SponsorType() { Naam = "Silver" });
            context.SponsorType.AddOrUpdate(new SponsorType() { Naam = "Bronze" });
            context.SponsorType.AddOrUpdate(new SponsorType() { Naam = "Gewoon" });

            context.SaveChanges();



            //nieuwsitems
            context.NieuwsItem.AddOrUpdate(new NieuwsItem()
            {
                Titel = "Talent Factory 2014 is aangekondigd",
                TimeOfRelease = new DateTime(2014, 4, 15, 16, 46, 29),
                Foto = "http://static.nationalgeographic.nl/pictures/genjUserPhotoPicture/original/97/88/11/tandwielen-118897.jpg",
                Inleiding = "Bacon ipsum dolor sit amet tail ham hock strip steak prosciutto venison capicola pastrami cow porchetta. Pancetta hamburger ground round prosciutto pork loin. Sirloin porchetta ham, meatball shank turkey ball tip rump turducken. Cow boudin swine sausage pork loin ball tip ground round pancetta venison pork tongue brisket biltong tenderloin porchetta.",
                Artikel = "Swine cow fatback, t-bone leberkas filet mignon prosciutto. Spare ribs doner landjaeger flank frankfurter tenderloin. Tenderloin bacon flank sirloin, pig ribeye swine jerky meatball. Pork loin sausage chuck jowl, biltong ham rump tenderloin kielbasa short ribs corned beef. Strip steak biltong venison leberkas jowl, salami hamburger.<br><br>Cow jowl short loin flank bresaola tri-tip chicken frankfurter pork. Beef ribs chuck chicken fatback. Drumstick meatball pastrami, beef ribs ball tip doner tri-tip beef ground round short loin. Kevin meatloaf turducken biltong kielbasa shank ball tip, filet mignon flank tongue turkey beef leberkas sirloin landjaeger. Filet mignon corned beef andouille pork kielbasa. Venison leberkas tenderloin ham ham hock, shank turducken prosciutto bresaola andouille rump porchetta. Strip steak jerky cow, shank short loin shankle beef ribs."
            });
            context.NieuwsItem.AddOrUpdate(new NieuwsItem()
            {
                Titel = "Schrijf je nu in",
                TimeOfRelease = new DateTime(2014, 4, 20, 11, 13, 40),
                Foto = "https://farm9.staticflickr.com/8164/7489056920_498947cec1.jpg",
                Inleiding = "Pancetta corned beef cow, boudin bacon jowl kevin tongue ribeye t-bone tenderloin pastrami shankle. Filet mignon beef meatloaf, corned beef leberkas jowl drumstick strip steak short loin tail pork loin andouille turducken. Salami shank leberkas cow jowl drumstick rump frankfurter capicola biltong tenderloin. Turducken andouille spare ribs strip steak, bacon rump capicola tail tongue meatball fatback pastrami cow biltong. Drumstick sausage porchetta, cow kielbasa filet mignon landjaeger boudin capicola prosciutto.",
                Artikel = "Short loin drumstick pork chop, tail meatball jerky turducken. Salami beef ribs pancetta boudin porchetta fatback rump pig pork belly kielbasa shoulder chuck turducken. Swine jerky pork chop pastrami beef, drumstick turducken. Shankle tenderloin pastrami, sausage pork strip steak t-bone. Kevin pork ribeye pork belly, pork chop turkey ham salami pancetta short ribs filet mignon andouille ball tip boudin. Pancetta prosciutto swine ball tip, andouille kielbasa tail beef ribs. Spare ribs turducken ground round, kielbasa rump prosciutto boudin andouille pork belly short ribs biltong.<br><br>Chuck pork loin strip steak, ground round tongue drumstick kielbasa salami beef ribs. Capicola kielbasa ground round meatball ball tip landjaeger prosciutto jowl. Bresaola sirloin leberkas pork meatball sausage biltong swine andouille meatloaf. Pancetta bresaola landjaeger jerky ribeye bacon beef tenderloin shoulder prosciutto tail short loin capicola turducken shank. Corned beef sausage pancetta turducken bresaola, tri-tip shankle shoulder frankfurter pork ham hock prosciutto. Pig ribeye pork chop, turducken biltong andouille flank hamburger filet mignon.<br><br>Shankle ground round flank pork belly pork chop tongue ham hock salami landjaeger andouille sirloin. Sirloin shoulder bacon strip steak bresaola beef. Chuck shank chicken brisket kevin meatball prosciutto shoulder jowl boudin capicola fatback short ribs. Swine porchetta pork chop short ribs, pig salami pork belly tri-tip brisket."
            });
            context.NieuwsItem.AddOrUpdate(new NieuwsItem()
            {
                Titel = "Al 25 genomineerden",
                TimeOfRelease = new DateTime(2014, 5, 2, 14, 30, 38),
                Foto = "https://farm9.staticflickr.com/8012/7488846758_724233c27d.jpg",
                Inleiding = "Veggies es bonus vobis, proinde vos postulo essum magis kohlrabi welsh onion daikon amaranth tatsoi tomatillo melon azuki bean garlic.",
                Artikel = "Gumbo beet greens corn soko endive gumbo gourd. Parsley shallot courgette tatsoi pea sprouts fava bean collard greens dandelion okra wakame tomato. Dandelion cucumber earthnut pea peanut soko zucchini.<br><br>Turnip greens yarrow ricebean rutabaga endive cauliflower sea lettuce kohlrabi amaranth water spinach avocado daikon napa cabbage asparagus winter purslane kale. Celery potato scallion desert raisin horseradish spinach carrot soko. Lotus root water spinach fennel kombu maize bamboo shoot green bean swiss chard seakale pumpkin onion chickpea gram corn pea. Brussels sprout coriander water chestnut gourd swiss chard wakame kohlrabi beetroot carrot watercress. Corn amaranth salsify bunya nuts nori azuki bean chickweed potato bell pepper artichoke."
            });
            context.NieuwsItem.AddOrUpdate(new NieuwsItem()
            {
                Titel = "Locatie is bekend",
                TimeOfRelease = new DateTime(2014, 5, 4, 12, 42, 59),
                Foto = "https://farm8.staticflickr.com/7261/7488826620_3cb268da58.jpg",
                Inleiding = "Nori grape silver beet broccoli kombu beet greens fava bean potato quandong celery. Bunya nuts black-eyed pea prairie turnip leek lentil turnip greens parsnip. Sea lettuce lettuce water chestnut eggplant winter purslane fennel azuki bean earthnut pea sierra leone bologi leek soko chicory celtuce parsley jÃ­cama salsify.",
                Artikel = "Pea horseradish azuki bean lettuce avocado asparagus okra. Kohlrabi radish okra azuki bean corn fava bean mustard tigernut jÃ­cama green bean celtuce collard greens avocado quandong fennel gumbo black-eyed pea. Grape silver beet watercress potato tigernut corn groundnut. Chickweed okra pea winter purslane coriander yarrow sweet pepper radish garlic brussels sprout groundnut summer purslane earthnut pea tomato spring onion azuki bean gourd. Gumbo kakadu plum komatsuna black-eyed pea green bean zucchini gourd winter purslane silver beet rock melon radish asparagus spinach."
            });
            context.NieuwsItem.AddOrUpdate(new NieuwsItem()
            {
                Titel = "Nog 1maand om te nomineren",
                TimeOfRelease = new DateTime(2014, 5, 20, 09, 32, 22),
                Foto = "https://farm8.staticflickr.com/7258/7488791762_4e9bcc175a.jpg",
                Inleiding = "Ugh Pitchfork sriracha polaroid. Freegan farm-to-table fanny pack, fixie umami Wes Anderson tote bag. PBR&B vinyl bitters, viral small batch sriracha yr meh you probably haven't heard of them distillery. Leggings kitsch fanny pack Brooklyn quinoa dreamcatcher, pop-up kale chips XOXO distillery American Apparel Helvetica. Leggings dreamcatcher literally, photo booth small batch drinking vinegar twee pop-up. Post-ironic before they sold out typewriter VHS artisan craft beer. IPhone semiotics church-key umami, fingerstache artisan vinyl master cleanse Pinterest cray gluten-free.",
                Artikel = "Street art ethical squid literally. Ethical food truck Austin pug readymade organic fanny pack, stumptown farm-to-table Tumblr. Pop-up American Apparel irony Tonx. Authentic typewriter butcher fap Shoreditch. Bicycle rights flannel post-ironic, Tumblr American Apparel try-hard typewriter fashion axe occupy slow-carb banh mi plaid. Skateboard cray salvia Pinterest organic Neutra Blue Bottle. PBR&B Odd Future normcore meh, Godard next level Neutra small batch pork belly.<br><br>Wayfarers forage vegan Thundercats, fanny pack irony XOXO butcher lo-fi. 3 wolf moon messenger bag tofu wolf synth, biodiesel Vice pork belly. Bicycle rights VHS Cosby sweater kitsch +1 Helvetica, tousled before they sold out farm-to-table scenester roof party. Pitchfork flexitarian scenester Kickstarter. Artisan fanny pack single-origin coffee, fingerstache keytar food truck ethnic small batch photo booth leggings. Kale chips tattooed Cosby sweater ethical umami. Tote bag Truffaut Echo Park lo-fi Williamsburg."
            });
            context.NieuwsItem.AddOrUpdate(new NieuwsItem()
            {
                Titel = "Het is bijna zover",
                TimeOfRelease = new DateTime(2014, 6, 23, 15, 34, 28),
                Foto = "https://farm9.staticflickr.com/8164/7487994296_81cff014cd.jpg",
                Inleiding = "Lorem ipsizzle dolor izzle phat, consectetuer adipiscing elit. Nullam dizzle velizzle, boofron volutpizzle, gizzle quizzle, rizzle vizzle, stuff. Pellentesque i saw beyonces tizzles and my pizzle went crizzle tortor. Sed erizzle. Gangster at dolor boofron turpis tempus izzle. Maurizzle pellentesque nibh izzle turpizzle. Sure izzle tortor. Fizzle fo shizzle rhoncizzle fo shizzle. In mofo ghetto platea dictumst. dapibizzle. Curabitizzle tellus black, away crazy, mattizzle fizzle, eleifend vitae, nunc. Shiz suscipizzle. Integizzle check it out velizzle funky fresh check out this.",
                Artikel = "Praesent nec turpis yo leo nizzle molestie. Vivamizzle yippiyo tortor my shizz uhuh ... yih!. malesuada ornare magna. Cool check out this, sheezy crunk bibendum egestas, magna own yo' vestibulum ligula, izzle auctizzle justo bling bling quizzle check it out. Maecenas phat elit sit pot funky fresh doggy fo shizzle. Vivamizzle away pede boofron lacus. In rhoncizzle funky fresh leo. Lorizzle ipsum dolor sizzle i saw beyonces tizzles and my pizzle went crizzle, consectetizzle adipiscing elit. Gangsta nisi the bizzle, posuere fo shizzle amizzle, ass sizzle, for sure mattizzle, libero. Crunk izzle faucibus go to hizzle. Ut sizzle cool. Nunc sizzle mammasay mammasa mamma oo sa shut the shizzle up mammasay mammasa mamma oo sa accumsizzle my shizz. Sheezy condimentum da bomb laoreet nunc. Own yo' shizzlin dizzle, its fo rizzle quizzle dope lacinia, phat dizzle commodo felizzle, nec bling bling erizzle nisl daahng dawg nisi. Crazy quam, things dope amizzle, dang vitae, my shizz pulvinar, pimpin'."

            });
            context.SaveChanges();


            //de vijf awards
            context.Award.AddOrUpdate(new Award()
            {
                Naam = "Outstanding Community Impact Award",
                Logo = "http://fc05.deviantart.net/fs70/i/2013/357/a/0/vintage_badge_logo___listen_to_the_banana_by_likamproduct-d6z0z8i.png",
                Beschrijving = "De student geëngageerd zich op een bijzondere en oprechte manier voor zijn opdrachten, zijn medestudent en de hogeschool. <br>Hij/zij draagt bij aan het bevorderen van de uitstraling van Howest door open te staan voor de ander en luisterbereid te zijn. <br>Hij/ zij is een enthousiast en vriendelijk iemand, toont betrokkenheid en is bereid de ander te helpen in zijn verwezenlijkingen. "
            });
            context.Award.AddOrUpdate(new Award()
            {
                Naam = "The Inspirational Student Award",
                Logo = "http://upload.wikimedia.org/wikipedia/commons/thumb/4/48/Radiation_sign_round.svg/520px-Radiation_sign_round.svg.png",
                Beschrijving = "De student inspireert zijn medestudenten en omgeving op eender welke manier. <br>Hij/zij stimuleert hen tot creativiteit, innovatief denken en het ontwikkelen van ondernemingszin. <br>Hij/zij moedigt hen aan tot het ontplooien van hun talent en zichzelf naar een hoger niveau te tillen. <br>Dit kan door een specifiek project van de student of het creëren van een inspirerende omgeving."
            });
            context.Award.AddOrUpdate(new Award()
            {
                Naam = "Heart and Soul Award",
                Logo = "http://www.yowzers.com/ccdata/images/smallMain_29_84.jpg",
                Beschrijving = "Deze student geeft duidelijk om zijn medestudent en zijn schoolomgeving. <br>Hij/zij deelt de waarde van Howest om een zorgende houding aan te nemen en die tot uitdrukking te brengen in omgang met anderen zowel binnen als buiten Howest. <bR>Dit kan zijn door deelname aan een project of zijn/haar gedrag dat aantoont dat hij/zij geeft om duurzaamheid, solidariteit, zorgzaamheid, milieu,  verdraagzaamheid,…"
            });
            context.Award.AddOrUpdate(new Award()
            {
                Naam = "The Most Atypical-student",
                Logo = "http://www.ruralaccents.com/images/D/Tin_Sign_Coca_Cola_Coke_Antique_Logo_Trademark_Vintage_Country_Decor_TSN1069.jpg",
                Beschrijving = "De atypische student is er een die zich onderscheidt van de anderen. <br>Een die zijn/haar talenten tot uiting brengt op zijn/haar eigen creatieve, ondernemende, innovatieve manier. <br>Hij/zij kleurt niet altijd binnen de lijntjes, maar zorgt er wel voor dat het beoogde resultaat tot een goed einde komt. <br>Het atypische van de student kan liggen in zowel zijn/haar karakter/persoonlijkheid, talent, manier van werken, of het uiteindelijke resultaat van zijn/haar werk"
            });
            context.Award.AddOrUpdate(new Award()
            {
                Naam = "Thé Howest ambassador",
                Logo = "http://a1.dspnimg.com/data/l/3225227898752_MDFHyrVS_l.jpg",
                Beschrijving = "Dé Howest ambassadeur onder alle studenten is diegene die zich het meeste inzet om Howest en zijn waarden in de kijker te plaatsen. <br>Hij/zij draagt bij aan de positieve uitstraling van Howest naar de buitenwereld toe en versterkt zo de geloofwaardigheid van Howest als atypische, creatieve, innovatieve en ondernemende hogeschool. <br><br>Dat kan op eender welke manier: een succesvol project, een artikel, een bepaalde uitspraak, een samenwerking met Howest stakeholders, een vermelding in de actualiteit, …"
            });
            context.SaveChanges();




            //contactinfo
            context.Contact.AddOrUpdate(new Contact()
            {
                Straat_Nr = "Graaf Karel de Goedelaan 5",
                Postcode = "8500",
                Gemeente = "Kortrijk",
                Tel = "056 24 12 90",
                Email = "talent.factory@howest.be",
                Land = "België",
                Foto1 = "http://www.talent-factory.eu/2014/sites/default/files/subpage/Screen%20Shot%202014-03-21%20at%2011.24.16_3.jpg",
                Foto2 = "http://www.howest.be/images/news/normal/google_earth_howest.jpg",
                Foto3 = "http://www.howest.be/instapcursus/img/gkg.jpg"
            });
            context.SaveChanges();

            //richtingen
            context.Richting.AddOrUpdate(new Richting() { Naam = "Communicatiemanagement (CM)" });
            context.Richting.AddOrUpdate(new Richting() { Naam = "Digital Arts and Entertainment (DAE)" });
            context.Richting.AddOrUpdate(new Richting() { Naam = "Digital Design and Development (Devine)" });
            context.Richting.AddOrUpdate(new Richting() { Naam = "Ergotherapie (ERGO)" });
            context.Richting.AddOrUpdate(new Richting() { Naam = "Industrieel Productontwerpen (IPO)" });
            context.Richting.AddOrUpdate(new Richting() { Naam = "Journalistiek (JRN)" });
            context.Richting.AddOrUpdate(new Richting() { Naam = "New Media and Communication Technologie (NMCT)" });
            context.Richting.AddOrUpdate(new Richting() { Naam = "Office Management (OM)" });
            context.Richting.AddOrUpdate(new Richting() { Naam = "Toerisme en recreatiemanagement (TRM)" });


            context.SaveChanges();


            //sponsors
            context.Sponsor.AddOrUpdate(new Sponsor()
            {
                Naam = "Codit",
                Logo = "http://www.talent-factory.eu/2014/sites/default/files/styles/sponsor/public/codit.jpg",
                WebAdress = "http://www.codit.eu/",
                SponsorTypeID = 2,
                Beschrijving = "Codit is a leading IT services company providing consultancy, technology and managed services in business integration. Codit successfully helps companies reduce operational costs, improve efficiency and enhance control by enabling people and applications to integrate more efficiently.<br><br>Having started as a highly competent Microsoft BizTalk Server specialist, the company has grown substantially to become a leader in business integration using a wide range of Microsoft technologies, including innovative cloud-based solutions such as Codit Integration Cloud that offers Integration as a Service.<br><br>Codit employs about 50 people in Belgium, France and Portugal, of which 45 are certified Integration Engineers. Since its inception in the year 2000 Codit has successfully implemented over 100 integration solutions worldwide. For more information, please visit<a href='http://www.codit.eu'>www.codit.eu</a> and <a href='http://www.integrationcloud.eu' >www.integrationcloud.eu</a>"
            });
            context.Sponsor.AddOrUpdate(new Sponsor()
            {
                Naam = "HOWEST",
                Logo = "http://www.talent-factory.eu/2014/sites/default/files/styles/sponsor/public/howest_logo_0.jpg",
                WebAdress = "http://www.howest.be/",
                SponsorTypeID = 2,
                Beschrijving = "Howest is een sterk groeiende hogeschool met campussen In Brugge en Kortrijk.<br><br>De 24 bacheloropleidingen en de 7 masteropleidingen zijn van een hoogstaande kwaliteit. Uit jaarlijks onderzoek bij de studenten blijkt dat de tevredenheid groot is. Ook bij de werkgevers geniet Howest een stevige reputatie. De opleidingen met boeiende stages zijn volop gericht op de praktijk en leiden naar goede jobs.",
            });
            context.Sponsor.AddOrUpdate(new Sponsor()
            {
                Naam = "Seamedia",
                Logo = "http://www.talent-factory.eu/2014/sites/default/files/styles/sponsor/public/SeaMedia.gif",
                WebAdress = "http://www.seame.tv/",
                SponsorTypeID = 1,
                Beschrijving = "Sea Media is an innovative project to develop an Internet Television (IPTV) Youth Service, SeaMe.tv, in the European Union’s Two 2 Seas region – Belgium, UK and Northern France. Collaborating cross-border, young people work with professional broadcasters and academics to create programmes suitable for both internet and traditional television broadcast. Those involved are empowered to produce, edit and develop their content."
            });
            context.Sponsor.AddOrUpdate(new Sponsor()
            {
                Naam = "Jetair",
                Logo = "http://www.talent-factory.eu/2014/sites/default/files/styles/sponsor/public/jetair.jpg",
                WebAdress = "http://www.jetaircareer.be//NL/0-home.html",
                SponsorTypeID = 1,
                Beschrijving = "Bij TUI Belgium maken meer dan 1500 collega’s werk van vakantie, voor en achter de schermen, in binnen- en buitenland, bij de touroperator Jetair, de reiskantoren van Jetaircenter, de luchtvaartmaatschappij Jetairfly en de onderhoudsmaatschappij Tec4Jets. Het hoofdkantoor van Jetair te Oostende heeft een ICT afdeling met in totaal 54 medewerkers, waarvan 30 developers en is daarmee één van de grootste IT-afdelingen in de regio Brugge-Oostende. Zij werken aan tal van projecten zoals ontwerp en onderhoud van reservatiesystemen, IT-applicaties voor piloten, webapplicaties voor reiskantoren en boekingssystemen voor hoteliers over de hele wereld. Jetair rekruteert momenteel volop gemotiveerde starters: programmeer jij binnenkort mee de mooiste tijd van het jaar? <a href='www.jetaircareer.be'>www.jetaircareer.be</a>"
            });
            context.Sponsor.AddOrUpdate(new Sponsor()
            {
                Naam = "Stuvo Howest",
                Logo = "http://www.talent-factory.eu/2014/sites/default/files/styles/sponsor/public/stuvo.jpg",
                WebAdress = "http://www.stuvo-howest.be/",
                SponsorTypeID = 2,
                Beschrijving = "<p>Stuvo Howest is de dienst in Howest die de studenten- voorzieningen organiseert.<br />Je vindt er meer info over:</p><ul><li>Studiefinanciering</li><li>Huisvesting</li><li>PC verhuur</li><li>Zelfzorg</li><li>Studentenjobs</li><li>Mobiliteit</li><li>Sport en cultuur</li><li>Studentenstad</li></ul>"
            });
            context.Sponsor.AddOrUpdate(new Sponsor()
            {
                Naam = "Centaura",
                Logo = "http://www.talent-factory.eu/2014/sites/default/files/styles/sponsor/public/centaura_0.jpg",
                WebAdress = "http://www.centaura.be/",
                SponsorTypeID = 3,
                Beschrijving = "Wat zou een studentenleven zijn zonder de studentenclubs?<br><br>Noppes, natuurlijk. Er zijn heel wat studentenverenigingen actief op de campus.<br><br>De grootste en overkoepelende is hoogstudentenclub Centaura.<br><br>Centaura baat campuscafé ’t Bunkerke uit."
            });

            context.SaveChanges();


            //juryleden
            context.JuryLid.AddOrUpdate(new JuryLid()
            {
                Naam = "Barack Obama",
                Bedrijf = "The USA Company",
                Email = "bramregelbrugge@gmail.com",
                Functie = "CEO, President",
                isActive = true,
                Password = "p@ssw0rd"
            });
            context.JuryLid.AddOrUpdate(new JuryLid()
            {
                Naam = "Elio Dirupo",
                Bedrijf = "Belgische regering",
                Email = "Elio@gmail.com",
                Functie = "Baas",
                isActive = true,
                Password = "p@ssw0rd"
            });
            context.JuryLid.AddOrUpdate(new JuryLid()
            {
                Naam = "Steve Jobs",
                Bedrijf = "Apple",
                Email = "Steve@gmail.com",
                Functie = "CEO",
                isActive = false,
                Password = "p@ssw0rd"
            });
            context.JuryLid.AddOrUpdate(new JuryLid()
            {
                Naam = "Albert II",
                Bedrijf = "België",
                Email = "Abert@gmail.com",
                Functie = "niet meer koning",
                isActive = true,
                Password = "p@ssw0rd"
            });
            context.JuryLid.AddOrUpdate(new JuryLid()
            {
                Naam = "Proffesor Gobelijn",
                Bedrijf = "Boem oeps",
                Email = "prof@gmail.com",
                Functie = "wetenschapper",
                isActive = true,
                Password = "p@ssw0rd"
            });

            context.SaveChanges();



            //Home
            context.Home.AddOrUpdate(new Home()
            {
                Inleiding = "Ben je student of lector van één van de opleidingen in Howest Kortrijk? Weet jij wie de titel verdient van Outstanding Community Impact Award, The Inspirational Student Award, Heart and Soul Award, The Most Atypical-student of Thé Howest ambassador? Geef dan hier je kandidaten door (doe het snel en zeker voor 12/06)<br><br>De kandidaat moet aan enkele voorwaarden voldoen (die steeds gescreend worden):<br>1. Hij/zij moet laatstejaars student van één van de deelnemende opleidingen aan de awardshow<br>2. Moet door minstens 2 studenten of lectoren voorgedragen worden",
                AwardInfo = "Er zijn dit jaar 5 Awards te winnen, namelijk Outstanding Community Impact Award, The Inspirational Student Award, Heart and Soul Award, The Most Atypical-student of Thé Howest ambassador. Vind jij dat je iemand ken die voor een van deze awards moet ingeschreven worden, schrijf hem dan snel in via onze site!"

            });

            context.SaveChanges();


            //Hall Of Fame

            context.HallOfFame.AddOrUpdate(new HallOfFame()
            {
                Jaartal = 2013,
                HTMLInhoud = "<p>Deze studenten gingen lopen met een Talent-Factory award en tal van mooie prijzen! <br />Proficiat! <a href='http://www.talent-factory.eu/2013' target='_blank'>Bekijk ook de website van editie 2013!</a></p><ul><li><strong>DAE Top Ace</strong>: <a href='http://www.talent-factory.eu/2013/nominee/brian-cox' target='_blank'>Brian Cox</a></li><li><strong>Best student minded club 2012-2013</strong>: <a href='http://www.talent-factory.eu/2013/nominee/centaura' target='_blank'>Centaura</a></li><li><strong>Student zonder grenzen</strong>: <a href='http://www.talent-factory.eu/2013/nominee/kim-van-nieuwenhuize' target='_blank'>Kim Van Nieuwenhuize</a></li><li><strong>Journalistiek beest</strong>: <a href='http://www.talent-factory.eu/2013/nominee/klaas-allosserie' target='_blank'>Klaas Allosserie</a></li><li><strong>Communicatiespecialist</strong>: <a href='http://www.talent-factory.eu/2013/nominee/margot-wybo' target='_blank'>Margot Wybo</a></li><li><strong>Howest Office Manager of the Year</strong>: <a href='http://www.talent-factory.eu/2013/nominee/marieke-amblard' target='_blank'>Marieke Amblard</a></li><li><strong>New Media Geek of the Year</strong>: <a href='http://www.talent-factory.eu/2013/nominee/sven-vervynckt' target='_blank'>Sven Vervynckt</a></li><li><strong>Best Start-Up Design Office</strong>: <a href='http://www.talent-factory.eu/2013/nominee/team1-thomas-tine-steven-anthony-maxim-kevin' target='_blank'>Thomas Desoete, Tine Feys, Steven De Moortel, Anthony Promos Promopoulos, Maxim Vandekerckhove en Kevin Ceuterick</a></li><li><strong>Black Belt Deviner</strong>: <a href='http://www.talent-factory.eu/2013/nominee/victor-popov' target='_blank'>Victor Popov</a></li></ul>",
            });
            context.HallOfFame.AddOrUpdate(new HallOfFame()
            {
                Jaartal = 2012,
                HTMLInhoud = "<p>Deze studenten gingen lopen met een Talent-Factory award en tal van mooie prijzen! Proficiat!<br /><a href='http://www.talent-factory.eu/2012' target='_blank'>Bekijk ook de website van editie 2012!</a></p><p><strong>Algemeen</strong></p><ul><li>Best student minded club 2011-2012: <a href='http://www.talent-factory.eu/2012/nominee/brihos' target='_blank'>Brihos</a></li><li>Howest best ambassador: <a href='http://www.talent-factory.eu/2012/nominee/quinten-de-corte-en-robin-cox' target='_blank'>Quinten De Corte en Robin Cox</a></li></ul><p><strong>Communicatiemanagement</strong></p><ul><li>Best Creative: <a href='http://www.talent-factory.eu/2012/nominee/kim-demeulenaere' target='_blank'>Kim Demeulenaere</a>, <a href='http://www.talent-factory.eu/2012/nominee/natasja-bekaert' target='_blank'>Natasja Bekaert</a></li><li>Best Strategist: <a href='http://www.talent-factory.eu/2012/nominee/marjolein-sackx-public-relations' target='_blank'>Marjolein Sackx (Public Relations)</a></li></ul><p><strong>Digital Arts and Entertainment</strong></p><ul><li>Best 3D Artist: <a href='http://www.talent-factory.eu/2012/nominee/steven-de-meyer' target='_blank'>Steven De Meyer</a></li><li>Best Game Developer: <a href='http://www.talent-factory.eu/2012/nominee/fries-carton' target='_blank'>Fries Carton</a></li></ul><p><strong>Digital Design and Development</strong></p><ul><li>Best Deviner: <a href='http://www.talent-factory.eu/2012/nominee/ruben-temmerman' target='_blank'>Ruben Temmerman</a></li><li>Best Interactive Developer: <a href='http://www.talent-factory.eu/2012/nominee/wannes-vermeulen' target='_blank'>Wannes Vermeulen</a></li><li>Best Motion: <a href='http://www.talent-factory.eu/2012/nominee/jonas-keppens' target='_blank'>Jonas Keppens</a>, <a href='http://www.talent-factory.eu/2012/nominee/florian-vanthuyne' target='_blank'>Florian Vanthuyne</a>, <a href='http://www.talent-factory.eu/2012/nominee/chatchai-sribunruang' target='_blank'>Chatchai Sribunruang</a>, <a href='http://www.talent-factory.eu/2012/nominee/vaha-malsagov' target='_blank'>Vaha Malsagov</a>, <a href='http://www.talent-factory.eu/2012/nominee/filip-anthonissen' target='_blank'>Filip Anthonissen</a>, <a href='http://www.talent-factory.eu/2012/nominee/joeri-wauters' target='_blank'>Joeri Wauters</a>, <a href='http://www.talent-factory.eu/2012/nominee/floris-hugelier' target='_blank'>Floris Hugelier</a></li></ul><p><strong>Industrieel Productontwerpen</strong></p><ul><li>Best Business Project: <a href='http://www.talent-factory.eu/2012/nominee/jan-beeckaert' target='_blank'>Jan Beeckaert</a>, <a href='http://www.talent-factory.eu/2012/nominee/ben-de-meulemeester' target='_blank'>Ben De Meulemeester</a>, <a href='http://www.talent-factory.eu/2012/nominee/pauline-lanckman' target='_blank'>Pauline Lanckman</a>, <a href='http://www.talent-factory.eu/2012/nominee/arthur-pauwels' target='_blank'>Arthur Pauwels</a></li><li>Best Design Project: <a href='http://www.talent-factory.eu/2012/nominee/geert-decock' target='_blank'>Geert Decock</a></li><li>Best Industrial Project: <a href='http://www.talent-factory.eu/2012/nominee/lucas-gruwez-0' target='_blank'>Lucas Gruwez</a>, <a href='http://www.talent-factory.eu/2012/nominee/matthieu-libeert' target='_blank'>Matthieu Libeert</a>, <a href='http://www.talent-factory.eu/2012/nominee/bieke-bruggeman' target='_blank'>Bieke Bruggeman</a></li></ul><p><strong>Journalistiek </strong></p><ul><li>Best Radio Project: <a href='http://www.talent-factory.eu/2012/nominee/lucas-derycke' target='_blank'>Lucas Derycke</a></li><li>Best Television Project: <a href='http://www.talent-factory.eu/2012/nominee/francis-doornaert-0' target='_blank'>Francis Doornaert</a>, <a href='http://www.talent-factory.eu/2012/nominee/marieke-decock' target='_blank'>Marieke Decock</a>, <a href='http://www.talent-factory.eu/2012/nominee/paulien-vandenheede' target='_blank'>Paulien Vandenheede</a></li><li>Best Article: <a href='http://www.talent-factory.eu/2012/nominee/julie-jacques' target='_blank'>Julie Jacques</a></li></ul><p><strong>New Media and Communication Technology </strong></p><ul><li>Best Developer: <a href='http://www.talent-factory.eu/2012/nominee/sven-vervynckt' target='_blank'>Sven Vervynckt</a></li><li>Best New Media: <a href='http://www.talent-factory.eu/2012/nominee/beno%C3%AEt-boucart' target='_blank'>Benoît Boucart</a></li><li>Best Technology: <a href='http://www.talent-factory.eu/2012/nominee/machiel-sleeuwaert' target='_blank'>Machiel Sleeuwaert</a></li></ul>"
            });
            context.HallOfFame.AddOrUpdate(new HallOfFame()
            {
                Jaartal = 2011,
                HTMLInhoud = "<p>Deze studenten gingen lopen met een Talent-Factory award en tal van mooie prijzen! Proficiat!<br /><a href='http://www.talent-factory.eu/2011' target='_blank'>Bekijk ook de website van editie 2011!</a></p><p><strong>Communicatiemanagement</strong></p><ul><li><span>Best Communication Project:<a href='http://www.talent-factory.eu/2011/nominee/lobke-gunst'>Lobke Gunst</a><span>, <a href='http://www.talent-factory.eu/2011/nominee/hanne-verfaillie'>Hanne Verfaillie</a><span>, <a href='http://www.talent-factory.eu/2011/nominee/lisa-bauwens'>Lisa Bauwens</a><span>, <a href='http://www.talent-factory.eu/2011/nominee/ine-wittouck'>Ine Wittouck</a></span></span></span></span></li><li><span>Best Creative: <a href='http://www.talent-factory.eu/2011/nominee/jens-govaert'>Jens Govaert</a><span>, <a href='http://www.talent-factory.eu/2011/nominee/matthies-ryckebusch'>Matthies Ryckebusch</a></span></span></li></ul><p><strong>Digital Arts and Entertainment</strong></p><ul><li>Best 3D Artist: <a href='http://www.talent-factory.eu/2011/nominee/laura-loossens'>Laura Loossens</a></li><li>Best Game Developer: <a href='http://www.talent-factory.eu/2011/nominee/roel-coucke'>Roel Coucke</a></li><li>Best Integration Project Team: <a href='http://www.talent-factory.eu/2011/nominee/maya-goedert'>Maya Goedert</a>, <a href='http://www.talent-factory.eu/2011/nominee/wannes-vanspranghe'>Wannes Vanspranghe</a>, <a href='http://www.talent-factory.eu/2011/nominee/xander-clerckx'>Xander Clerckx</a>, <a href='http://www.talent-factory.eu/2011/nominee/aaron-dhaene'>Aaron D'Haene</a>, <a href='http://www.talent-factory.eu/2011/nominee/laura-loossens-0'>Laura Loossens</a>, <a href='http://www.talent-factory.eu/2011/nominee/vincent-van-den-heede'>Vincent Van den Heede</a>, <a href='http://www.talent-factory.eu/2011/nominee/sam-verschraegen'>Sam Verschraegen</a></li></ul><p><strong>Devine</strong></p><ul><li>Best Deviner: <a href='http://www.talent-factory.eu/2011/nominee/yordi-uytersprot'>Yordi Uytersprot</a></li><li>Best Interactive Developer: <a href='http://www.talent-factory.eu/2011/nominee/jonathan-dupont'>Jonathan Dupont</a></li><li>Best Motion Graphic: <a href='http://www.talent-factory.eu/2011/nominee/fr%C3%A9d%C3%A9ric-baert-0'>Frédéric Baert</a></li></ul><p><strong>Industrieel Productontwerpen</strong></p><ul><li>Best Design Project: <a href='http://www.talent-factory.eu/2011/nominee/stijn-devolder'>Stijn Devolder</a>, <a href='http://www.talent-factory.eu/2011/nominee/jelle-desimpelaere'>Jelle Desimpelaere</a></li><li>Best Industrial Project: <a href='http://www.talent-factory.eu/2011/nominee/jeroen-berton'>Jeroen Berton</a>, <a href='http://www.talent-factory.eu/2011/nominee/jorgen-sabbe'>Jorgen Sabbe</a>, <a href='http://www.talent-factory.eu/2011/nominee/koen-van-exterghem'>Koen Van Exterghem</a>, <a href='http://www.talent-factory.eu/2011/nominee/jelle-vandooren'>Jelle Vandooren</a>, <a href='http://www.talent-factory.eu/2011/nominee/tine-verroken'>Tine Verroken</a></li></ul><p><strong>Journalistiek</strong></p><ul><li>Journalistiek Best Radio Project: <a href='http://www.talent-factory.eu/2011/nominee/robin-cox'>Robin Cox</a>, <a style='line-height: 1.538em;' href='http://www.talent-factory.eu/2011/nominee/jens-lemant-0'>Jens Lemant</a></li><li>Best Television Report: <a href='http://www.talent-factory.eu/2011/nominee/glenn-dierick'>Glenn Dierick</a> </li><li>Best Article: <a href='http://www.talent-factory.eu/2011/nominee/dries-dehaudt'>Dries Dehaudt</a></li></ul><p><strong>New Media and Communication Technology</strong></p><ul><li>Best Developer: <a href='http://www.talent-factory.eu/2011/nominee/maxim-braekman'>Maxim Braekman</a></li><li>Best New Media: <a href='http://www.talent-factory.eu/2011/nominee/frederik-de-backer'>Frederik De Backer</a>, <a href='http://www.talent-factory.eu/2011/nominee/arnaud-heylen'>Arnaud Heylen</a>, <a href='http://www.talent-factory.eu/2011/nominee/kevin-ringoot'>Kevin Ringoot</a> </li><li>Best Technology: <a href='http://www.talent-factory.eu/2011/nominee/sam-cappelle'>Sam Cappelle</a></li></ul>"
            });
            context.HallOfFame.AddOrUpdate(new HallOfFame()
            {
                Jaartal = 2010,
                HTMLInhoud = "<h2>Communicatie Management</h2><!--////////////////////////// TalentFactory awards CM ////////////////////////// --><h3>Best Presentation</h3><p><span class='flickr-wrap'><a href='http://farm4.static.flickr.com/3535/5723505185_4b017f1dc7.jpg' title='2010_bestPresentationSensationWhite' class='colorbox' rel='gallery-all'><img class=' flickr-photo-img' height='240' width='183' typeof='foaf:Image' src='http://farm4.staticflickr.com/3535/5723505185_4b017f1dc7_m.jpg' alt='2010_bestPresentationSensationWhite' title='2010_bestPresentationSensationWhite' /></a><span class='flickr-credit' style='max-width: 240px;'><a href='http://www.flickr.com/photos/clokortrijk/5723505185' title='View on Flickr. To enlarge click pic.' target='_blank'>2010_bestPresentationSensationWhite</a></span></span><br /> Winnaar 2010 - Talent-Factory: best presentation: Sensation White: Daphny Aeck, Marjan Cappelle, Dominique Cappendyck, Ruth Sap, Charlotte Spriet</p><h3>Best Print Advertising</h3><p><span class='flickr-wrap'><a href='http://farm3.static.flickr.com/2573/5723509507_07ec01d7a4.jpg' title='2010_BestPrintAdvertising_BonoVanhoonacker' class='colorbox' rel='gallery-all'><img class=' flickr-photo-img' height='240' width='170' typeof='foaf:Image' src='http://farm3.staticflickr.com/2573/5723509507_07ec01d7a4_m.jpg' alt='2010_BestPrintAdvertising_BonoVanhoonacker' title='2010_BestPrintAdvertising_BonoVanhoonacker' /></a><span class='flickr-credit' style='max-width: 240px;'><a href='http://www.flickr.com/photos/clokortrijk/5723509507' title='View on Flickr. To enlarge click pic.' target='_blank'>2010_BestPrintAdvertising_BonoVanhoonacker</a></span></span><br /> Winnaar 2010 - Talent-Factory: best print advertising: Bono Vanhoonacker</p><h3>Beste Commercial</h3><p><iframe src='http://www.youtube.com/embed/mx6mjIByvn4' frameborder='0' width='560' height='315'></iframe></p><p>Hall of Fame - talent-factory.eu Winnaar 2010 - Talent-Factory beste commercial - Makers: Brecht Boelens en Stefanie Vynckier</p><h3>Beste Radiospot</h3><p><iframe src='http://www.youtube.com/embed/M52wPXEzq6A' frameborder='0' width='420' height='315'></iframe></p><p>Winnaar 2010 - Talent-Factory beste radio spot: Guinness maker: Jens Govaert</p><p> </p><h2>Journalistiek</h2><!--////////////////////////// TalentFactory awards JOU ////////////////////////// --><h3>Best photography</h3><p><span class='flickr-wrap'><a href='http://farm4.static.flickr.com/3371/5724045198_7e2ea52dd9.jpg' title='2010_bestPhotography_AnthonieLanckman' class='colorbox' rel='gallery-all'><img class=' flickr-photo-img' height='160' width='240' typeof='foaf:Image' src='http://farm4.staticflickr.com/3371/5724045198_7e2ea52dd9_m.jpg' alt='2010_bestPhotography_AnthonieLanckman' title='2010_bestPhotography_AnthonieLanckman' /></a><span class='flickr-credit' style='max-width: 240px;'><a href='http://www.flickr.com/photos/clokortrijk/5724045198' title='View on Flickr. To enlarge click pic.' target='_blank'>2010_bestPhotography_AnthonieLanckman</a></span></span><br /> Winnaar 2010 - Talent-Factory: best photography: Anthonie Lanckman</p><h3>Best Project Print</h3><p><span class='flickr-wrap'><a href='http://farm6.static.flickr.com/5164/5723513625_8f55890160.jpg' title='2010_bestProjectPrint_KorneelTemperman' class='colorbox' rel='gallery-all'><img class=' flickr-photo-img' height='240' width='170' typeof='foaf:Image' src='http://farm6.staticflickr.com/5164/5723513625_8f55890160_m.jpg' alt='2010_bestProjectPrint_KorneelTemperman' title='2010_bestProjectPrint_KorneelTemperman' /></a><span class='flickr-credit' style='max-width: 240px;'><a href='http://www.flickr.com/photos/clokortrijk/5723513625' title='View on Flickr. To enlarge click pic.' target='_blank'>2010_bestProjectPrint_KorneelTemperman</a></span></span><br /> Winnaar 2010 - Talent-Factory: best project print: Sire, we hebben geen ronderenners meer Korneel Timperman</p><h3>Beste Nieuwsitem</h3><p><iframe src='http://www.youtube.com/embed/khxC031TqcY' frameborder='0' width='560' height='315'></iframe></p><p>Talent-factory.eu Winnaar 2010 - Talent-Factory beste nieuwsitem: Portret Matthieu Jottier<br /> Maker: Tine Deforche</p><h3>Beste Radio Project</h3><p><iframe src='http://www.youtube.com/embed/iZsg0KbPcTs' frameborder='0' width='420' height='315'></iframe></p><p>Winnaar 2010 - Talent-Factory beste radio project: Rusthuis San Diego in Menen moet dicht.<br /> Maker: Jens Lemant</p><!--////////////////////////// MM awards Devine ////////////////////////// --><p> </p><h2>Digital Design &amp; Media - Devine</h2><h3>2 Devine</h3><p><iframe src='http://www.youtube.com/embed/oSy7r71LpIw' frameborder='0' width='560' height='315'></iframe></p><p>Winnaar 2010 - Talent-Factory: Multi-Mania: 2 Devine: Frederik Baert</p><h3>1 Devine</h3><p><iframe src='http://www.youtube.com/embed/amwkNFrj_LU' frameborder='0' width='560' height='315'></iframe></p><p>Winnaar 2010 - Talent-Factory: Multi-Mania: 1 Devine: Simon Pertz</p><!--////////////////////////// MM awards DAE ////////////////////////// --><p> </p><h2>Digital Arts   Entertainment - DAE</h2><h3>3 DAE</h3><p><iframe src='http://www.youtube.com/embed/QTA45JnG8Rc' frameborder='0' width='560' height='315'></iframe></p><p>Talent-factory.eu Winnaar 2010 - Talent-Factory: Multi-Mania: 3 DAE: Waldo Bronchart</p><h3>DAE Arts</h3><p><iframe src='http://www.youtube.com/embed/A8oioaVg0_g' frameborder='0' width='560' height='315'></iframe></p><p>Talent-factory.eu Winnaar 2010 - Talent-Factory: Multi-Mania: DAE Arts: Xander Clercks</p><h3>DAE Development</h3><p><iframe src='http://www.youtube.com/embed/LornNa7E464' frameborder='0' width='560' height='315'></iframe></p><p>Winnaar 2010 - Talent-Factory: Multi-Mania: DAE Development: TychoTerryn</p><!--////////////////////////// MM awards NMCT ////////////////////////// --><p> </p><h2>New Media and Communication Technology - NMCT</h2><h3>3 NMCT</h3><p><iframe src='http://www.youtube.com/embed/v3cY8BPLQkg' frameborder='0' width='560' height='315'></iframe></p><p>Winnaar 2010 - Talent-Factory: Multi-Mania: 3NMCT: Kjelle Vergauwe</p><h3>2 NMCT</h3><p><iframe src='http://www.youtube.com/embed/42B-vWBGuHs' frameborder='0' width='560' height='315'></iframe></p><p>Winnaar 2010 - Talent-Factory: Multi-Mania: 2 NMCT: Ayrton De Craene</p><h3>1 NMCT</h3><p><iframe src='http://www.youtube.com/embed/p6usjWiDhbk' frameborder='0' width='560' height='315'></iframe></p><p>Winnaar 2010 - Talent-Factory: Multi-Mania: 1NMCT: Pim Van Vlaenderen</p>"
            });
            context.HallOfFame.AddOrUpdate(new HallOfFame()
            {
                Jaartal = 2009,
                HTMLInhoud = "<h2>Industrieel Productontwerpen</h2><h3>Meest ondernemende hogeschool</h3><p>Howest behaalde wederom erkenning in de Unizo prijs ondernemingszin 2009 als meest ondernemende hogeschool.<br /> Met de projecten <a href='http://www.mymachine.be/' target='_new'>myMachine</a> (studenten 2e jaar IPO) en de opstart van ontwerpbureau <a href='www.elevenfeet.be' target='_new'>elevenfeet.be</a>, een project van vijf studenten 3e jaar IPO, kaapte Howest zowel de eerste als tweede prijs weg in deze wedstrijd.</p><h3>Innovation award 2009</h3><p>Xander Vanwynsberghe (3e IPO) won de Innovation award 2009 in de categorie 'Product design' met zijn innovatief en ecologisch kippenhok COOOP voor Savic. Hij viel met dit project ook bij OVAM in de prijzen (2009) tijdens de Ecodesign competitie.</p><h3>Portfolio award 2009</h3><p>Matthias Desmedt (3e IPO) behaalde de portfolio award 2009 van Optimo voor het eindwerk Limonluk, een ultramoderne limoenpers voor DesignUM Istanbul.</p><h3>Small Business Project 2009 categorie 'best design'</h3><p>Team iNORM scoorde met 'pomme', de hippe voeder- en broedplaats voor vogels, in de wedstrijd beste Small Business Project 2009 categorie 'best design'.</p><p> </p><h2>Communicatie Management</h2><!--////////////////////////// TalentFactory awards CM ////////////////////////// --><p><iframe src='http://www.youtube.com/embed/-Aa4nrFg9jE' frameborder='0' width='560' height='315'></iframe></p><p class='MsoNormal'>Winnaar 2009 - Talent-Factory: beste commercial: <span>Bram Van Acker </span></p><p> </p><p><iframe src='http://www.youtube.com/embed/DtYqJfH6NDA' frameborder='0' width='420' height='315'></iframe></p><p>Winnaar 2009 - Talent-Factory beste radiospot. We geven graag credit aan de maker(s): alvast bedankt om contact op te nemen met talent[DOT]factory[AT]howest.be</p><p> </p><h2>Journalistiek</h2><!--////////////////////////// TalentFactory awards JOU ////////////////////////// --><p><iframe src='http://www.youtube.com/embed/3HjzPstmmM0' frameborder='0' width='560' height='315'></iframe></p><p>Winnaar 2009 - Talent-Factory beste nieuwsitem: Migrantenondernemingen. We geven graag credit aan de maker(s): alvast bedankt om contact op te nemen met talent[DOT]factory[AT]howest.be</p><p>We zijn verder aan het grasduinen in ons archief om ook andere werken te kunnen opnemen... wordt dus vervolgd</p><p> </p><h2>New Media and Communication Technology - NMCT</h2><p>Winnaar 2009 - Talent-Factory: Multi-Mania: Integration Corporate: Daan De Smedt</p><p><iframe src='http://www.youtube.com/embed/-XqqhsPHaXA' frameborder='0' width='560' height='315'></iframe></p><p>winnaar 2009 - Talent-Factory: Multi-Mania: Graphics Web: Stef Smet</p><p><iframe src='http://www.youtube.com/embed/MhkzZRPUYNA' frameborder='0' width='560' height='315'></iframe></p><p>Winnaar 2009 - Talent-Factory: Multi-Mania: Graphics 2D: Benjamin De Wael</p>"
            });


            context.SaveChanges();

            //TwitterFeed
            context.TwitterFeed.AddOrUpdate(new TwitterFeed() { Hashtag = "TF2014" });
            context.TwitterFeed.AddOrUpdate(new TwitterFeed() { Hashtag = "TF" });
            context.TwitterFeed.AddOrUpdate(new TwitterFeed() { Hashtag = "TalentFactory2014" });
            context.TwitterFeed.AddOrUpdate(new TwitterFeed() { Hashtag = "TalentFactory" });
            context.TwitterFeed.AddOrUpdate(new TwitterFeed() { Hashtag = "tfkortrijk" });

            context.SaveChanges();

            context.FlickrAlbum.AddOrUpdate(new FlickrAlbum() { Beschrijving = "clokortrijk/with/7489240656" });

            context.SaveChanges();

            //nominaties A1
            context.Nominatie.AddOrUpdate(new Nominatie()
            {
                Voornaam = "Bram",
                Naam = "Regelbrugge",
                Email = "bramregelbrugge@gmail.com",
                Tel = "0479837774",
                Straat_Nr = "Canadezenlaan 4",
                Gemeente = "Adegem",
                Postcode = "9991",
                Land = "België",
                Richting = context.Richting.Where(x => x.Naam == "New Media and Communication Technologie (NMCT)").FirstOrDefault(),
                Beschrijving = "Cupcake ipsum dolor sit amet biscuit gummies applicake. Apple pie tootsie roll apple pie dragée. Pastry I love candy canes biscuit. Ice cream jelly beans fruitcake. Halvah I love jelly beans soufflé. Unerdwear.com chocolate bar cheesecake candy canes I love pudding. Unerdwear.com sesame snaps I love cake unerdwear.com dessert sweet. Candy canes pudding I love applicake lollipop lemon drops candy cupcake. Candy canes apple pie biscuit pudding I love muffin. Liquorice powder pastry I love tiramisu dessert. Caramels danish gummies tootsie roll applicake sesame snaps carrot cake. Carrot cake wafer marshmallow tiramisu gummi bears.",
                ExtraLinks = "https://www.youtube.com/",
                Geslacht = "man",
                AwardId = 1,
                GeboorteDatum = new DateTime(1994, 4, 8, 0, 0, 0),
                Key = "kjdfhgvnjhdsfgvbui",
                IsActive = true,
                Foto = "https://yt3.ggpht.com/-K0TC0xalK1Y/AAAAAAAAAAI/AAAAAAAAAAA/vLp88JFMyFM/s88-c-k-no/photo.jpg"
            });

            context.Nominatie.AddOrUpdate(new Nominatie()
            {
                Voornaam = "Bernhard",
                Naam = "Mostrey",
                Email = "bramregelbrugge@gmail.com",
                Tel = "0479837774",
                Straat_Nr = "oude vestingstraat 10",
                Gemeente = "Kortijk",
                Postcode = "8500",
                Land = "België",
                Richting = context.Richting.Where(x => x.Naam == "New Media and Communication Technologie (NMCT)").FirstOrDefault(),
                Beschrijving = "Unerdwear.com lemon drops toffee sugar plum fruitcake dessert cotton candy muffin danish. Soufflé chocolate bar I love I love. Bear claw sugar plum I love I love sesame snaps. Lemon drops biscuit muffin lemon drops cookie sweet. Cheesecake jelly-o I love pie croissant I love toffee. Macaroon croissant toffee jelly-o sweet unerdwear.com. Donut jelly soufflé jelly beans macaroon candy cupcake gummies. Jelly beans I love cake croissant sugar plum carrot cake fruitcake muffin. Oat cake cake applicake pudding. Jelly sweet I love donut marzipan topping soufflé jelly beans. Gingerbread I love fruitcake oat cake topping brownie. Sugar plum caramels lemon drops soufflé unerdwear.com dessert gummi bears.",
                ExtraLinks = "https://www.youtube.com/",
                Geslacht = "man",
                AwardId = 1,
                GeboorteDatum = new DateTime(1994, 10, 16, 0, 0, 0),
                Key = "dzhvqukjefhviukefjhdqnf",
                IsActive = true,
                Foto = "http://users.telenet.be/gustav.mostrey/images/2007%20BB%20Marleen%20002.jpg"
            });
            context.Nominatie.AddOrUpdate(new Nominatie()
            {
                Voornaam = "Jeroen",
                Naam = "Valcke",
                Email = "bramregelbrugge@gmail.com",
                Tel = "0479837774",
                Straat_Nr = "Mariakerksesteenweg 32",
                Gemeente = "Gent",
                Postcode = "9000",
                Land = "België",
                Richting = context.Richting.Where(x => x.Naam == "New Media and Communication Technologie (NMCT)").FirstOrDefault(),
                Beschrijving = "Candy jelly beans chocolate chocolate croissant bonbon chocolate bar. Cotton candy lemon drops muffin macaroon muffin caramels apple pie sweet jujubes. Applicake gummi bears caramels I love. Pudding applicake I love pastry muffin gummi bears macaroon. Cotton candy marzipan macaroon. Liquorice marzipan cookie icing danish jelly tart biscuit donut. Dessert wafer brownie candy candy canes. I love jelly-o biscuit jelly beans apple pie soufflé cheesecake danish. Sesame snaps cake chocolate bar. Lollipop liquorice wafer. I love jelly beans sugar plum. Pastry soufflé I love bear claw.",
                ExtraLinks = "https://www.youtube.com/",
                Geslacht = "man",
                AwardId = 1,
                GeboorteDatum = new DateTime(1994, 9, 23, 0, 0, 0),
                Key = "sdliqvjnfijdhkvnd",
                IsActive = true,
                Foto = "http://m.c.lnkd.licdn.com/mpr/pub/image-ILvEX5bZ0Ztbb2nCz1iM1JqoBg_ln2iWISpJ1e3ZBh5DnZS3ILvJxIVZBtAA2pXzsBwV/jeroen-valcke.jpg"
            });
            context.Nominatie.AddOrUpdate(new Nominatie()
            {
                Voornaam = "Matthias",
                Naam = "Neuville",
                Email = "bramregelbrugge@gmail.com",
                Tel = "0479837774",
                Straat_Nr = "Duivenkot 3",
                Gemeente = "Zedelgem",
                Postcode = "8210",
                Land = "België",
                Richting = context.Richting.Where(x => x.Naam == "New Media and Communication Technologie (NMCT)").FirstOrDefault(),
                Beschrijving = "Macaroon pudding fruitcake halvah I love gummies. Oat cake cake jelly beans carrot cake tiramisu jelly beans. Topping cookie I love. Chocolate cake topping chocolate bar I love icing candy. Lemon drops jelly chocolate bar I love tiramisu I love I love liquorice chocolate bar. I love applicake I love croissant sweet I love liquorice fruitcake. Dragée dessert dragée chocolate chocolate bar lemon drops gummi bears bonbon. Cotton candy powder jelly-o I love cupcake gummies marzipan. Lollipop marzipan liquorice tiramisu soufflé. Cake soufflé sesame snaps. Soufflé dessert halvah apple pie. Apple pie cupcake pudding I love.",
                ExtraLinks = "https://www.youtube.com/",
                Geslacht = "man",
                AwardId = 1,
                GeboorteDatum = new DateTime(1994, 9, 9, 0, 0, 0),
                Key = "difjknekjvsf",
                IsActive = true,
                Foto = "https://pbs.twimg.com/profile_images/448809233018912768/PIPX_MYf.png"
            });
            //nominaties2
            context.Nominatie.AddOrUpdate(new Nominatie()
            {
                Voornaam = "Fien",
                Naam = "Van Dorpe",
                Email = "bramregelbrugge@gmail.com",
                Tel = "0479837774",
                Straat_Nr = "straatnaam 6",
                Gemeente = "Roeselare",
                Postcode = "8800",
                Land = "België",
                Richting = context.Richting.Where(x => x.Naam == "Ergotherapie (ERGO)").FirstOrDefault(),
                Beschrijving = "Liquorice applicake tart apple pie candy tiramisu jelly-o icing dragée. Halvah brownie I love ice cream sesame snaps. Jelly I love topping croissant jelly beans. I love I love biscuit danish cheesecake sugar plum gummi bears. Caramels chocolate jelly-o cheesecake biscuit jelly-o I love cake pie. Icing jelly beans liquorice cotton candy fruitcake donut. Jelly beans bear claw biscuit brownie dessert donut marshmallow caramels. Tart macaroon cake pie sweet jelly beans I love marshmallow. Dragée I love icing. Sesame snaps ice cream dessert jujubes tart. Jelly-o chocolate cake tiramisu I love I love pie pie cotton candy. I love pie candy canes.",
                ExtraLinks = "https://www.youtube.com/",
                Geslacht = "vrouw",
                AwardId = 2,
                GeboorteDatum = new DateTime(1995, 8, 28, 0, 0, 0),
                Key = "ksfjbeqkjbn",
                IsActive = true,
                Foto = "http://photos-a.ak.fbcdn.net/hphotos-ak-ash3/t1.0-0/q71/c0.0.960.562/s480x480/1016131_393844347400645_670788368_n.jpg"
            });
            context.Nominatie.AddOrUpdate(new Nominatie()
            {
                Voornaam = "Jason",
                Naam = "Voet",
                Email = "bramregelbrugge@gmail.com",
                Tel = "0479837774",
                Straat_Nr = "duts 46",
                Gemeente = "Brugge",
                Postcode = "8000",
                Land = "België",
                Richting = context.Richting.Where(x => x.Naam == "Digital Arts and Entertainment (DAE)").FirstOrDefault(),
                Beschrijving = "Cupcake ipsum dolor sit amet lollipop jelly beans caramels marzipan. Brownie jelly gingerbread chocolate bar croissant ice cream muffin macaroon. Chupa chups biscuit jelly chocolate bar sesame snaps liquorice I love lollipop. Gummies croissant pastry I love lollipop. Cheesecake carrot cake I love cotton candy biscuit I love soufflé tootsie roll cookie. Apple pie cookie chocolate biscuit I love brownie jelly-o apple pie icing. Jelly beans bonbon bear claw pastry I love dragée liquorice. Brownie I love jelly beans I love bear claw tart carrot cake dragée. Soufflé macaroon candy biscuit chocolate cake I love gummies croissant icing. Toffee dragée cheesecake tootsie roll powder. Danish applicake topping wafer sugar plum. I love bear claw cake liquorice chupa chups marzipan. Icing brownie jelly beans chocolate cake. Sweet candy canes cupcake I love sesame snaps croissant.",
                ExtraLinks = "https://www.youtube.com/",
                Geslacht = "man",
                AwardId = 2,
                GeboorteDatum = new DateTime(1995, 5, 15, 0, 0, 0),
                Key = "sfglvkdnfbv",
                IsActive = true,
                Foto = "http://m.c.lnkd.licdn.com/mpr/pub/image-5pYFCOC6V9v-tVaeHUDAThCKACIcB7TH-vYAODU6snDQbglJspYAfAsV52tQO8sJ3ax/jason-voet.jpg"
            });

            context.Nominatie.AddOrUpdate(new Nominatie()
            {
                Voornaam = "Lisa",
                Naam = "Dequeker",
                Email = "bramregelbrugge@gmail.com",
                Tel = "0479837774",
                Straat_Nr = "Zwevegemsestraat 46",
                Gemeente = "Kortijk",
                Postcode = "8500",
                Land = "België",
                Richting = context.Richting.Where(x => x.Naam == "Communicatiemanagement (CM)").FirstOrDefault(),
                Beschrijving = "Gummi bears cupcake sugar plum applicake I love tart powder brownie donut. Icing oat cake jelly. Jelly beans cookie lollipop soufflé cookie I love bonbon cheesecake chocolate bar. Sugar plum ice cream bear claw biscuit lemon drops. Ice cream gummies muffin sugar plum sesame snaps jujubes jujubes. Halvah ice cream icing toffee sesame snaps sweet cotton candy lemon drops croissant. Tiramisu icing icing tart. Gingerbread gingerbread unerdwear.com chocolate cake topping. Cupcake donut I love pie unerdwear.com. Chocolate bar jelly apple pie sesame snaps dragée dragée biscuit I love I love. Muffin cupcake pie donut I love pastry. I love pie I love macaroon jelly beans cake I love cake dessert. Pie powder cake liquorice gummi bears candy canes. I love tootsie roll chupa chups oat cake carrot cake sweet soufflé chocolate cake bonbon.",
                ExtraLinks = "https://www.youtube.com/",
                Geslacht = "vrouw",
                AwardId = 2,
                GeboorteDatum = new DateTime(1995, 5, 5, 0, 0, 0),
                Key = "fgdiuhksjnfivkj",
                IsActive = true,
                Foto = "http://www.merkur-online.de/bilder/2009/05/21/309020/691084670-241757_1_mona_12842056_onlinebild-3K09.jpg"
            });
            //nominaties3
            context.Nominatie.AddOrUpdate(new Nominatie()
            {
                Voornaam = "Brecht",
                Naam = "Tourlousse",
                Email = "bramregelbrugge@gmail.com",
                Tel = "0479837774",
                Straat_Nr = "Andere straat 69",
                Gemeente = "Ieper",
                Postcode = "8900",
                Land = "België",
                Richting = context.Richting.Where(x => x.Naam == "New Media and Communication Technologie (NMCT)").FirstOrDefault(),
                Beschrijving = "Marshmallow sesame snaps wafer toffee soufflé donut. Danish unerdwear.com pie toffee topping gummies sweet. Dessert cake I love sweet jelly toffee. Gingerbread gummies jelly dessert chocolate bar. I love cupcake donut cake. Sesame snaps jelly I love sweet roll marzipan halvah sesame snaps donut sweet. Donut gummies carrot cake. Cotton candy caramels lemon drops danish gingerbread. Cake candy canes gummies. Tart tart jelly-o cookie oat cake oat cake soufflé chupa chups. Jelly unerdwear.com oat cake marshmallow jelly-o cake I love. I love icing sweet roll I love marzipan jelly beans candy danish cake. I love chocolate bar marzipan topping soufflé oat cake jelly gummies tiramisu. Danish jelly beans jelly pastry chocolate bar sweet.",
                ExtraLinks = "https://www.youtube.com/",
                Geslacht = "man",
                AwardId = 3,
                GeboorteDatum = new DateTime(1994, 2, 19, 0, 0, 0),
                Key = "sdlknvsdjklnvjkdfjkvbx",
                IsActive = true,
                Foto = "https://lh6.googleusercontent.com/-LQsUpkPa0MM/AAAAAAAAAAI/AAAAAAAAACc/Z3zvOrSs5l8/photo.jpg"
            });
            context.Nominatie.AddOrUpdate(new Nominatie()
            {
                Voornaam = "Laura",
                Naam = "Lamont",
                Email = "bramregelbrugge@gmail.com",
                Tel = "0479837774",
                Straat_Nr = "Andere straat 69",
                Gemeente = "Ieper",
                Postcode = "8900",
                Land = "België",
                Richting = context.Richting.Where(x => x.Naam == "Toerisme en recreatiemanagement (TRM)").FirstOrDefault(),
                Beschrijving = "Cupcake marshmallow ice cream fruitcake biscuit dragée powder icing. Tiramisu tart sweet muffin ice cream. I love jelly donut. Jelly-o caramels bear claw cookie caramels chocolate cake tootsie roll gingerbread. Cupcake jujubes I love. Candy caramels liquorice chupa chups cookie ice cream jujubes. Gummies pastry sesame snaps I love I love tootsie roll apple pie. I love gingerbread cookie topping sweet roll I love pudding. Gingerbread marzipan I love sesame snaps lemon drops sweet marzipan. Toffee cake jelly beans I love I love I love. Pudding applicake soufflé jelly dragée cake. Toffee applicake wafer cheesecake tiramisu. Jujubes soufflé chocolate cake tootsie roll soufflé wafer I love. I love carrot cake I love jelly beans halvah topping gummi bears.",
                ExtraLinks = "https://www.youtube.com/",
                Geslacht = "vrouw",
                AwardId = 3,
                GeboorteDatum = new DateTime(1993, 8, 14, 0, 0, 0),
                Key = "sdvscvfxcv",
                IsActive = true,
                Foto = "http://www.rafvanderdonckt.be/genea/foto/huwelijkGeorges+Paula.jpg"
            });
            context.Nominatie.AddOrUpdate(new Nominatie()
            {
                Voornaam = "Sander",
                Naam = "De la Marche",
                Email = "bramregelbrugge@gmail.com",
                Tel = "0479837774",
                Straat_Nr = "Minister tacklaan 1",
                Gemeente = "Kortrijk",
                Postcode = "8500",
                Land = "België",
                Richting = context.Richting.Where(x => x.Naam == "New Media and Communication Technologie (NMCT)").FirstOrDefault(),
                Beschrijving = "Cookie soufflé danish. Cookie powder chocolate cake. Oat cake I love jujubes powder candy canes jelly-o tiramisu caramels. Candy candy cookie dragée wafer sweet roll jujubes. Gingerbread carrot cake caramels biscuit pastry. Oat cake powder cake lemon drops tart. Jelly-o chupa chups gummies muffin I love bear claw gummies. Muffin dessert bear claw oat cake dessert. Sesame snaps jelly beans I love chocolate I love chocolate bar. Brownie lollipop soufflé macaroon. Halvah sesame snaps tart gummies I love marshmallow lollipop. I love muffin jelly-o jelly chocolate cupcake wafer chocolate I love. Icing macaroon topping candy canes I love marshmallow ice cream. Danish dessert tart cotton candy.",
                ExtraLinks = "https://www.youtube.com/",
                Geslacht = "man",
                AwardId = 4,
                GeboorteDatum = new DateTime(1993, 3, 3, 0, 0, 0),
                Key = "fqjvbvkqbdf,",
                IsActive = true,
                Foto = "http://www.joe-english.be/img/leiding/sander.jpg"
            });
            context.Nominatie.AddOrUpdate(new Nominatie()
            {
                Voornaam = "Hannah",
                Naam = "Van Hove",
                Email = "bramregelbrugge@gmail.com",
                Tel = "0479837774",
                Straat_Nr = "Kendestraatniet 3",
                Gemeente = "Havere",
                Postcode = "9000",
                Land = "België",
                Richting = context.Richting.Where(x => x.Naam == "Journalistiek (JRN)").FirstOrDefault(),
                Beschrijving = "Muffin chocolate icing oat cake cookie lemon drops applicake jelly-o. Gummies applicake sweet roll brownie halvah gummies gingerbread. Gingerbread pudding jujubes applicake wafer toffee. Topping lemon drops candy cookie dragée toffee pudding muffin. Fruitcake cookie pie gummies muffin pudding ice cream. Topping bear claw sweet roll lemon drops sugar plum pie dessert dessert. Chupa chups applicake brownie danish wafer marzipan tootsie roll fruitcake. Icing liquorice liquorice applicake carrot cake tootsie roll. Lollipop tart jujubes halvah.",
                ExtraLinks = "https://www.youtube.com/",
                Geslacht = "vrouw",
                AwardId = 4,
                GeboorteDatum = new DateTime(1995, 11, 7, 0, 0, 0),
                Key = "sfdbsfgbfg,",
                IsActive = true,
                Foto = "http://cdn.bandmix.co.uk/bandmix_uk/media/10/10417/141512-p.jpg"
            });
            context.Nominatie.AddOrUpdate(new Nominatie()
            {
                Voornaam = "Lindsay",
                Naam = "Van Basselaere",
                Email = "bramregelbrugge@gmail.com",
                Tel = "0479837774",
                Straat_Nr = "Wilgenpark 5",
                Gemeente = "Eeklo",
                Postcode = "9991",
                Land = "België",
                Richting = context.Richting.Where(x => x.Naam == "Office Management (OM)").FirstOrDefault(),
                Beschrijving = "Biscuit sweet roll icing unerdwear.com jelly beans jelly beans dragée bonbon croissant. Sesame snaps caramels fruitcake croissant lollipop bear claw dragée. Marshmallow chocolate cake halvah brownie wafer sugar plum. Soufflé croissant chocolate cake fruitcake sweet roll chocolate cake. Dessert topping apple pie pudding candy canes chocolate bar bonbon. Powder macaroon cupcake chocolate chocolate bar dragée gummies candy ice cream. Sesame snaps brownie bonbon tart cupcake unerdwear.com sugar plum pudding gingerbread. Chupa chups bonbon pie donut dessert caramels. Wafer cookie jujubes chupa chups sugar plum.",
                ExtraLinks = "https://www.youtube.com/",
                Geslacht = "vrouw",
                AwardId = 4,
                GeboorteDatum = new DateTime(1996, 12, 16, 0, 0, 0),
                Key = "sdvddfv,",
                IsActive = true,
                Foto = "http://m.c.lnkd.licdn.com/mpr/pub/image-GNJ7b-QfazanPoHbl2uhS7l9QVVSZVIC-NOCSDCRQ6WGEs_dGNJCFG0fQyh-vIWeJV88/lindsay-van-basselaere.jpg"
            });
            context.Nominatie.AddOrUpdate(new Nominatie()
            {
                Voornaam = "Emma",
                Naam = "Watson",
                Email = "bramregelbrugge@gmail.com",
                Tel = "0479837774",
                Straat_Nr = "Engeland 4",
                Gemeente = "London",
                Postcode = "1000",
                Land = "UK",
                Richting = context.Richting.Where(x => x.Naam == "Office Management (OM)").FirstOrDefault(),
                Beschrijving = "Soufflé ice cream muffin lollipop cheesecake cupcake. Bonbon fruitcake tootsie roll soufflé danish macaroon brownie. Gummies danish marshmallow biscuit lollipop gingerbread jelly brownie chupa chups. Cheesecake tootsie roll bonbon icing chocolate chocolate oat cake. Tootsie roll lollipop soufflé wafer pudding pudding lollipop. Ice cream soufflé pastry sugar plum. Cake gummi bears soufflé bear claw gummi bears toffee chocolate cake. Chocolate cake brownie danish caramels. Croissant gingerbread biscuit cheesecake jujubes applicake. Halvah tiramisu candy canes gummi bears lollipop applicake soufflé.",
                ExtraLinks = "https://www.youtube.com/",
                Geslacht = "vrouw",
                AwardId = 4,
                GeboorteDatum = new DateTime(1900, 4, 15, 0, 0, 0),
                Key = "fdgsdjygs,",
                IsActive = true,
                Foto = "http://www.miley-cyruss.com/wp-content/uploads/2014/05/emma-watson-3.jpg"
            });

            //public int ID { get; set; }
            //public String Voornaam { get; set; }
            //public String Naam { get; set; }
            //public String Email { get; set; }
            //public String Tel { get; set; }
            //public String Straat_Nr { get; set; }
            //public String Gemeente { get; set; }
            //public String Postcode { get; set; }
            //public String Land { get; set; }
            //public String RichtingId { get; set; }
            //public virtual Richting Richting { get; set; }
            //public String Beschrijving { get; set; }
            //public String ExtraLinks { get; set; }
            //public String Geslacht { get; set; }
            //public int AwardId { get; set; }
            //public virtual Award Award { get; set; }
            //public DateTime GeboorteDatum { get; set; }
            //public String Key { get; set; }
            //public Boolean IsActive { get; set; }
            context.SaveChanges();




        }
    }
}
