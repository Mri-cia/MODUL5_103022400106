
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
    public static void Main()
    {
        SimpleDataBase<int> intDataBase = new SimpleDataBase<int>();
        intDataBase.AddNewData(10);
        intDataBase.AddNewData(60);
        intDataBase.AddNewData(22);
        intDataBase.PrintAllData();
    }
}