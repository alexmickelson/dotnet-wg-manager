using System.Diagnostics;
using System.Text.RegularExpressions;

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
var psi = new ProcessStartInfo();
// /etc/sudoers.d/custom
// alex ALL = (root) NOPASSWD: /usr/bin/systemctl restart wg-quick@home


psi.FileName = "systemctl";
psi.Arguments = "status wg-quick@home";
psi.RedirectStandardOutput = true;
psi.RedirectStandardError = true;

Process proc = new Process
{
  StartInfo = psi
};


proc.Start();

string error = proc.StandardError.ReadToEnd();

if (!string.IsNullOrEmpty(error))
  Console.WriteLine("error: " + error);

string output = proc.StandardOutput.ReadToEnd();



proc.WaitForExit();

// Console.WriteLine(output);

var statusPattern = @"Active: (?<status>\S*)\s";

var matches = Regex.Matches(output, statusPattern);
var status = matches[0].Groups[1];
Console.WriteLine(status);




Console.WriteLine("end");

// runtime security
// https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/linux-nginx?view=aspnetcore-6.0