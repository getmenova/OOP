// Invoking the Dispose Method in a finally Block
var word = default(ManagedWord);
try
{
   word = new ManagedWord();
   // Code to use the ManagedWord object.
}
catch
{
    // Code to handle any errors.
}
finally
{
   if(word!=null)
      word.Dispose();
}
