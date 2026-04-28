namespace Question4;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        string imgPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "coat_of_arms.png");
        if (File.Exists(imgPath))
            picCoatOfArms.Image = Image.FromFile(imgPath);
    }

    private void btnValidate_Click(object sender, EventArgs e)
    {
        string name = txtName.Text.Trim();
        string id = txtID.Text.Trim();
        string citizenship = cmbCitizen.SelectedItem?.ToString() ?? "";

        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(id))
        {
            lblResult.Text = "Please fill in your name and ID number.";
            return;
        }

        var profile = new CitizenProfile(name, id, citizenship);
        lblResult.Text = profile.ValidateID();
    }

    private void btnGenerate_Click(object sender, EventArgs e)
    {
        string name = txtName.Text.Trim();
        string id = txtID.Text.Trim();
        string citizenship = cmbCitizen.SelectedItem?.ToString() ?? "";

        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(id))
        {
            txtSummary.Text = "Please fill in all fields before generating a profile.";
            return;
        }

        var profile = new CitizenProfile(name, id, citizenship);
        string validation = profile.ValidateID();

        txtSummary.Text =
            $"==== DIGITAL CITIZEN SUMMARY ===={Environment.NewLine}" +
            $"Name: {profile.FullName}{Environment.NewLine}" +
            $"ID Number: {profile.IDNumber}{Environment.NewLine}" +
            $"Age: {profile.Age}{Environment.NewLine}" +
            $"Citizenship: {profile.CitizenshipStatus}{Environment.NewLine}" +
            $"Validation: {validation}{Environment.NewLine}" +
            $"Processed at: Home Affairs Digital Desk{Environment.NewLine}" +
            $"Timestamp: {DateTime.Now:yyyy/MM/dd HH:mm:ss}";
    }
}
