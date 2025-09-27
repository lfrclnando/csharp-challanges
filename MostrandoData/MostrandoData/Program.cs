string tracos = new string('-', 10);
string tracosMedios = new string('-', 10);

Console.WriteLine($"{tracos} MOSTRANDO A DATA EM DIFERENTES FORMATOS {tracos}\n");

DateTime now = DateTime.Now;

Console.WriteLine($"Data atual: {now}");

Console.WriteLine($"1. Data atual (Formato Completo): {now.ToString("F")}");
Console.WriteLine($"2. Data atual (Formato Curto. Apenas Data): {now.ToShortDateString()}");
Console.WriteLine($"3. Hora atual (formato personalizado. Apenas Hora): {now:HH:mm:ss}");
Console.WriteLine($"4. Data atual (formato personalizado. Apenas Data com mês por Extenso): {now:dd MMMM yyyy}");

Console.WriteLine($"\n{tracosMedios} MOSTRANDO MAIS UM POUCO... {tracosMedios}\n");

Console.WriteLine($"Data atual (formato longo): {now.ToLongDateString()}");
Console.WriteLine($"Data atual (formato RFC1123): {now.ToString("R")}");
Console.WriteLine($"Data atual (formato universal): {now.ToUniversalTime()}");
Console.WriteLine($"Data atual (formato universal - string): {now.ToString("u")}");
Console.WriteLine($"Data atual (formato personalizado 1): {now.ToString("dd/MM/yyyy HH:mm:ss")}");
Console.WriteLine($"Data atual (formato personalizado 2): {now:dd/MM/yyyy HH:mm:ss}"); // Interpolação com formato
Console.WriteLine($"Data atual (formato personalizado 3): {now:dddd, dd 'de' MMMM 'de' yyyy}"); // Interpolação com formato e texto literal
Console.WriteLine($"Data atual (formato personalizado 4): {now:yyyy-MM-ddTHH:mm:ss.fffK}"); // Formato ISO 8601
