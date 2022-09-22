/*
    static void printBonusDatesBetween(int fromYear, int toYear)
    pvz. 2010, 2015
    Surasti visas datas tarp duotu metu, kurias galima skaityti vienodai is kaires ir desines.
    pvz 2001 10 02
 */
Console.Write("Iveskite metus nuo kuriu skaiciuoti : ");
int from = int.Parse(Console.ReadLine());

Console.Write("Iveskite metus iki kuriu skaiciuoti : ");
int to = int.Parse(Console.ReadLine());

printBonusDatesBetween(from, to);

static void printBonusDatesBetween(int fromYear, int toYear)
{   
    DateTime data = new DateTime(fromYear, 1, 1);
    string dataString;
    bool isItCorrect;
    while (int.Parse(data.ToString("yyyy")) != toYear)
    {        
        dataString = data.ToString("yyyyMMdd");
        isItCorrect = true;
        for (int i = 0; i < 4; i++)
        {
            if (!dataString[i].Equals(dataString[7 - i]))
            { 
                isItCorrect = false;
                break;
            }
        }
        if (isItCorrect)
        {
            Console.WriteLine(data.ToString("yyyy-MM-dd"));
        }
        data = data.AddDays(1);        
    }
}