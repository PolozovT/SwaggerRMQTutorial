using System.Collections.Generic;

namespace SwaggerRMQEx
{
    public class SampleValues
    {
        public static List<string> Values;

        public static void Init()
        {
            Values = new List<string>();
            Values.Add("zero");
            Values.Add("first");
            Values.Add("second");
            Values.Add("third");
        }
    }
}
