namespace ClassRoom;

public class ExcelentPupil: Pupil
{
    protected override SkillLevel _read()
    {
        var rand = new Random();
        
        if (rand.Next(0, 10) > 9)
        {
            return SkillLevel.Bad;
        }
        
        return SkillLevel.Normal;
    }
    
    protected override SkillLevel _write()
    {
        if (TiredLevel > 20)
        {
            return SkillLevel.Bad;
        }
        
        return SkillLevel.Normal;
    }
    
    protected override SkillLevel _study()
    {
        if (TiredLevel > 25)
        {
            return SkillLevel.Bad;
        }
        
        return SkillLevel.Normal;
    }
    
    protected override SkillLevel _relax()
    {
        var rand = new Random();
        
        if (TiredLevel < 18)
        {
            return SkillLevel.Bad;
        }
        
        return SkillLevel.Normal;
    }
}