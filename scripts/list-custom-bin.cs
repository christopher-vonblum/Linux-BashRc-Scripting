#!/home/anon/bin/DotnetScriptRunner/DotnetScriptRunner

string[] scripts = Directory.GetFiles("/home/anon/bin/scripts");

foreach (string filePath in scripts)
{
    string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath);
        
    Console.WriteLine(fileNameWithoutExtension);
}
