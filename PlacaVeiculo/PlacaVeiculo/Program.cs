using System.Text.RegularExpressions;

string tracos = new string('-', 10);

Console.WriteLine($"{tracos} VALIDANDO PLACA DE VEÍCULOS (Padrão LLLNNNN) {tracos}\n");

Console.Write("Digite a placa do veículo. Ex.: ABC1234: ");
string carPlate = Console.ReadLine().ToUpper().Trim();

string carPlatePattern = @"^[A-Z]{3}[0-9]{4}$";

bool carPlateIsValid = Regex.IsMatch(carPlate, carPlatePattern);

Console.WriteLine("\n-------------------------------------------");
Console.WriteLine($"Placa digitada: {carPlate}\n");
Console.WriteLine($"Placa (Padrão LLLNNNN) válida? ");

// Exibe "Verdadeiro" ou "Falso" conforme o resultado booleano
Console.WriteLine(carPlateIsValid ? "Sim" : "Não");
Console.WriteLine("-------------------------------------------");