class Program
{
    static void Main(String[] args)
    {
        PemrosesData data = new PemrosesData();
        Console.WriteLine(data.DapatkanNilaiTerbesar<long>(10, 30, 20));
    }
}



class PemrosesData
{
    public T DapatkanNilaiTerbesar<T>(T nilai1 , T nilai2 , T nilai3)
    { 
        dynamic n1 = nilai1;    
        dynamic n2 = nilai2;    
        dynamic n3 = nilai3;
        dynamic highTemp = nilai1;

        if (n2 > highTemp)
        { 
            highTemp = n2;  
        }
        if (n3 > highTemp)
        {
            highTemp = n3;
        }
        return highTemp;
    }
}

