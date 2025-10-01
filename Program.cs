// See https://aka.ms/new-console-template for more information

using DesignPatternsDemo.Patterns;

Interpreter interpreter = new Interpreter();
Context context = new Context();
int result = interpreter.Interpret("1 + 2 * 3", context);
Console.WriteLine($"Result: {result}");
