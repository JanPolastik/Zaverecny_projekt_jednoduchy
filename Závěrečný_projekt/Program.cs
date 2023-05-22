using Závěrečný_projekt;

SpravaPojistenych sprava = new SpravaPojistenych();
char volba = '0';
while (volba != '5')
{
    sprava.VypisUvodniObrazovku();
    Console.WriteLine();
    Console.WriteLine("Vyberte si akci:");
    Console.WriteLine("1 - Přidat nového pojištěného");
    Console.WriteLine("2 - Vypsat všechny pojištěné");
    Console.WriteLine("3 - Vyhledat pojištěného");
    Console.WriteLine("4 - Vymazat pojištěného");
    Console.WriteLine("5 - konec");
    volba = Console.ReadKey().KeyChar;
    Console.WriteLine();

    switch (volba)
    {
        case '1':
            sprava.PridejPojisteneho();
            break;
        case '2':
            sprava.VypisPojistene();
            break;
        case '3':
            sprava.VyhledejPojistene();
            break;
        case '4':
            sprava.VymazPojistene();
            break;
        case '5':
            Console.WriteLine("Zavřete stisknutím libovolné klávesy");
            break;
        default:
            Console.WriteLine("Neplatná volba, stiskněte klávesu a opakujte volbu");
            break;
    }
    Console.ReadKey();
}