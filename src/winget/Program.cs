using System.Diagnostics;

var exe = Path.Combine(
    Path.GetDirectoryName(AppContext.BaseDirectory)!,
    "winget-tui", "winget-tui.exe");

if (!File.Exists(exe))
{
    Console.Error.WriteLine($"winget-tui.exe not found at: {exe}");
    return 1;
}

var psi = new ProcessStartInfo(exe) { UseShellExecute = false };
foreach (var arg in args)
    psi.ArgumentList.Add(arg);

var process = Process.Start(psi) ?? throw new InvalidOperationException("Failed to start winget-tui.exe");

process.WaitForExit();
return process.ExitCode;