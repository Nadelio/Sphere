using Sphere.Lexer;

namespace Sphere.Parsers.AST;

public partial class Expressions
{
    public record Comment : Node
    {
        public Comment(string file, int line, int col) : base(file, line, col)
        {
            base.Type = $"Expressions+{this.GetType().Name}";
        }
        public override string ToString() => "Comment";
    }
}