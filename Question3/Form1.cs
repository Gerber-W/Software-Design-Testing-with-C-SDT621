namespace Question3;

public partial class Form1 : Form
{
    private const string Placeholder = "Enter programming language";

    public Form1()
    {
        InitializeComponent();
    }

    private void txtLanguage_Enter(object sender, EventArgs e)
    {
        if (txtLanguage.Text == Placeholder)
        {
            txtLanguage.Text = "";
            txtLanguage.ForeColor = Color.Black;
        }
    }

    private void txtLanguage_Leave(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtLanguage.Text))
        {
            txtLanguage.Text = Placeholder;
            txtLanguage.ForeColor = Color.Gray;
        }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        string language = txtLanguage.Text.Trim();

        if (string.IsNullOrWhiteSpace(language) || language == Placeholder)
        {
            MessageBox.Show("Please enter a programming language.", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        foreach (var item in lstLanguages.Items)
        {
            if (item.ToString()!.Equals(language, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show($"'{language}' is already in the list.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        lstLanguages.Items.Add(language);
        txtLanguage.Text = Placeholder;
        txtLanguage.ForeColor = Color.Gray;
        lblStatus.Text = "";
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
        if (lstLanguages.SelectedItem == null)
        {
            MessageBox.Show("Please select a language to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        string removed = lstLanguages.SelectedItem.ToString()!;
        lstLanguages.Items.Remove(lstLanguages.SelectedItem);
        lblStatus.Text = $"Removed '{removed}' at {DateTime.Now:dd MMM yyyy HH:mm:ss}";
    }
}
