using System;
using System.Collections.Generic;

public static class Telefono
{

    public static string Check(string[] inputStr)
    {
        foreach(string input in inputStr)
        {
            if(input.StartsWith("0039") )
            {
                if(input.Length==14)
                    return input;
            }
            
            else if(input.StarstWith("+39") )
            {
                if(input.Length==13)
                    return input;
            }
            
            else if(input.StartsWith("3") )
            {
                Int64 valore = 0;
                bool eUnNumero = Int64.TryParse(input, out valore);
                if(eUnNumero)
                    if(input.Length == 10)
                        return input;
            }
        }
        return "";
    }
}
