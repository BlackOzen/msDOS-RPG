using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

public class ScenesTemplate
{
    private int vertical = 5;

    private int horizontal = 5;

    private bool runing = false;

    public ScenesTemplate() { }

    public void Setvertical(int vertical)
    {
        this.vertical = vertical;
    }

    public int Getvertical()
    {
        return this.vertical;
    }
    public void Sethorizontal(int horizontal)
    {
        this.horizontal = horizontal;
    }
    public int Gethorizontal()
    {
        return this.horizontal;
    }

    public void SetRuning(bool runing)
    {
        this.runing = runing;
    }
    public bool GetRuning()
    {
        return this.runing;
    }
}
