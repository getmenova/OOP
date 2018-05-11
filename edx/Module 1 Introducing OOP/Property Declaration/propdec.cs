public class DrinksMachine
{
   // private member variables
   private int age;
   private string make;


   // public properties
   public int Age
   {
      get
      {
         return age;
      }
      set
      {
         age = value;
      }
   }
   public string Make
   {
      get
      {
         return make;
      }
      set
      { 
         make = value;
      }
   }
   
   // auto-implemented property
   public string Model { get; set; }

      // Constructors
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