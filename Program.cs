namespace Labb5;

class Program
{
    // Theres Sundberg Selin .NET23
    static void Main()
    {
        // Skapar nya objekt av klasserna Circle och Triangle
        Circle circle1 = new(5);
        Circle circle2 = new(6);
        Triangle triangle1 = new(3, 5);
        Triangle triangle2 = new(2, 2);

        // Skriver ut objektens värden
        Console.WriteLine("Den första cirkelns area är " + circle1.GetArea());
        Console.WriteLine("Den andra cirkelns area är " + circle2.GetArea());
        Console.WriteLine("Den första triangelns area är " + triangle1.AreaTriangle());
        Console.WriteLine("Den andra triangelns area är " + triangle2.AreaTriangle());
        Console.WriteLine("Den första sfärens volym är " + circle1.GetVolumeSphere());
        Console.WriteLine("Den andra sfärens volym är " + circle2.GetVolumeSphere());

    }
}

//En klass för cirklarna 
class Circle
{

    // Deklaration av ett fält, det är satt till readonly för att den
    // behöver inte sättas, utan endast läsas
    private readonly int _radius;

    // En konstruktor för klassen Circle. Den sätter värdet radius när den
    // skapar objekten 
    public Circle(int radius)
    {
        _radius = radius;
    }


    // En metod för att räkna ut arean på cirklar genom att ta Pi
    // och multiplicera det med radius multiplicerad med radius,
    // returnerar sedan detta
    public double GetArea()
    {
        return Math.PI * _radius * _radius;
    }

    // En metod för att räkna ut volymen av sfärer genom att dividera
    // 4.0 med 3,multiplicera med Pi, multiplicera med radius upphöjt i 3,
    // returnerar sedan detta
    public double GetVolumeSphere()
    {

        double volume = 4.0 / 3 * Math.PI * Math.Pow(_radius, 3);
        return volume;
    }

}

// En klass för trianglarna
class Triangle
{
    private readonly int _triangleBase;
    private readonly int _triangleHeight;

    // En konstruktor för klassen triangle. Den sätter värdena för bas och höjd
    // i trianglarna när den skapar objekten
    public Triangle(int triangleBase, int triangleHeight)
    {
        _triangleBase = triangleBase;
        _triangleHeight = triangleHeight;
    }

    // En metod som räknas ut trianglars area genom att ta _triangleBase och
    // multiplicera med _triangleHeight och dividera det med 2, returnerar sedan detta
    public int AreaTriangle()
    {
        return _triangleBase * _triangleHeight / 2;
    }
}

