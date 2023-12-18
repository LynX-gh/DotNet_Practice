string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal temp;
string resStr = "";
decimal resInt = 0;
foreach (var value in values)
{
    if(decimal.TryParse(value, out temp)) 
        resInt += temp;
    else
        resStr += value;
}

Console.WriteLine(resStr);
Console.WriteLine(resInt);