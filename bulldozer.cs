using System;

namespace bulldozer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			var dozer = new Bulldozer ("Yellow", "Mini" );

			var dozer2 = new Bulldozer ("Red", "Large");

			Console.WriteLine("Bulldozer1 is " + dozer.color);
			Console.WriteLine("Bulldozer2 is " + dozer2.color);
        }
    }
    public class Bulldozer
	{
		public Bulldozer (string _color, string _size) {
			this.color = _color;
			this.size = _size;
		}

		public string color { get; set; }
		public string size { get; set; }
	}
}