namespace Design_Pattern_Exercices.Memento;

public class ProspectMemory {
    Memento memento;

    public Memento Memento {
        set { memento = value; }
        get { return memento; }
    }
}