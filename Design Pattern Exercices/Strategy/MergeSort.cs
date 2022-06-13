namespace Design_Pattern_Exercices.Strategy; 

public class MergeSort : SortStrategy {
    public override void Sort(List<string> list) {
        Console.WriteLine("MergeSorted list ");
    }
}