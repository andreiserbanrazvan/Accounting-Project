
namespace Accounting_Project.Project
{
    partial class LoginFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Login_bt = new MetroFramework.Controls.MetroButton();
            this.Exit_bt = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.User_tx = new MetroFramework.Controls.MetroTextBox();
            this.Pwd_tx = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // Login_bt
            // 
            this.Login_bt.Location = new System.Drawing.Point(31, 190);
            this.Login_bt.Name = "Login_bt";
            this.Login_bt.Size = new System.Drawing.Size(184, 45);
            this.Login_bt.TabIndex = 0;
            this.Login_bt.Text = "Login";
            this.Login_bt.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Login_bt.UseSelectable = true;
            this.Login_bt.Click += new System.EventHandler(this.Login_bt_Click);
            // 
            // Exit_bt
            // 
            this.Exit_bt.Location = new System.Drawing.Point(213, 190);
            this.Exit_bt.Name = "Exit_bt";
            this.Exit_bt.Size = new System.Drawing.Size(184, 45);
            this.Exit_bt.TabIndex = 1;
            this.Exit_bt.Text = "Exit";
            this.Exit_bt.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Exit_bt.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(33, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(99, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "User Name";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(31, 124);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(87, 25);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Password";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // User_tx
            // 
            // 
            // 
            // 
            this.User_tx.CustomButton.Image = null;
            this.User_tx.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.User_tx.CustomButton.Name = "";
            this.User_tx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.User_tx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.User_tx.CustomButton.TabIndex = 1;
            this.User_tx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.User_tx.CustomButton.UseSelectable = true;
            this.User_tx.CustomButton.Visible = false;
            this.User_tx.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.User_tx.Lines = new string[0];
            this.User_tx.Location = new System.Drawing.Point(138, 79);
            this.User_tx.MaxLength = 32767;
            this.User_tx.Name = "User_tx";
            this.User_tx.PasswordChar = '\0';
            this.User_tx.PromptText = "Enter User Name";
            this.User_tx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.User_tx.SelectedText = "";
            this.User_tx.SelectionLength = 0;
            this.User_tx.SelectionStart = 0;
            this.User_tx.ShortcutsEnabled = true;
            this.User_tx.Size = new System.Drawing.Size(253, 23);
            this.User_tx.TabIndex = 4;
            this.User_tx.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.User_tx.UseSelectable = true;
            this.User_tx.WaterMark = "Enter User Name";
            this.User_tx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.User_tx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Pwd_tx
            // 
            // 
            // 
            // 
            this.Pwd_tx.CustomButton.Image = null;
            this.Pwd_tx.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.Pwd_tx.CustomButton.Name = "";
            this.Pwd_tx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Pwd_tx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Pwd_tx.CustomButton.TabIndex = 1;
            this.Pwd_tx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Pwd_tx.CustomButton.UseSelectable = true;
            this.Pwd_tx.CustomButton.Visible = false;
            this.Pwd_tx.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Pwd_tx.Lines = new string[0];
            this.Pwd_tx.Location = new System.Drawing.Point(138, 124);
            this.Pwd_tx.MaxLength = 32767;
            this.Pwd_tx.Name = "Pwd_tx";
            this.Pwd_tx.PasswordChar = '\0';
            this.Pwd_tx.PromptText = "Enter Password";
            this.Pwd_tx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Pwd_tx.SelectedText = "";
            this.Pwd_tx.SelectionLength = 0;
            this.Pwd_tx.SelectionStart = 0;
            this.Pwd_tx.ShortcutsEnabled = true;
            this.Pwd_tx.Size = new System.Drawing.Size(253, 23);
            this.Pwd_tx.TabIndex = 5;
            this.Pwd_tx.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Pwd_tx.UseSelectable = true;
            this.Pwd_tx.WaterMark = "Enter Password";
            this.Pwd_tx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Pwd_tx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 265);
            this.Controls.Add(this.Pwd_tx);
            this.Controls.Add(this.User_tx);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Exit_bt);
            this.Controls.Add(this.Login_bt);
            this.Name = "LoginFrm";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "LoginFrm";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.LoginFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton Login_bt;
        private MetroFramework.Controls.MetroButton Exit_bt;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox User_tx;
        private MetroFramework.Controls.MetroTextBox Pwd_tx;
    }
}