class Podcast
{
    private List<Episode> episodes = new List<Episode>();

    public Podcast(string host, string name)
    {
        HostPodcast = host;
        PodcastName = name;
    }

    public string HostPodcast { get; }
    public string PodcastName { get; }
    public int TotalEpisodes { get; set; }

    public void DisplayPodcast()
    {
        Console.WriteLine($"Podcast Name: {PodcastName}");
        Console.WriteLine($"Host: {HostPodcast}");
        Console.WriteLine($"Total episodes: {TotalEpisodes}\n");
    }

    public void DisplayHost()
    {
        Console.WriteLine($"This podcast {PodcastName} is hosted by {HostPodcast}\n");
        foreach (var episode in episodes)
        {
            Console.WriteLine($"{episode.Summary}\n");
        }
        Console.WriteLine($"This podcast has: {TotalEpisodes} episodes\n");
    }

    public void AddEpisode(Episode episode)
    {
        episodes.Add(episode);
    }
}
