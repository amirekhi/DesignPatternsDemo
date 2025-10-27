// See https://aka.ms/new-console-template for more information

using DesignPatternsDemo.Patterns.Creational;

Controller controller = new Controller();
string result = controller.Render("view.blade.php", new Dictionary<string, object>());
Console.WriteLine(result);
Controller twigController = new TwigController();
string twigResult = twigController.Render("view.twig.php", new Dictionary<string, object>());
Console.WriteLine(twigResult);