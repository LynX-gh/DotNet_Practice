string ipv4Input = "255.255.255";

bool ValidateLength()
{
    string[] address = ipv4Input.Split('.');
    return address.Length == 4;
}
bool ValidateZeroes()
{
    string[] address = ipv4Input.Split('.');

    foreach (string num in address)
        if(num.Length > 1 && num.StartsWith("0"))
            return false;

    return true;
}
bool ValidateRange()
{
    string[] address = ipv4Input.Split(".");

    foreach (string num in address)
    {
        int val = 0;
        if (int.TryParse(num, out val))
        {
            if (val < 0 && val > 255)
                return false;
        }
        else
            return false;
    }
    return true;
}

if (ValidateLength() && ValidateZeroes() && ValidateRange())
{
    Console.WriteLine($"{ipv4Input} is a valid IPv4 address");
}
else
{
    Console.WriteLine($"{ipv4Input} ip is an invalid IPv4 address");
}