namespace snakeChart.Models;
public class Serpent
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public bool CanFly { get; set; }
    public bool WillKill { get; set; }
    public bool CanReadMind { get; set; }
    public string Home { get; set; }

    public Serpent(int id, string name, int age, bool canFly, bool willKill, bool canReadMind, string home)
    {
        Id = id;
        Name = name;
        Age = age;
        CanFly = canFly;
        WillKill = willKill;
        CanReadMind = canReadMind;
        Home = home;
    }
}