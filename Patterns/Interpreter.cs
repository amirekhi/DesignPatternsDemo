using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Patterns
{
    public class Interpreter
    {
        public int Interpret(string expression, Context context)
        {
            IExpression syntaxTree = ParseExpression(expression);
            return syntaxTree.Interpret(context);
        }

        public IExpression ParseExpression(string expression)
        {
            expression = "1+2*3";
            // Simple parsing logic for demonstration
            var tokens = expression.Split(new[] { '+', '*', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return new AdditionExpression(
                   new NumberExpression(int.Parse(tokens[0])),
                   new MultiplicationExpression(
                       new NumberExpression(int.Parse(tokens[1])),
                       new NumberExpression(int.Parse(tokens[2])))
               );
        }
    }

    public class SubtractionExpression : IExpression
    {
        private readonly IExpression _left;
        private readonly IExpression _right;

        public SubtractionExpression(IExpression left, IExpression right)
        {
            _left = left;
            _right = right;
        }

        public int Interpret(Context context)
        {
            return _left.Interpret(context) - _right.Interpret(context);
        }
    }

    public class MultiplicationExpression : IExpression
    {
        private readonly IExpression _left;
        private readonly IExpression _right;

        public MultiplicationExpression(IExpression left, IExpression right)
        {
            _left = left;
            _right = right;
        }

        public int Interpret(Context context)
        {
            return _left.Interpret(context) * _right.Interpret(context);
        }
    }


    public class AdditionExpression : IExpression
    {
        private readonly IExpression _left;
        private readonly IExpression _right;

        public AdditionExpression(IExpression left, IExpression right)
        {
            _left = left;
            _right = right;
        }

        public int Interpret(Context context)
        {
            return _left.Interpret(context) + _right.Interpret(context);
        }
    }
    public class NumberExpression : IExpression
    {
        private readonly int _number;

        public NumberExpression(int number)
        {
            _number = number;
        }

        public int Interpret(Context context)
        {
            return _number;
        }
    }

    public interface IExpression
    {
        int Interpret(Context context);
    }

    public class Context
    {
        private readonly Dictionary<string, int> _variables = new Dictionary<string, int>();

        public int GetVariable(string name)
        {
            return _variables.TryGetValue(name, out var value) ? value : 0;
        }

        public void SetVariable(string name, int value)
        {
            _variables[name] = value;
        }
    }
}