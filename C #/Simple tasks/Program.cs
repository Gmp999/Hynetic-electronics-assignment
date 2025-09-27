// ABSTRACT CLASS
//abstract class IGolgumbi
//{
//    public virtual void qutub(string maga) { }


//}
//class Golgumbi1 : IGolgumbi
//{
//    public override void qutub(string maga)
//    {
//        Console.WriteLine("This is Indian " + maga);
//    }
//}

//class Golgumbi2 : IGolgumbi
//{
//    public override void qutub(string maga)
//    {
//        Console.WriteLine("This Indian " + maga);
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        IGolgumbi goli = new Golgumbi1();
//        goli.qutub("TajMahal");
//        IGolgumbi goli1 = new Golgumbi2();
//        goli1.qutub("Qutub");
//    }
//}

// INTERFACES no need to override

interface ICar
{
    public void sound(string maga);

}

class Golgumbi1 : ICar
{
    public void sound(string maga)
    {
        Console.WriteLine("This is Indian " + maga);
    }
}

class Golgumbi2 : ICar
{
    public void sound(string maga)
    {
        Console.WriteLine("This Indian " + maga);
    }
}
class Program
{
    static void Main(string[] args)
    {
        ICar goli = new Golgumbi1();
        goli.sound("Varoom");
        ICar goli1 = new Golgumbi2();
        goli1.sound("Baroom");
    }
}
