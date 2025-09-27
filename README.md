# **💻 C\# Console Systems Collection**

This is a collection of small console projects written in C\#. These systems were primarily developed for **practice and demonstration of basic language concepts**, such as input/output handling, mathematical operations, date formatting, and using regular expressions.

## **🚀 How to Run the Projects**

These projects are standalone C\# source files (.cs) that can be executed individually in a C\# development environment (like Visual Studio, VS Code with the C\# Dev Kit, or using the dotnet run command in the terminal).

### **Prerequisites**

You must have the [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine.

### **Execution**

1. **Navigate** to the directory where the .cs file is saved (e.g., Program-Calculos.cs).  
2. **Open the terminal** in that directory.  
3. **Execute** the dotnet run command followed by the file name:  
   dotnet run Program-Calculos.cs

   or  
   dotnet run Program-Placa-Veiculos.cs

## **📂 Included Systems**

| File | Description | Main Functions |
| :---- | :---- | :---- |
| Program-Calculos.cs | Demonstrates the 5 basic mathematical operations: Addition, Subtraction, Multiplication, Division, and Average. | Data input (Console.ReadLine()), conversion (double.Parse()), and flow control (validation for division by zero). |
| Program-Nome.cs | Accepts and displays the user's first and last name. | Simple string manipulation, display, and user interaction. |
| Program-Digitar-Palavras.cs | Accepts a phrase or word, removes white spaces, and returns the total character count without spaces. | String manipulation (Replace(), Length) and input validation (string.IsNullOrWhiteSpace()). |
| Program-Mostrando-Datas.cs | Displays the current date and time in various formats (long, short, custom, RFC1123, universal). | Use of the **DateTime class** and date/time string formatting (e.g., now.ToString("F"), now:dd MMMM yyyy). |
| Program-Placa-Veiculos.cs | Validates a vehicle license plate using the LLLNNNN pattern (three letters and four numbers, e.g., ABC1234). | Use of **Regular Expressions** (System.Text.RegularExpressions.Regex.IsMatch) for format validation. |

## **🤝 Contribution**

Feel free to expand, refactor, or add new programs to this collection. All contributions are welcome\!

1. Fork the project.  
2. Create a new branch for your feature (git checkout \-b feature/NewFeature).  
3. Commit your changes (git commit \-m 'Adds new feature...').  
4. Push to the branch (git push origin feature/NewFeature).  
5. Open a Pull Request.

## **📄 License**

This project is licensed under the MIT License.