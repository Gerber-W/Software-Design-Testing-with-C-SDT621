namespace Question4;

public class CitizenProfile
{
    public string FullName { get; set; }
    public string IDNumber { get; set; }
    public int Age { get; set; }
    public string CitizenshipStatus { get; set; }

    public CitizenProfile(string fullName, string idNumber, string citizenshipStatus)
    {
        FullName = fullName;
        IDNumber = idNumber;
        CitizenshipStatus = citizenshipStatus;
        Age = CalculateAge(idNumber);
    }

    private int CalculateAge(string idNumber)
    {
        if (idNumber.Length < 6 || !idNumber.All(char.IsDigit))
            return -1;

        int year  = int.Parse(idNumber.Substring(0, 2));
        int month = int.Parse(idNumber.Substring(2, 2));
        int day   = int.Parse(idNumber.Substring(4, 2));

        int currentYearShort = DateTime.Now.Year % 100;
        int century = (year <= currentYearShort) ? 2000 : 1900;
        int birthYear = century + year;

        try
        {
            var birthDate = new DateTime(birthYear, month, day);
            int age = DateTime.Now.Year - birthDate.Year;
            if (DateTime.Now < birthDate.AddYears(age)) age--;
            return age;
        }
        catch
        {
            return -1;
        }
    }

    public string ValidateID()
    {
        if (IDNumber.Length != 13)
            return "Invalid ID. ID number must be exactly 13 digits.";

        if (!IDNumber.All(char.IsDigit))
            return "Invalid ID. ID number must be numeric only.";

        if (Age < 0 || Age > 150)
            return "Invalid ID. Age derived from ID is not valid.";

        return $"Valid ID. Citizen is {Age} years old.";
    }
}
