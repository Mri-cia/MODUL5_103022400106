

public class PemrosesData<T> 
{ 
    public void DapatkanNilaiTerbesar(T param1, T param2, T param3) 
    {
        dynamic a = param1; 
        dynamic b = param2; 
        dynamic c = param3; 
 
        if (a >= b && a >= c) 
        { 
            Console.WriteLine($"Nilai terbesar adalah: {a}"); 
        } 
        else if (b >= a && b >= c) 
        { 
            Console.WriteLine($"Nilai terbesar adalah: {b}"); 
        } 
        else 
        { 
            Console.WriteLine($"Nilai terbesar adalah: {c}");
        }
    }
}

public class Program
{
    static int nilai1 = 10;
    static int nilai2 = 60;
    static int nilai3 = 22;
    public static void Main()
    {
        PemrosesData<int> pemroses = new PemrosesData<int>();
        pemroses.DapatkanNilaiTerbesar(nilai1, nilai2, nilai3);
    }
}