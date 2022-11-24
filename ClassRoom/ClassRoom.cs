namespace ClassRoom;

public class ClassRoom
{
    private Pupil[] _pupils = {};

    public ClassRoom(Pupil pupil)
    {
        Pupil[] pupils = { pupil };

        _pupils = pupils;
    }
    
    public ClassRoom(Pupil pupil1, Pupil pupil2)
    {
        Pupil[] pupils = { pupil1, pupil2 };

        _pupils = pupils;
    }
    
    public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
    {
        Pupil[] pupils = { pupil1, pupil2, pupil3 };

        _pupils = pupils;
    }

    public void GetMetrics()
    {
        foreach (var pupil in _pupils)
        {
            pupil.Read();
            pupil.Write();
            pupil.Relax();
            pupil.Study();
            
            Console.WriteLine($"Knowledge level: {pupil.KnowledgeLevel}; Tired level {pupil.TiredLevel}");
        }
    }
}