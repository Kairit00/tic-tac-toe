using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tre_i_rad
{
    public class Util
        //              Utitlity klass som tar hand om själva inputen till menyn, reset programmet.
    {
        public static void ResetProgram(Action input) // Generic Reset Method
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to go back to the Main Menu");
            Console.ReadKey();
            Console.Clear();
            input.Invoke(); // Invoke the passed in Reset Method
        }

        // läser in radeno ch försöker parsa inmatningssträngen till ett lämpligt generiskt värde av T value
        public static T? ReadLine<T>(Func<string, string>? inputModifier = null) // Valfri funktiuon för att ändra inmatningssträngen
        {
            var input = Console.ReadLine(); // Läser in inmatningssträngen
            if (input == null) // Kollar om det är null
            {
                return default; // Om det är null, returnera default
            }
            if (inputModifier != null)
            {
                input = inputModifier.Invoke(input);
            }
            if (typeof(T) == typeof(string)) // Om T är en sträng, returnera bara inmatningen
            {
                return (T)(object)input;
            }
            try // Försöker hämta TypeConverter, konvertera den från String till T type med hjälp av Type Converter och returnera antingen default eller T
            {
                TypeConverter converter = TypeDescriptor.GetConverter(typeof(T));
                // Kasta ConvertFromString(string text) : object to (T)
                return (T)converter.ConvertFromString(input);
            }
            catch (NotSupportedException)
            {
                return default;
            }
        }
    }
}
