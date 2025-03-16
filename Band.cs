class Band
{
    private List<Album> albums = new List<Album>();

    public Band(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public void AddAlbum(Album album)
    {
        albums.Add(album);
    }

    public void DisplayAlbums()
    {
        Console.WriteLine($"Album list of the band {Name}:\n");

        foreach (var album in albums)
        {
            Console.WriteLine($"Album name: {album.AlbumName} with duration of ({album.TotalAlbumDuration} minutes)\n");
        }
    }
}
