public class SimpleDataBase<T>
{
    private List<T> storeData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        this.storeData = new List<T>();
        this.inputDates = new List<DateTime>();

    }

    public void AddNewData(T data)
    {
        this.storeData.Add(data);
        this.inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        int i = 0;
        this.storeData.ForEach(data =>
        {
            i++;
            Console.WriteLine("Data " + i + " berisi: " + data + ", yang disimpan pada waktu UTC: " + this.inputDates[this.storeData.IndexOf(data)]);
        });
    }
}
    class Program
    {
        private static void Main(string[] args)
        {
           SimpleDataBase<int> data = new SimpleDataBase<int>();
           data.AddNewData(12);
           data.AddNewData(02);
           data.AddNewData(22);

           data.PrintAllData();

        }

    }






   
    
