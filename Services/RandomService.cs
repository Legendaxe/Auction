namespace Auction.Services;

public class RandomService : IRandomService
{
    private readonly Random _random = new Random();
    
    public double RandomDouble()
    {
        return _random.NextDouble();
    }
}