namespace LambadaExpressions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LambadaExpressions
    {
        public static void Main()
        {
            var lambadaExpressions = new Dictionary<string, Dictionary<string, string>>();
            var inputLine = Console.ReadLine();

            while (!inputLine.Equals("lambada"))
            {
                var inputLineArguments = inputLine.Split(new[] { ' ', '=', '>', '.' }, StringSplitOptions.RemoveEmptyEntries);

                if (inputLineArguments.Length > 1)
                {
                    var selector = inputLineArguments[0];
                    var selectorObject = inputLineArguments[1];
                    var property = inputLineArguments[2];

                    if (!lambadaExpressions.ContainsKey(selector))
                    {
                        lambadaExpressions.Add(selector, new Dictionary<string, string>());
                    }

                    lambadaExpressions[selector][selectorObject] = property;
                    Console.WriteLine("{0} => {0}.{1}", selectorObject, property);
                }

                else
                {
                    lambadaExpressions = lambadaExpressions
                        .ToDictionary(selector => selector.Key, selector => selector.Value
                        .ToDictionary(selectorObject => selectorObject.Key, selectorObject => selectorObject.Key + "."  + selectorObject.Value));
                }
          
                inputLine = Console.ReadLine();
            }

            foreach (var selector in lambadaExpressions)
            {
                foreach (var selectorObject in selector.Value)
                {
                    Console.WriteLine("{0} => {1}.{2}", selector.Key, selectorObject.Key, selectorObject.Value);
                }
            }
            //lambadaExpressions
            //    .ToList()
            //    .ForEach(selector => selector.Value
            //    .ToList()
            //    .ForEach(selectorObject => Console.WriteLine("{0} => {1}.{2}", selector.Key, selectorObject.Key, selectorObject.Value)));

        }
    }
}
