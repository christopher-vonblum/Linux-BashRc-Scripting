#!/usr/bin/cs-script

string[] scripts = Directory.GetFiles("/home/anon/bin/scripts");

string bashrcDefinitions = "";

foreach (string filePath in scripts)
{
    string fileName = Path.GetFileName(filePath);
    string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);

    Console.WriteLine("Generating definition for: " + fileName);

    bashrcDefinitions +=
    "\n" + fileNameWithoutExtension + "() {\n"
    + "    ~/bin/scripts/" + fileName + "\n}\n";
}

File.WriteAllText("/home/anon/bin/bashrc-definitions", bashrcDefinitions);
