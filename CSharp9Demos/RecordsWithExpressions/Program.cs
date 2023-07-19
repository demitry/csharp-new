namespace RecordsWithExpressions
{
    public record Color
    {
        public Color(string name, bool isMetallic)
        {
            Name = name;
            IsMetallic = isMetallic;
        }
        public Color(){ }

        public string Name { get; set; }
        public bool IsMetallic { get; set; }
    }

    public record Car
    {
        public Color Color { get; set; }
        public string Engine { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car myFirstCar = new() 
            { 
                Color = new() { Name = "Black", IsMetallic = false }, 
                Engine = "V6" 
            };

            Car upgradedCar = myFirstCar with { Engine = "V8" }; 
            // car - cloned and modified
            // Shallow copy! Unfortunately!

            upgradedCar.Color.IsMetallic = true; // Both cars are metallic now!

            Console.WriteLine(myFirstCar);
            Console.WriteLine(upgradedCar);
            //Car { Color = Color { Name = Black, IsMetalic = True }, Engine = V6 }
            //Car { Color = Color { Name = Black, IsMetalic = True }, Engine = V8 }

            // The reason: "with" = Clone() = shallow copy with references to the Color, 
            // Upgraded car refers to the same Color object.

            // Need Deep copy? - implement Prototype pattern, Serialization/De-serialization
            // Deep Copy is hard => MS didn't it.
        }
    }
}