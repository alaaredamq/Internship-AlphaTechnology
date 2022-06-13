namespace Design_Pattern_Exercices.Facade; 

public class Credit {
    public bool HasGoodCredit(Customer c) {
        Console.WriteLine("Check credit for " + c.Name);
        return true;
    }
}