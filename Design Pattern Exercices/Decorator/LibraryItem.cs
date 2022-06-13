namespace Design_Pattern_Exercices.Decorator; 

public abstract class LibraryItem {
    private int numCopies;

    public int NumCopies {
        get { return numCopies; }
        set { numCopies = value; }
    }

    public abstract void Display();
}