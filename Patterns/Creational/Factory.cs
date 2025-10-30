using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Patterns.Creational
{
    public class Controller : IEngine
    {

        public string Render(string filename, Dictionary<string, object> model)
        {
            return CreateEngine().Render(filename, model);
        }

        public virtual IEngine CreateEngine()
        {
            return new BladeEngine();
        }

    }

    public interface IEngine
    {
        string Render(string filename, Dictionary<string, object> model);
    }

    public class BladeEngine : IEngine
    {
        public string Render(string filename, Dictionary<string, object> model)
        {
            // Implementation for rendering a Blade template
            return $"Rendering {filename} with Blade engine.";
        }
    }

    public class TwigEngine : IEngine
    {
        public string Render(string filename, Dictionary<string, object> model)
        {
            // Implementation for rendering a Twig template
            return $"Rendering {filename} with Twig engine.";
        }
    }

    // this is where the magic happens the client who uses this controller knows hes getting a Twig engine but doesnt know how the internal state is tweaked so that he is gettin a twig engine
    public class TwigController : Controller
    {
        public override IEngine CreateEngine()
        {
            return new TwigEngine();
        }
    }

}



// Controller controller = new Controller();
// string result = controller.Render("view.blade.php", new Dictionary<string, object>());
// Console.WriteLine(result);
// Controller twigController = new TwigController();
// string twigResult = twigController.Render("view.twig.php", new Dictionary<string, object>());
// Console.WriteLine(twigResult);