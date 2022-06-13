namespace Design_Pattern_Exercices.Strategy; 

public class ShellSort : SortStrategy {
    public override void Sort(List<string> list) {
        Console.WriteLine("ShellSorted list ");
    }
}