// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to snake Ladder Game!");
int p1sp = 0;
//int p2sp = 0;
Random random = new Random();
int diecount=random.Next(1,7);






Random rand = new();
int dieroll1 = 0, dieroll2 = 0;
while (dieroll1 < 100 && dieroll2 < 100)
    switch (rand.Next(0, 3))
    {
        case 0:
            Console.WriteLine("No Play");


            break;
        case 1:
            Console.WriteLine("Ladder");
            //Console.WriteLine(dieroll1 +=1);
            Console.WriteLine(p1sp += diecount ); 
            dieroll1++;

            break;
        case 2:
            Console.WriteLine("Snake");
            //Console.WriteLine(dieroll2 += 1);
            Console.WriteLine(p1sp -= diecount);
            dieroll2++;
            break;

    }

