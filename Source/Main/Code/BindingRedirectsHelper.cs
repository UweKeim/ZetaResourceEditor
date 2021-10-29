namespace ZetaResourceEditor.Code;

public static class BindingRedirectsHelper
{
    private static readonly IDictionary<string, Assembly> _additional =
        new ConcurrentDictionary<string, Assembly>();

    public static void Initialize()
    {
        Console.WriteLine(@"[BRH] Initializing BindingRedirectsHelper.");

        // --
        // http://stackoverflow.com/a/9180843/107625

        var successCount = 0;
        var failureCount = 0;
        var skipCount = 0;

        // Wenn in einer Webanwendung verwendet, stattdessen diese Zeile
        // hier verwenden:
        /*
        var dir = Path.Combine(System.Web.HttpRuntime.AppDomainAppPath, @"bin");
        */

        // Diese Zeile hier für eine Windows-/Konsolen-Anwendung.
        var dir = Path.GetDirectoryName(Assembly.GetEntryAssembly()?.Location);

        if (dir != null)
        {
            Console.WriteLine($@"[BRH] Reading assemblies from '{dir}'.");

            // Ausschließen von bestimmten Assemblies, von denen wir wissen, dass
            // sie keine managed assemblies sind.
            var ignores = new[]
            {
                @"assembly-1-to-ignore.dll",
                @"assembly-2-to-ignore.dll"
            };

            var assemblyNames = Directory.GetFiles(dir, @"*.dll");

            Console.WriteLine($@"[BRH] Processing {assemblyNames.Length} assemblies.");

            foreach (var assemblyName in assemblyNames)
            {
                var fileName = Path.GetFileName(assemblyName);
                if (ignores.Any(i => i.Equals(fileName, StringComparison.OrdinalIgnoreCase)))
                {
                    skipCount++;

                    Console.WriteLine($@"[BRH] Ignoring assembly '{assemblyName}' with file name '{fileName}'.");
                }
                else
                {
                    Console.WriteLine($@"[BRH] Processing assembly '{assemblyName}' with file name '{fileName}'.");

                    try
                    {
                        var assembly = Assembly.LoadFile(assemblyName);
                        _additional.Add(assembly.GetName().Name, assembly);

                        successCount++;

                        Console.WriteLine(
                            $@"[BRH] Successfully loaded '{assemblyName}' with file name '{fileName}'.");
                    }
                    catch (BadImageFormatException x)
                    {
                        // Ignorieren.

                        failureCount++;

                        Console.WriteLine(
                            $@"[BRH] Ignoring exception '{x.Message}' while trying to load '{assemblyName}' with file name '{fileName}'.");
                    }
                    catch (FileLoadException x)
                    {
                        // Ignorieren.

                        failureCount++;

                        Console.WriteLine(
                            $@"[BRH] Ignoring exception '{x.Message}' while trying to load '{assemblyName}' with file name '{fileName}'.");
                    }
                }
            }
        }
        else
        {
            Console.WriteLine(@"[BRH] NOT reading assemblies, because path is NULL.");
        }

        Console.WriteLine(
            $@"[BRH] Successfully loaded {successCount} assemblies, failed loading {failureCount} assemblies, skipped loading {skipCount} assemblies.");

        AppDomain.CurrentDomain.ReflectionOnlyAssemblyResolve += CurrentDomain_ResolveAssembly;
        AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_ResolveAssembly;

        Console.WriteLine(@"[BRH] Successfully subscribed to AppDomain events.");
    }

    private static Assembly CurrentDomain_ResolveAssembly(
        object sender,
        ResolveEventArgs e)
    {
        // Hier mache ich quasi mein eigenes, automatisches, Binding-Redirect.
        // (Z. B. Newtonsoft.Json 6.0.0.0 nach 9.0.0.0).

        var i = e.Name.IndexOf(',');
        if (i < 0) return null;

        var name = e.Name.Substring(0, i);

        var success = _additional.TryGetValue(name, out var res);

        Console.WriteLine(success
            ? $@"[BRH] Succeeded getting assembly with name '{name}', full name '{e.Name}'."
            : $@"[BRH] FAILED getting assembly with name '{name}', full name '{e.Name}'.");

        return res;
    }
}