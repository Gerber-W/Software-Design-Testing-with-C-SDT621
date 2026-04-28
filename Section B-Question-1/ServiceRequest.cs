namespace Question5
{
    public class ServiceRequest
    {
        public Resident Resident { get; set; }
        public string RequestType { get; set; }
        public int PriorityLevel { get; set; }
        public int SeverityLevel { get; set; }
        public int EstimatedResolutionHours { get; set; }

        public ServiceRequest(Resident resident, string requestType, int priorityLevel, int severityLevel, int estimatedResolutionHours)
        {
            Resident = resident;
            RequestType = requestType;
            PriorityLevel = priorityLevel;
            SeverityLevel = severityLevel;
            EstimatedResolutionHours = estimatedResolutionHours;
        }
    }
}
