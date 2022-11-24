namespace ClassRoom;

public abstract class Pupil
{
    private int _knowledgeLevel = 0;
    public int KnowledgeLevel
    {
        private set
        {
            if (value < 0)
            {
                _knowledgeLevel = 0;
                return;
            }

            _knowledgeLevel = value;
        }
        get { return _knowledgeLevel; }
    }

    private int _tiredLevel = 0;
    public int TiredLevel
    {
        private set
        {
            if (value < 0)
            {
                _knowledgeLevel = 0;
                return;
            }

            _knowledgeLevel = value;
        }
        get { return _tiredLevel; }
    }
    public enum SkillLevel
    {
        Bad,
        Normal,
        Excelent,
    }

    protected abstract SkillLevel _read();
    protected abstract SkillLevel _write();
    protected abstract SkillLevel _study();
    protected abstract SkillLevel _relax();

    public void Read()
    {
        var level = _read();

        switch (level)
        {
            case SkillLevel.Bad:
                _knowledgeLevel += 1;
                break;
            case SkillLevel.Normal:
                _knowledgeLevel += 2;
                break;
            case SkillLevel.Excelent:
                _knowledgeLevel += 3;
                break;
        }
        
        
        _tiredLevel += 2;
    }
    
    public void Write()
    {
        var level = _write();

        _knowledgeLevel += 1;
        
        if (level != SkillLevel.Excelent)
        {
            _tiredLevel += 3;
        }
    }
    
    public void Study()
    {
        var level = _study();
        var k = (20 / _tiredLevel);
        
        switch (level)
        {
            case SkillLevel.Bad:
                _knowledgeLevel += k;
                break;
            case SkillLevel.Normal:
                _knowledgeLevel += 2*k;
                break;
            case SkillLevel.Excelent:
                _knowledgeLevel += 3*k;
                break;
        }
        
        
        _tiredLevel += 5;
    }

    public void Relax()
    {
        var level = _read();

        switch (level)
        {
            case SkillLevel.Bad:
                TiredLevel -= 3;
                break;
            case SkillLevel.Normal:
                TiredLevel -= 5;
                break;
            case SkillLevel.Excelent:
                TiredLevel -= 10;
                break;
        }

        KnowledgeLevel -= 1;
    }
}