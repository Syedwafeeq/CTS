using SOLIDPrinciplesDemo.SRP;
using SOLIDPrinciplesDemo.OCP;
using SOLIDPrinciplesDemo.LSP;
using SOLIDPrinciplesDemo.ISP;
using SOLIDPrinciplesDemo.DIP;

Console.WriteLine("========================================");
Console.WriteLine(" SOLID Principles - .NET 8");
Console.WriteLine(" Single Responsibility Principle (SRP)");
Console.WriteLine("========================================");
Console.WriteLine();

SRPDemo.Run();

Console.WriteLine();

Console.WriteLine("========================================");
Console.WriteLine(" Open Closed Principle (OCP)");
Console.WriteLine("========================================");

OCPDemo.Run();

Console.WriteLine();

Console.WriteLine("========================================");
Console.WriteLine(" Liskov Substitution Principle (LSP)");
Console.WriteLine("========================================");

LSPDemo.Run();

Console.WriteLine();

Console.WriteLine("========================================");
Console.WriteLine(" Interface Segregation Principle (ISP)");
Console.WriteLine("========================================");

ISPDemo.Run();

Console.WriteLine();

Console.WriteLine("========================================");
Console.WriteLine(" Dependency Inversion Principle (DIP)");
Console.WriteLine("========================================");

DIPDemo.Run();