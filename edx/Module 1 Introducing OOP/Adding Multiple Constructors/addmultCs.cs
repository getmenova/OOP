// Adding Multiple Constructors
public class DrinksMachine
{
   public int Age { get; set; }
   public string Make { get; set; }
   public string Model { get; set; }
   public DrinksMachine(int age)
   {
      this.Age = age;
   }
   public DrinksMachine(string make, string model)
   {
      this.Make = make;
      this.Model = model;
   }
   public DrinksMachine(int age, string make, string model)
   {
      this.Age = age;
      this.Make = make;
      this.Model = model;
   }
}