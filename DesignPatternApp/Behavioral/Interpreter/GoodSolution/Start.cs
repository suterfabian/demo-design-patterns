namespace ch.px.designpattern.Behavioral.Interpreter.GoodSolution;

public static class Start
{
    public static void Run()
    {
        Console.WriteLine("Interpreter - Good Solution");

        //var input1 = "1 + 2 * 3";

        //var context1 = new Context();
        //Interpreter interpreter = new Interpreter(context1);
        //var result = interpreter.Interpret(input1);
        //Console.WriteLine($"Result: {result}");

        var input2 = "5 + 2 - 3";

        var context2 = new Context();
        Interpreter2 interpreter2 = new Interpreter2(context2);
        var result2 = interpreter2.Interpret(input2);
        Console.WriteLine($"Result: {result2}");
    }
}
