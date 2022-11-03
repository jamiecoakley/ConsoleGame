
public abstract class Suspect
{
    public Suspect()
    {
        
    }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Occupation { get; set; }
    public string Relationship { get; set; }
    public bool CriminalHistory { get; private set; }
    public bool IsGuilty { get; private set; }
}

