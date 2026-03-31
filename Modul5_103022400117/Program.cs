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
        
﻿class PemrosesData
{
    public T DapatkanNilaiTerbesar<T>(T satu, T dua, T tiga)
    {
        dynamic sem1 = (dynamic) satu;
        dynamic sem2 = (dynamic) dua;
        dynamic sem3 = (dynamic) tiga;
        dynamic semB = (dynamic) sem1;

        if (sem2 > semB)
        {
            semB = sem2;
        }

        if (sem3 > semB)
        {
            semB = sem3;
        }

        return semB;
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
        
        PemrosesData data = new PemrosesData();
        int semB = data.DapatkanNilaiTerbesar(10, 30, 22);
        Console.WriteLine("Nilai terbesar adalah: " + semB);
    }
}