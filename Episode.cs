class Episode
{
    private List<string> guests = new();

    public Episode(string title, int duration, int order)
    {
        Title = title;
        Duration = duration;
        Order = order;
    }

    public string Title { get; }
    public int Duration { get; }
    public int Order { get; }
    public string Summary => $"Episode {Order} - {Title} - Duration: {Duration} minutes - " +
        $"Guests: {string.Join(", ", guests)}";

    public void AddGuest(string guest)
    {
        guests.Add(guest);
    }

    public void DisplayEpisodeSummary()
    {
        Console.WriteLine($"{Summary} \n");
    }
}
