namespace SfBugReports.Data;

public class Horse(string name, string breed, int age)
{
    public string Name { get; set; } = name;
    public string Breed { get; set; } = breed;
    public int Age { get; set; } = age;
}