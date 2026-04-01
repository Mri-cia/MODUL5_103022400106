
<<<<<<< HEAD

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
public class SimpleDataBase<T>
{
    List<T> storedData { get; set; }
    List<DateTime> inputDates { get; set; }

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine($"Data { i + 1 } berisi: { storedData[i] }, yang disimpan pada waktu UTC: { inputDates[i] }");
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
        SimpleDataBase<int> intDataBase = new SimpleDataBase<int>();
        intDataBase.AddNewData(10);
        intDataBase.AddNewData(60);
        intDataBase.AddNewData(22);
        intDataBase.PrintAllData();
    }
}