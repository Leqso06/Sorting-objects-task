using System.Diagnostics;

namespace Sorting_Objects
{
	public class Human : IComparable
	{
		public Human(string name, double height)
		{
			Name = name;
			Height = height;
		}

		public string Name { get; }
		public double Height { get; }

        public override string ToString()
        {
            return $"{Name} - {Height: 0.00}";
        }

        public int CompareTo(object? obj)
        {
            Human other = obj as Human;

            if (this.Height > other.Height)
            {
                return 1;
            }
            return -1;
        }
    }
}

