using System;

class Program
{
    static void Main(string[] args)
    {
        var reference = new ScriptureReference("John 3:16");
        var text = new ScriptureText("For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        var program = new ScriptureProgram(reference, text);

        program.Run();
    }
}