namespace Question5
{
    public class UtilitiesManager
    {

        public int CalculateUrgencyScore(ServiceRequest request)
        {
            return request.PriorityLevel * request.SeverityLevel * 2;
        }

        public void GenerateServiceReport(ServiceRequest request)
        {
            int urgencyScore = CalculateUrgencyScore(request);
            int adjustedResolution = request.EstimatedResolutionHours + request.PriorityLevel;
            double householdImpactScore = request.Resident.MonthlyUtilityUsage * request.SeverityLevel / 10.0;

            Console.WriteLine("\n==== Service Report ====");
            Console.WriteLine($"Resident: {request.Resident.Name}");
            Console.WriteLine($"Service Type: {request.RequestType}");
            Console.WriteLine($"Urgency Score: {urgencyScore}");
            Console.WriteLine($"Adjusted Resolution: {adjustedResolution} hours");
            Console.WriteLine($"Household Impact Score: {householdImpactScore:F2}");
        }


        public void GenerateFinalSummary(List<ServiceRequest> requests)
        {
            ServiceRequest highest = requests.OrderByDescending(r => CalculateUrgencyScore(r)).First();
            int urgencyScore = CalculateUrgencyScore(highest);
            int adjustedResolution = highest.EstimatedResolutionHours + (highest.SeverityLevel / highest.PriorityLevel);
            double householdImpactScore = highest.Resident.MonthlyUtilityUsage * highest.SeverityLevel / 10.0;

            Console.WriteLine("\n==== FINAL MUNICIPAL SUMMARY ====");
            Console.WriteLine("Highest priority issue:");
            Console.WriteLine($"Resident: {highest.Resident.Name}");
            Console.WriteLine($"Service Type: {highest.RequestType}");
            Console.WriteLine($"Urgency Score: {urgencyScore}");
            Console.WriteLine($"Adjusted Resolution: {adjustedResolution} hours");
            Console.WriteLine($"Household Impact Score: {householdImpactScore:F2}");
        }
    }
}
