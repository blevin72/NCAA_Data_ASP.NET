using System;
namespace NCAA_Data
{
    public class Base
    {
        public string StatCat { get; set; }
        public int Year { get; set; }
        public string Conference { get; set; }
        public string Season { get; set; }
        //public string StatType { get; set; }

        //public virtual void GetParameters()
        //{
        //    StatCat = "";

        //    Console.WriteLine("Which year would you like to see stats for?");
        //    Year = int.Parse(Console.ReadLine());

        //    Console.WriteLine("What conference would you like to see a list of players from?");
        //    Conference = Console.ReadLine();

        //    Console.WriteLine("Which season would you like to see: regular, postseason, or both?");
        //    Season = Console.ReadLine();
        //}
        //public abstract Task DisplayStatistics();
    }
}