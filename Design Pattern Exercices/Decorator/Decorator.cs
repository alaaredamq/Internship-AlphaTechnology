namespace Design_Pattern_Exercices.Decorator; 

public abstract class Decorator : LibraryItem {
    protected LibraryItem libraryItem;

    public Decorator(LibraryItem libraryItem) {
        this.libraryItem = libraryItem;
    }

    public override void Display() {
        libraryItem.Display();
    }
}