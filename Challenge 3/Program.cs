using System;
using System.Collections.Generic;

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

            Console.WriteLine(map);
        }
    }
}
