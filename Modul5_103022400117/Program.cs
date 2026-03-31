class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        DateTime currentTime = DateTime.Now;
        inputDates.Add(currentTime);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine($"Data {i + 1} berisi: {storedData[i]}, yang disimpan pada waktu: {inputDates[i]}");
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        SimpleDataBase<int> data = new SimpleDataBase<int>();
        data.AddNewData(10);
        data.AddNewData(20);
        data.AddNewData(30);
        data.PrintAllData();
    }
}