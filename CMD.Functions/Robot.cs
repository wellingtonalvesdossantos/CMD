using CMD.Functions.Extensions;
using System;

namespace CMD.Functions
{
    public class Robot
    {
        public string EmitGreetings()
        {
            var hour = DateTime.Now.Hour;
            if (hour.IsBetween(0, 5))
                return "Boa madrugada";
            else if (hour.IsBetween(6, 11))
                return "Bom dia";
            else if (hour.IsBetween(12, 17))
                return "Boa tarde";
            else
                return "Boa noite";
        }
    }
}
