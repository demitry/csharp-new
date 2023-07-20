using Microsoft.CodeAnalysis;

namespace Generator
{
    [Generator]
    public class SimpleGenerator : ISourceGenerator

    {
        public void Execute(GeneratorExecutionContext context)
        {
            var source = @"class Foo { public string Bar = ""bar""; }";
            context.AddSource("FooGen.cs", source);
        }

        public void Initialize(GeneratorInitializationContext context)
        {

        }
    }
}
