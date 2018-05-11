// Static Classes
public static class Conversions
{
   public static double PoundsToKilos(double pounds)
   {
      // Convert argument from pounds to kilograms
      double kilos = pounds * 0.4536;
      return kilos;
   }
   public static double KilosToPounds(double kilos)
   {
      // Convert argument from kilograms to pounds
      double pounds = kilos * 2.205;
      return pounds;
   }
}