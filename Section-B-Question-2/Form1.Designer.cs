namespace Question4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.picCoatOfArms = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblCitizen = new System.Windows.Forms.Label();
            this.cmbCitizen = new System.Windows.Forms.ComboBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCoatOfArms)).BeginInit();
            this.SuspendLayout();

            // picCoatOfArms
            this.picCoatOfArms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.picCoatOfArms.Location = new System.Drawing.Point(10, 10);
            this.picCoatOfArms.Size = new System.Drawing.Size(200, 430);
            this.picCoatOfArms.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCoatOfArms.BackColor = System.Drawing.Color.White;

            // lblTitle
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 80, 0);
            this.lblTitle.Location = new System.Drawing.Point(215, 15);
            this.lblTitle.Size = new System.Drawing.Size(405, 40);
            this.lblTitle.Text = "Home Affairs Digital Identity Processor";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblName
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(215, 70);
            this.lblName.Size = new System.Drawing.Size(155, 25);
            this.lblName.Text = "Enter your Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // txtName
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.BackColor = System.Drawing.Color.FromArgb(255, 255, 220);
            this.txtName.Location = new System.Drawing.Point(380, 70);
            this.txtName.Size = new System.Drawing.Size(235, 25);

            // lblID
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblID.Location = new System.Drawing.Point(215, 112);
            this.lblID.Size = new System.Drawing.Size(155, 25);
            this.lblID.Text = "Enter your ID:";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // txtID
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtID.BackColor = System.Drawing.Color.FromArgb(255, 255, 220);
            this.txtID.Location = new System.Drawing.Point(380, 112);
            this.txtID.Size = new System.Drawing.Size(235, 25);

            // lblCitizen
            this.lblCitizen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCitizen.Location = new System.Drawing.Point(215, 154);
            this.lblCitizen.Size = new System.Drawing.Size(155, 25);
            this.lblCitizen.Text = "Choose your Citizen:";
            this.lblCitizen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // cmbCitizen
            this.cmbCitizen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCitizen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCitizen.Items.AddRange(new object[] { "South African", "Permanent Resident", "Visitor" });
            this.cmbCitizen.Location = new System.Drawing.Point(380, 154);
            this.cmbCitizen.Size = new System.Drawing.Size(235, 25);
            this.cmbCitizen.SelectedIndex = 0;

            // btnValidate
            this.btnValidate.BackColor = System.Drawing.Color.FromArgb(0, 150, 0);
            this.btnValidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidate.FlatAppearance.BorderSize = 0;
            this.btnValidate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnValidate.ForeColor = System.Drawing.Color.White;
            this.btnValidate.Location = new System.Drawing.Point(380, 198);
            this.btnValidate.Size = new System.Drawing.Size(120, 32);
            this.btnValidate.Text = "Validate ID";
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);

            // lblResult
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblResult.Location = new System.Drawing.Point(215, 242);
            this.lblResult.Size = new System.Drawing.Size(400, 22);
            this.lblResult.Text = "";

            // txtSummary
            this.txtSummary.BackColor = System.Drawing.Color.FromArgb(255, 255, 220);
            this.txtSummary.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtSummary.Location = new System.Drawing.Point(215, 270);
            this.txtSummary.Multiline = true;
            this.txtSummary.ReadOnly = true;
            this.txtSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSummary.Size = new System.Drawing.Size(400, 140);
            this.txtSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // btnGenerate
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(0, 150, 0);
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(380, 425);
            this.btnGenerate.Size = new System.Drawing.Size(140, 32);
            this.btnGenerate.Text = "Generate profile";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 475);
            this.Controls.Add(this.picCoatOfArms);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblCitizen);
            this.Controls.Add(this.cmbCitizen);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.picCoatOfArms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.PictureBox picCoatOfArms;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblCitizen;
        private System.Windows.Forms.ComboBox cmbCitizen;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.Button btnGenerate;
    }
}
