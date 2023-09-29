using System.Diagnostics;
using System.Collections.Generic;
/* get processes and id process */
Process[] ps = Process.GetProcesses();
foreach(Process process in ps)
{
    Console.WriteLine($"App Process Name: [{process.ProcessName}] and pid: [{process.Id}]");
}
Console.WriteLine("------------------------------------");

Console.WriteLine("Press Enter.....");
Console.ReadKey();