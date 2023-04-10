using System.Diagnostics;

class PR_Lab4
{
    static void Main(string[] args)
    {
        int childArg = 0;
        if (args.Length > 0)
            childArg = int.Parse(args[0]);

        if (childArg > 0)
        {
            var newProc = new ProcessStartInfo("PR_Lab4.exe");
            newProc.Arguments = (childArg - 1).ToString();
            newProc.UseShellExecute = true;
            Process.Start(newProc);
        }
        for (int i = 0; i < 1000; i++)
            Console.WriteLine(i);
    }
}