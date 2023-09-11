namespace Program;

using Point;

public class Cercle
{
    private double r;

    public Cercle(double r)
    {
        this.r = r;
    }
    

    public double R()
    {
        return this.r;
    }

    public bool IsIn(Point point)
    {
        return point.Distance() <= r;
    }
}