// Screen Sound

string welcomeMessage = "Welcome to Screen Sound!";

Dictionary<string, List<int>> bandList = new Dictionary<string, List<int>>();
Dictionary<string, List<int>> musicList = new Dictionary<string, List<int>>();

void DisplayLogo()
{
    Console.WriteLine(welcomeMessage);

    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
}

void DisplayMenuOptions()
{
    Console.WriteLine("\n1 - Register a new band");
    Console.WriteLine("2 - Register a new song");
    Console.WriteLine("3 - List registered bands or songs");
    Console.WriteLine("4 - Rate a band or song");
    Console.WriteLine("5 - Check average ratings");
    Console.WriteLine("6 - Exit");

    Console.Write("\nEnter the number of the desired option: ");
    string chosenOption = Console.ReadLine();
    int numericChosenOption = int.Parse(chosenOption);

    switch (numericChosenOption)
    {
        case 1:
            Console.WriteLine("Registering a new band...");
            RegisterBand();
            break;
        case 2:
            Console.WriteLine("Registering a new song...");
            RegisterSong();
            break;
        case 3:
            Console.WriteLine("Listing registered bands or songs...");
            ListBandsSongs();
            break;
        case 4:
            Console.WriteLine("Rating a band or song...");
            RateBandSong();
            break;
        case 5:
            Console.WriteLine("Calculating average rating...");
            CalculateAverage();
            break;
        case 6:
            Console.WriteLine("Exiting...");
            break;
        default:
            Console.WriteLine("Invalid option");
            break;
    }
}

void RegisterBand()
{
    Console.Clear();
    Interface("Band Registration");

    Console.Write("Enter the band's name: ");
    string bandName = Console.ReadLine()!;
    bandList.Add(bandName, new List<int>());
    Console.WriteLine($"Band {bandName} successfully registered!");
    Console.Clear();
    DisplayMenuOptions();
}

void RegisterSong()
{
    Console.Clear();
    Interface("Song Registration");

    Console.Write("Enter the song's name: ");
    string songName = Console.ReadLine()!;
    musicList.Add(songName, new List<int>());
    Console.WriteLine($"Song {songName} successfully registered!");
    Console.Clear();
    DisplayMenuOptions();
}

void ListBandsSongs()
{
    Console.Clear();

    Console.WriteLine("\n1 - List registered bands");
    Console.WriteLine("2 - List registered songs");
    Console.WriteLine("3 - Return to main menu");
    Console.Write("\nEnter the number of the desired option: ");

    string chosenListOption = Console.ReadLine();
    int numericChosenOption = int.Parse(chosenListOption);

    Interface("Listing Bands or Songs");
    if (bandList.Count == 0 && musicList.Count == 0)
    {
        Console.WriteLine("No bands or songs registered");
    }
    switch (numericChosenOption)
    {
        case 1:
            Console.Clear();
            Interface("Band Listing");

            if (bandList.Count == 0)
            {
                Console.WriteLine("No bands registered");
            }
            foreach (string band in bandList.Keys)
            {
                Console.WriteLine($"Band: {band}");
            }
            Console.WriteLine("\nPress any key to return to the main menu");
            Console.ReadKey();
            DisplayMenuOptions();
            break;
        case 2:
            Console.Clear();
            Interface("Song Listing");

            if (musicList.Count == 0)
            {
                Console.WriteLine("No songs registered");
            }
            foreach (string song in musicList.Keys)
            {
                Console.WriteLine($"Song: {song}");
            }
            Console.WriteLine("\nPress any key to return to the main menu");
            Console.ReadKey();
            Console.Clear();
            DisplayMenuOptions();
            break;
        case 3:
            Console.Clear();
            DisplayMenuOptions();
            break;
        default:
            Console.WriteLine("Invalid option");
            break;
    }
}

void Interface(string text)
{
    int letterCount = text.Length;
    string line = string.Empty.PadLeft(letterCount, '*');
    Console.WriteLine(line);
    Console.WriteLine(text);
    Console.WriteLine(line + "\n");
}

void RateBandSong()
{
    Console.Clear();

    Interface("Rating a Band or Song");
    Console.WriteLine("Enter the name of the band or song you want to rate: ");

    string bandSongName = Console.ReadLine()!;
    if (bandList.ContainsKey(bandSongName))
    {
        Console.Write("Enter the band's rating: ");
        int bandRating = int.Parse(Console.ReadLine()!);
        bandList[bandSongName].Add(bandRating);
        Console.WriteLine($"Band {bandSongName} successfully rated!");
    }
    else if (musicList.ContainsKey(bandSongName))
    {
        Console.Write("Enter the song's rating: ");
        int songRating = int.Parse(Console.ReadLine()!);
        musicList[bandSongName].Add(songRating);
        Console.WriteLine($"Song {bandSongName} successfully rated!");
    }
    else
    {
        Console.WriteLine("Band or song not found");
    }
    Console.WriteLine("\nPress any key to return to the main menu");
    Console.ReadKey();
    Console.Clear();
    DisplayMenuOptions();
}

void CalculateAverage()
{
    Interface("Average Rating Calculation");
    Console.Write("Enter the name of the band or song to calculate the average rating: ");
    string bandSongName = Console.ReadLine()!;
    if (bandList.ContainsKey(bandSongName))
    {
        if (bandList[bandSongName].Count == 0)
        {
            Console.WriteLine("The band has not been rated yet");
        }
        else
        {
            double bandAverage = bandList[bandSongName].Average();
            Console.WriteLine($"Average rating for the band {bandSongName}: {bandAverage}");
        }
    }
    else if (musicList.ContainsKey(bandSongName))
    {
        if (musicList[bandSongName].Count == 0)
        {
            Console.WriteLine("The song has not been rated yet");
        }
        else
        {
            double songAverage = musicList[bandSongName].Average();
            Console.WriteLine($"Average rating for the song {bandSongName}: {songAverage}");
        }
    }
    else
    {
        Console.WriteLine("Band or song not found");
    }
}

// Podcast instance
Podcast podcast = new Podcast("BJM", "Music Podcast")
{
    TotalEpisodes = 10,
};

Episode episode1 = new Episode("Episode 1", 60, 1);
Episode episode2 = new Episode("Theme 2", 120, 2);
Episode episode3 = new Episode("Episode 3", 60, 3);

podcast.DisplayPodcast();
podcast.AddEpisode(episode1);
podcast.AddEpisode(episode2);
podcast.AddEpisode(episode3);

episode1.AddGuest("Guest 1");
episode2.AddGuest("Guest 2");
episode3.AddGuest("Guest 3");

podcast.DisplayHost();
