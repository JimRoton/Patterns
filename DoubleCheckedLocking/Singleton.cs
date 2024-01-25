namespace DoubleCheckedLocking;

public class Singleton
{
    // Declare the instance as volatile to prevent compiler optimizations
    private static volatile Singleton? instance;
    
    // Use a static object for locking
    private static FileWriter fw = new FileWriter(".\\MyFile.txt");

    // Make the constructor private to prevent direct instantiation
    private Singleton()
    {
    }

    // Use a public static property to access the instance
    public static Singleton Instance
    {
        get
        {
            // Check if the instance is null before locking
            if (instance == null)
            {
                // Lock on the fw object
                lock (fw)
                {
                    // Check if the instance is null again after locking
                    if (instance == null)
                    {
                        // Create a new instance
                        instance = new Singleton();
                    }
                }
            }
            // Return the instance
            return instance;
        }
    }
}
