namespace Question3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lstLanguages = new System.Windows.Forms.ListBox();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();

            // panelMain
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.lblTitle);
            this.panelMain.Controls.Add(this.lstLanguages);
            this.panelMain.Controls.Add(this.txtLanguage);
            this.panelMain.Controls.Add(this.btnAdd);
            this.panelMain.Controls.Add(this.btnRemove);
            this.panelMain.Controls.Add(this.lblStatus);
            this.panelMain.Location = new System.Drawing.Point(40, 30);
            this.panelMain.Size = new System.Drawing.Size(520, 370);

            // lblTitle
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Size = new System.Drawing.Size(480, 30);
            this.lblTitle.Text = "My Favourite Programming Languages";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lstLanguages
            this.lstLanguages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstLanguages.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstLanguages.Location = new System.Drawing.Point(20, 65);
            this.lstLanguages.Size = new System.Drawing.Size(480, 160);

            // txtLanguage
            this.txtLanguage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLanguage.ForeColor = System.Drawing.Color.Gray;
            this.txtLanguage.Location = new System.Drawing.Point(20, 240);
            this.txtLanguage.Size = new System.Drawing.Size(480, 25);
            this.txtLanguage.Text = "Enter programming language";
            this.txtLanguage.Enter += new System.EventHandler(this.txtLanguage_Enter);
            this.txtLanguage.Leave += new System.EventHandler(this.txtLanguage_Leave);

            // btnAdd
            this.btnAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(20, 285);
            this.btnAdd.Size = new System.Drawing.Size(130, 35);
            this.btnAdd.Text = "Add Language";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnRemove
            this.btnRemove.BackColor = System.Drawing.Color.Crimson;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(165, 285);
            this.btnRemove.Size = new System.Drawing.Size(100, 35);
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);

            // lblStatus
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblStatus.ForeColor = System.Drawing.Color.DimGray;
            this.lblStatus.Location = new System.Drawing.Point(275, 293);
            this.lblStatus.Size = new System.Drawing.Size(225, 20);
            this.lblStatus.Text = "";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(600, 440);
            this.Controls.Add(this.panelMain);
            this.Name = "Form1";
            this.Text = "Favourite Programming Languages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lstLanguages;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblStatus;
    }
}
