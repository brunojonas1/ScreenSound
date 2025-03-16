class Music
{
    public Music(Band artist, string songName)
    {
        ArtistName = artist;
        SongName = songName;
    }

    public string SongName { get; }
    public Band ArtistName { get; }
    public double Duration { get; set; }
    public string ShortDescription => $"The song {SongName} belongs to the band {ArtistName.Name}";

    public void DisplayTechnicalSheet()
    {
        Console.WriteLine($"Song Name: {SongName}");
        Console.WriteLine($"Artist Name: {ArtistName.Name}");
        Console.WriteLine($"Duration: {Duration} minutes\n");
    }
}
