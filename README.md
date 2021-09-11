# What tools are there?
Currently there's two tools in this repository.

## Launcher
The launcher is a very simple tool, that is just there to launch the ghidra via the batch-file.
I use it simply to pin ghidra to the taskbar.

## HeadlessGUI
The HeadlessGUI is a simple GUI tool that provides the bare minimum to utilize the `analyzeHeadless.bat`.
After reading about the `analyzeHeadless.bat` in [this](https://kiwidog.me/2021/07/analysis-of-large-binaries-and-games-in-ghidra-sre/) article by KIWIDOG, I wanted to try it out, but did not want to keep remembering the command line flags.

So I created this minimalistic GUI application that lets you use the "Import" and "Analyze" functionality of the batch-file.
This appeared to improve the time it takes for ghidra to decompile/analyze a binary drastically.

# Installation
## Launcher
Just put the exe in the same folder as the `ghidraRun.bat`.
In my case, for example, `I:\Software\ghidra_10.0.3_PUBLIC_20210908\ghidra_10.0.3_PUBLIC`.

## HeadlessGUI
Put the exe anywhere you want.
Set up the path to the `support` directory. In my case, that's here: `I:\Software\ghidra_10.0.3_PUBLIC_20210908\ghidra_10.0.3_PUBLIC\support`.
Next browse to your project-folder. That's the folder where the projects `*.gpr` file is stored.

For example, I have a Project called `General` in `H:\Reversing`. In `H:\Reversing` I should have a `General.gpr` and a folder `General.rep`.
Once set up, it'll get all the available Projects in `H:\Reversing` and also read (if possible) all files that are part of that specific project.

With the `Import`-Button you can add a new file you want to disassemble/analyze to this project.
For example: I want to disassemble/analyze `notepad.exe` and that should be added to the `General`-project, I'd select the `General` Project, click on `Import`, navigate to the `notepad.exe` and add it. This will add & analyze the file.

Note: You can **NOT** have the `General` project oben in Ghidra itself, otherwise the project will be locked.

The `Analyze` button seems to just re-analyze the selected project/file.
