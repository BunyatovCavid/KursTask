List<string> countries = new List<string> { "Albania", "Azerbaycan", "Ingiltere", "Turkiye", "Kanada", "Andorra", "Amerika", "Hindistan" };

string sampleNews = "As sowftware developers, the natural tendency is to start developing applications based on your own hands-on experience" +
    " and knowledge right away.However, overtime issue in the application arise, adaptations to changes, and new features happen.";


Console.WriteLine("Task 1");
CheckCount(countries);
Console.WriteLine();
Console.WriteLine("Task 2");
CheckStartEnd(countries);
Console.WriteLine();
Console.WriteLine("Task 3");
CheckSpace(sampleNews);

void CheckCount(List<string> countries)
{
   bool check = CheckSymbol(countries);
    if (check)
    {
        foreach (var item in countries)
        {
            Console.WriteLine($"{item} - {item.Count()}");
        }
    }
}

void CheckStartEnd(List<string> countries)
{
   bool check = CheckSymbol(countries);
    if (check)
    {
        foreach (var item in countries)
        {
            if (item.ToLower().StartsWith('a') && item.ToLower().EndsWith('a'))
                Console.WriteLine(item);
        }
    }
}

void CheckSpace(string sampleNews)
{
    bool check = CheckSymbol(countries);
    if (check)
    {
        int i = 0;
        foreach (var item in sampleNews)
        {
            if (item == 32)
                i++;
        }
        Console.WriteLine($"Number of spaces in your sentence: {i}");
    }
}

bool CheckSymbol(List<string> countries)
{
    bool check = true;
    bool number = false;
    bool symbol = false;

    for (int i = 0; i < countries.Count; i++)
    {
        foreach (var item in countries[i])
        {
            if (Char.IsNumber(item))
                number = true;
            else if (Char.IsPunctuation(item))
                symbol = true;
            if (number)
            {
                Console.WriteLine("You cannot use a number");
                break;
            }
            else if(symbol)
            {
                Console.WriteLine("You cannot use a punctuation mark");
                break;
            }
        }
        if (number || symbol)
        {
            check = false;
            break;
        }
    }
    return check;
}