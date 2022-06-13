namespace Design_Pattern_Exercices.Iterator;

public interface IAbstractIterator {
    Item First();
    Item Next();
    bool IsDone { get; }
    Item CurrentItem { get; }
}