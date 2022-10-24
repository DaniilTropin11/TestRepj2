using System;

class gamekosti 
{
    static void Main(string[] args)
    {
        Random dice = new Random();
        int rol1 = dice.Next(1, 7);
        int rol2 = dice.Next(1, 7);
        int rol3 = dice.Next(1, 7);
        int total = rol1 + rol2 + rol3;
        Console.WriteLine($"Сумма трех костей= {rol1} + {rol2} + {rol3} = {total}");

        if ((rol1 == rol2) || (rol2 == rol3) || (rol1 == rol3))
        {
            Console.WriteLine("Попадание + 2 бонусных очка ! ");
            total += 2;
        }

        if ((rol1 == rol2) && (rol2 == rol3))
        {
            Console.WriteLine("КРУПНОЙ ПОПАДАНИЕ + 6 БОНУСНЫХ ОЧКОВ!");
            total += 6;
        }

        if (total < 15)
        {
            Console.WriteLine("ПРОИГРЫШ!");
        }
        if (total >= 15) 
        {
            Console.WriteLine("ВЫИГРЫШ!");
        }
    }    
}
