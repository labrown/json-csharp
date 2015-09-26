
public class Config
{
    public Settings settings { get; set; }
    public Image[] images { get; set; }
}

public class Settings
{
    public string server { get; set; }
    public string path { get; set; }
}

public class Image
{
    public string id { get; set; }
    public string operatingsystem { get; set; }
    public int major { get; set; }
    public int minor { get; set; }
}
