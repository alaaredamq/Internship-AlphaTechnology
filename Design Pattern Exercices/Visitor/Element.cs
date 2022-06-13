namespace Design_Pattern_Exercices.Visitor;

public abstract class Element {
    public abstract void Accept(IVisitor visitor);
}