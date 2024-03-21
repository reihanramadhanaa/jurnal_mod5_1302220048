using static System.Runtime.InteropServices.JavaScript.JSType;

public class Penjumlahan
{
    public static T JumlahTigaAngka<T>(T data1,T data2,T datta3) 
    { 
       

       return (dynamic)data1 + (dynamic)data2 + (dynamic)datta3;
    
    }


}

class Program 
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Penjumlahan.JumlahTigaAngka<int>(13, 02, 00));
        
    }
}