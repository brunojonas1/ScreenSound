class Album
{
    private List<Music> songs = new List<Music>();

    public Album(string albumName)
    {
        AlbumName = albumName;
    }

    public string AlbumName { get; }
    public double TotalAlbumDuration => songs.Sum(m => m.Duration);

    public void AddSong(Music song)
    {
        songs.Add(song);
    }

    public void DisplayAlbumSongs()
    {
        Console.WriteLine($"Song list of the album {AlbumName}:\n");

        foreach (var song in songs)
        {
            Console.WriteLine($"Song name: {song.SongName}");
        }
        Console.WriteLine($"Total album duration: {TotalAlbumDuration} minutes\n");
    }
}
