namespace Sorting_Objects;

	public class Human
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

        public bool CompareTo(object? obj)
        {
            Human other = obj as Human;

            return this.Height > other.Height;
        }
    }
