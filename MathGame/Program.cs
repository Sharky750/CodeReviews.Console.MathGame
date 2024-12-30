
    Console.WriteLine("Select the game");
    Console.WriteLine("1. Osszeadas");
    Console.WriteLine("2. Kivonas");
    Console.WriteLine("3. Szorzas");
    Console.WriteLine("4. Osztas");

    string menuselect = Console.ReadLine();

    int score = 0;

switch (menuselect)
    {


        case "1":
            OsszeadasGame();
            break;

        case "2":
            KivonasGame();
            break;

        case "3":
            SzorzasGame();
            break;

        case "4":
            OsszeadasGame();
            break;


    }



    void OsszeadasGame()
    {

        

        Random rnd = new Random();

        int a = rnd.Next(1, 100);

        int b = rnd.Next(1, 100);


        Console.WriteLine($"Mennyi?-> {a} + {b} = ?");



        int osszeadasAnswer = Convert.ToInt32(Console.ReadLine());

        if (osszeadasAnswer == (a + b))
        {
            score++;
            Console.WriteLine($"Fasza vagy more, tudsz számolni, az eredményed: {score}");

        OsszeadasGame();        

        }
        else
        {
            Console.WriteLine($"Hát ez nem jött össze,  az eredményed: {score}");
        }



    }


    void KivonasGame()
    {

        Random rnd = new Random();

        int a = rnd.Next(1, 100);

        int b = rnd.Next(1, 100);


        Console.WriteLine($"Mennyi?-> {a} - {b} = ?");

        int osszeadasAnswer = Convert.ToInt32(Console.ReadLine());

        if (osszeadasAnswer == (a - b))
        {
        score++;
        Console.WriteLine($"Fasza vagy more, tudsz számolni, az eredményed: {score}");

        KivonasGame();

    }
        else
        {
        Console.WriteLine($"Hát ez nem jött össze,  az eredményed: {score}");
    }



    }




    void SzorzasGame()
    {

        Random rnd = new Random();

        int a = rnd.Next(1, 100);

        int b = rnd.Next(1, 100);


        Console.WriteLine($"Mennyi?-> {a} * {b} = ?");

        int osszeadasAnswer = Convert.ToInt32(Console.ReadLine());

        if (osszeadasAnswer == (a * b))
        {
        score++;
        Console.WriteLine($"Fasza vagy more, tudsz számolni, az eredményed: {score}");

        SzorzasGame();

    }
        else
        {
        Console.WriteLine($"Hát ez nem jött össze,  az eredményed: {score}");
    }



    }



    void OsztasGame()
    {

        Random rnd = new Random();

        int a = rnd.Next(1, 100);

        int b = rnd.Next(1, 100);


        Console.WriteLine($"Mennyi?-> {a} / {b} = ?");

        int osszeadasAnswer = Convert.ToInt32(Console.ReadLine());

        if (osszeadasAnswer == (a / b))
        {
        score++;
        Console.WriteLine($"Fasza vagy more, tudsz számolni, az eredményed: {score}");

        OsztasGame();

    }
        else
        {
        Console.WriteLine($"Hát ez nem jött össze,  az eredményed: {score}");
    }



    }
