using System;
using System.Diagnostics;

namespace CmdNoWin {
    internal static class Program {
        [STAThread]
        static int Main() {
            var cmdargs = "";
            var cmdline = Environment.CommandLine;
            if (cmdline.StartsWith("\"")) {
                var endq = cmdline.IndexOf('"', 1);
                if (endq <= 1)
                    return 1;
                cmdargs = cmdline.Substring(endq + 1);
            } else {
                for (int i = 1; i < cmdline.Length; i++) {
                    if (char.IsWhiteSpace(cmdline[i])) {
                        cmdargs = cmdline.Substring(i + 1);
                        break;
                    }
                }
            }
            cmdargs = cmdargs.Trim();
            if (string.IsNullOrWhiteSpace(cmdargs))
                return 1;

            var psi = new ProcessStartInfo() {
                FileName = "cmd.exe",
                Arguments = $"/c \"{cmdargs}\"",
                UseShellExecute = false,
                CreateNoWindow = true
            };

            Debug.WriteLine($"CmdArgs: {psi.Arguments}");

            var p = Process.Start(psi);
            p.WaitForExit();
            return p.ExitCode;
        }
    }
}
