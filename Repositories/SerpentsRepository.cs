




namespace snakeChart.Repositories;
public class SerpentsRepository
{
    private List<Serpent> _serpents;
    public SerpentsRepository()
    {
        _serpents = [
            new Serpent(1, "Detriment", 3, true, true, true, "Boise"),
            new Serpent(2, "Torin", 5, true, true, true, "San Diego"),
            new Serpent(3, "Angelic", 10, true, true, true, "Telluride")
        ];
    }

    internal Serpent CreateSerpent(Serpent serpentData)
    {
        Serpent lastSerpent = _serpents[_serpents.Count - 1];
        if (lastSerpent == null)
        { serpentData.Id = 1; }
        else
        {
            serpentData.Id = lastSerpent.Id + 1;
        }
        _serpents.Add(serpentData);
        return serpentData;
    }

    internal void DestroySerpent(Serpent serpent)
    {
        _serpents.Remove(serpent);
    }

    // internal Serpent EditSerpent(Serpent serpentData)
    // {
    //     _serpents.Find.Edit(serpentData);
    // }

    internal Serpent GetSerpentById(int serpentId)
    {
        Serpent foundSerpent = _serpents.Find(serpent => serpent.Id == serpentId);
        return foundSerpent;
    }

    internal List<Serpent> GetSerpents()
    {
        return _serpents;
    }
}