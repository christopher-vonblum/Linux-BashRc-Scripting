#!/home/anon/bin/DotnetScriptRunner/DotnetScriptRunner

var scripts = Directory.GetFiles(args[0]);

Console.WriteLine("Scripts dir: " + scripts);

string bashrcDefinitions = "";

foreach (string filePath in scripts)
{
    string fileName = Path.GetFileName(filePath);
    if (fileName.EndsWith(".sh") && !fileName.StartsWith("-"))
    {
        string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
        
        Console.WriteLine("Generating definition for" + fileName);
        
        bashrcDefinitions +=
"\n" + fileNameWithoutExtension + "() {\n"
+ "    cd ~/bin/scripts\n" 
+ "    ./" + fileName + "\n}\n";
    }
}

File.WriteAllText("bashrc-definitions", bashrcDefinitions);
