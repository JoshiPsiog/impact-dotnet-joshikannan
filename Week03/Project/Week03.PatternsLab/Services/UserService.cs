namespace Week03.PatternsLab.Services;

public class UserService
{
    public async Task<string> FetchUserDataAsync(int userId)
    {
        Console.WriteLine($"Fetching User {userId}...");

        await Task.Delay(3000);

        Console.WriteLine($"Completed User {userId}");

        return $"User {userId} Data";
    }
}