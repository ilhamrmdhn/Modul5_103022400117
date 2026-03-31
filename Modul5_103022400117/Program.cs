class PemrosesData
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
    static void Main(string[] args)
    {
        PemrosesData data = new PemrosesData();
        int semB = data.DapatkanNilaiTerbesar(10, 30, 22);
        Console.WriteLine("Nilai terbesar adalah: " + semB);
    }
}