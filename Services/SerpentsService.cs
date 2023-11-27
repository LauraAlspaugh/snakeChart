




namespace snakeChart.Services;
public class SerpentsService
{
    private readonly SerpentsRepository _serpentsRepository;
    public SerpentsService(SerpentsRepository serpentsRepository)
    {
        _serpentsRepository = serpentsRepository;
    }

    internal Serpent CreateSerpent(Serpent serpentData)
    {
        Serpent serpent = _serpentsRepository.CreateSerpent(serpentData);
        return serpent;
    }

    internal string DestroySerpent(int serpentId)
    {
        Serpent serpent = GetSerpentById(serpentId);
        _serpentsRepository.DestroySerpent(serpent);
        return "this serpent has gone to the grave";
    }

    internal Serpent EditSerpent(Serpent serpentData, int serpentId)
    {
        Serpent serpent = GetSerpentById(serpentId);
        // _serpentsRepository.EditSerpent(serpentData);
        serpent.Name = serpentData.Name;
        serpent.Age = serpentData.Age;
        serpent.WillKill = serpentData.WillKill;
        serpent.CanReadMind = serpentData.CanReadMind;
        serpent.CanFly = serpentData.CanFly;
        serpent.Home = serpentData.Home;
        return serpent;
    }

    internal Serpent GetSerpentById(int serpentId)
    {
        Serpent serpent = _serpentsRepository.GetSerpentById(serpentId);
        return serpent;
    }

    internal List<Serpent> GetSerpents()
    {
        List<Serpent> serpents = _serpentsRepository.GetSerpents();
        return serpents;
    }
}