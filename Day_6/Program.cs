using System;

    static void VendingMachine(int change)
    {
        int[] notes = new int[] { 1000, 500, 100, 50, 10, 5,2, 1 };
        int[] num = new int[8];

    
    for (int i = 0; i < 8; i++)
        {
            if (change >= notes[i])
            {
            num[i] = change / notes[i];
            change -= num[i] * notes[i];
            }
        }

        Console.WriteLine("Minimum Notes required");
        for (int i = 0; i < 8; i++)
        {
            if (num[i] != 0)
            {
                Console.WriteLine(notes[i] + " : "
                    + num[i]);
            }
        }
    }

        int change = Convert.ToInt32(Console.ReadLine());
        VendingMachine(change);






