namespace Week01.Day05.Concepts;

public class Playlist
{
    private readonly string[] songs =
    {
        "Believer",
        "Faded",
        "Alone"
    };

    // Integer Indexer
    public string this[int index]
    {
        get
        {
            if (index >= 0 && index < songs.Length)
                return songs[index];

            return "Invalid Index";
        }
    }

    // String Indexer
    public char this[string text, int index]
    {
        get
        {
            if (index >= 0 && index < text.Length)
                return text[index];

            return '\0';
        }
    }
}