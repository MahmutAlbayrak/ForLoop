internal class Program
{
    private static void Main(string[] args)
    {
        //Ekrandan girilen sayiya kadar olan tek sayilari ekrana yazdirir.
        Console.WriteLine("Lutfen bir sayi giriniz: ");
        int sayac = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= sayac; i++)
        {
            if(i%2 ==1)
                Console.WriteLine(i);
        }

        //1 ile 1000 arasindaki tek ve cift sayilarin kendi icerisindeki toplamlarini ekrana yazdirir.
        int tekToplam=0;
        int ciftToplam=0;
        for (int i = 1; i <= 1000; i++)
        {
            if(i%2 == 1)
                tekToplam += i;
            else
                ciftToplam += i;
        }
        Console.WriteLine("Tek sayilarin toplami: "+ tekToplam);
        Console.WriteLine("Cift sayilarin toplami: "+ ciftToplam);

        // break, continue
        for (int i = 1; i < 10; i++)
        {
            if(i ==4)
                break;
            Console.WriteLine(i);
        }

        for (int i = 1; i < 10; i++)
        {
            if(i ==4)
                continue;
            Console.WriteLine(i);
        }
    }
}