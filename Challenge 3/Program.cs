using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Challenge_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var map = new Dictionary<char, Dictionary<char, Dictionary<char, char>>>();
            map.Add('x', new Dictionary<char, Dictionary<char, char>>()
            {
            { 'y',
            new Dictionary<char, char>()
            {
            { 'z', 'a'}
            }}
            });
            Console.WriteLine("Enter the Key");
            var key = Console.Read();
            Console.WriteLine(NestedPrint(map,(char) key));
        }
        static string NestedPrint(Dictionary<char, Dictionary<char, Dictionary<char, char>>> dict, char key)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in dict)
            {
                if (item.Key == key && item.Value is Dictionary<char, Dictionary<char, char>>)
                {
                    sb = item.Value.SelectMany(n => n.Value.Select(o => n.Key + ":" + o.Key + ":" + o.Value))
                    .Aggregate(new StringBuilder(), (current, next) => current.Append(next).Append(", ")); ;
                }
                else
                {
                    foreach (var data in item.Value)
                    {
                        if (data.Key == key)
                        {
                            sb = data.Value.Select(x => x.Key + ":" + x.Value)
                            .Aggregate(new StringBuilder(), (current, next) => current.Append(next).Append(", "));
                        }
                        else
                        {
                            foreach (var innerIetm in data.Value)
                            {
                                if (innerIetm.Key == key)
                                {
                                    sb = data.Value.Select(x => x.Value).Aggregate(new StringBuilder(), (current, next) => current.Append(next).Append(", "));
                                }
                            }
                        }
                    }
                }
            }
            if (sb.Length > 1)
                sb.Remove(sb.Length - 2, 2);
            return sb.ToString();
        }
    }
}
