internal class Program
{
    private static void giaiPTBac2(float a, float b, float c)
    {
        if (a == 0)
        {
            if (b == 0)
            {
                Console.Write("Phuong trinh vo nghiem!");
            }
            else
            {
                Console.Write("Phuong trinh co mot nghiem: x = {0}", (-c / b));
            }
            return;
        }
    }          
    static void Main(string[] args)
    {
        float a, b, c;
        Console.Write("Nhap he so bac 2, a = ");
        String valA = Console.ReadLine();
        a = Convert.ToInt32(valA);
        Console.Write("Nhap he so bac 1, b = ");
        string valB = Console.ReadLine();
        b = Convert.ToInt32(valB);
        Console.Write("Nhap he so bac 0, c = ");
        string valC = Console.ReadLine();
        giaiPTBac2(a, b, c);
    }
}