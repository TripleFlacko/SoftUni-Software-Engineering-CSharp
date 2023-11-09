using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        var bulletPrice = int.Parse(Console.ReadLine());
        var gunBarrel = int.Parse(Console.ReadLine());

        var bullets = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
        var bulletsStartAmount = bullets.Count;
        var bulletsShot = 0;

        var locks = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
        var value = int.Parse(Console.ReadLine());

        var locksAmount = locks.Count;

        for (int i = 0; i < locksAmount; i++)
        {
            var currentLock = locks.Peek();
            var currentBullet = bullets.Peek();
            if (currentBullet <= currentLock)
            {
                locks.Dequeue();
                bullets.Pop();
                bulletsShot++;
                Console.WriteLine("Bang!");
            }
            else
            {
                bullets.Pop();
                bulletsShot++;
                i--;
                Console.WriteLine("Ping!");

            }
            if (bulletsShot % gunBarrel == 0 && bullets.Count > 0)
            {
                Console.WriteLine("Reloading!");
            }
            if (bullets.Count == 0 & locks.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
                return;
            }
        }
        Console.WriteLine($"{bulletsStartAmount - bulletsShot} bullets left. Earned ${value - bulletsShot * bulletPrice}");
    }
}