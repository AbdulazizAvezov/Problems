using Imtihon;
using System.ComponentModel.Design;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

public class Program
{
  
    public static void Main(string[] args)
    {
        int[] nums = { 1, 2, 3 };
        var number = Tuple.Create
            (
            1,
            3,
            nums,
            Tuple.Create(1, 2),
            Tuple.Create("Item bir", "Itims iki")
            );

        Console.WriteLine( number.Item5.ToValueTuple() );
       
    }
}
