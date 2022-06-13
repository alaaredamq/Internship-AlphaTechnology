namespace Design_Pattern_Exercices.Visitor;

public class Program {
    public static void Main(string[] args) {
        Employees employee = new Employees();
        employee.Attach(new Clerk());
        employee.Attach(new Director());
        employee.Attach(new President());

        employee.Accept(new IncomeVisitor());
        employee.Accept(new VacationVisitor());

        Console.ReadKey();
    }
}