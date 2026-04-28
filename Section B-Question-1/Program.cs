using Question5;

Console.WriteLine("=== Welcome to Emfuleni Municipality Service Desk ===");

Console.Write("How many residents do you want to register? ");
int residentCount = int.Parse(Console.ReadLine()!);

List<Resident> residents = new List<Resident>();

for (int i = 1; i <= residentCount; i++)
{
    Console.WriteLine($"\n--- Resident {i} ---");
    Console.Write("Name: ");
    string name = Console.ReadLine()!;
    Console.Write("Address: ");
    string address = Console.ReadLine()!;
    Console.Write("Account Number: ");
    string accountNumber = Console.ReadLine()!;
    Console.Write("Monthly Utility Usage (kWh or litres): ");
    double utilityUsage = double.Parse(Console.ReadLine()!);

    residents.Add(new Resident(name, address, accountNumber, utilityUsage));
}

Console.Write("\nHow many service requests do you want to log? ");
int requestCount = int.Parse(Console.ReadLine()!);

List<ServiceRequest> serviceRequests = new List<ServiceRequest>();

for (int i = 1; i <= requestCount; i++)
{
    Console.WriteLine($"\n--- Service Request {i} ---");
    Console.Write($"Select resident by number (1 to {residentCount}): ");
    int residentIndex = int.Parse(Console.ReadLine()!) - 1;

    Console.Write("Request Type (e.g., Water Outage, Burst Pipe): ");
    string requestType = Console.ReadLine()!;

    Console.Write("Priority Level (1-5): ");
    int priority = int.Parse(Console.ReadLine()!);

    Console.Write("Severity Level (1-10): ");
    int severity = int.Parse(Console.ReadLine()!);

    Console.Write("Estimated Resolution Hours: ");
    int hours = int.Parse(Console.ReadLine()!);

    serviceRequests.Add(new ServiceRequest(residents[residentIndex], requestType, priority, severity, hours));
}

UtilitiesManager manager = new UtilitiesManager();

foreach (var request in serviceRequests)
{
    manager.GenerateServiceReport(request);
}

manager.GenerateFinalSummary(serviceRequests);

Console.WriteLine("\nThank you for using the Emfuleni Municipality Service Desk.");
