// Calling the Dispose Method from a Destructor
class ManagedWord
{
    ...
    // Destructor
    ~ManagedWord()
    {
        Dispose(false);
    }
}
