using Week03.PatternsLab.Attributes;

namespace Week03.PatternsLab.Models;

public class User
{
    [MaxLengthNo(10)]
    public string Name { get; set; } = "";
}