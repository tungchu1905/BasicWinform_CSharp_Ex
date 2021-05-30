
namespace MenuFood
{
    partial class Form1
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
            this.listMenu = new System.Windows.Forms.ListBox();
            this.listFoodChosen = new System.Windows.Forms.ListBox();
            this.Add1Button = new System.Windows.Forms.Button();
            this.AddAllButton = new System.Windows.Forms.Button();
            this.Remove1Button = new System.Windows.Forms.Button();
            this.RemoveAllButton = new System.Windows.Forms.Button();
            this.AddFoodButton = new System.Windows.Forms.Button();
            this.nameFoodText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listMenu
            // 
            this.listMenu.FormattingEnabled = true;
            this.listMenu.Location = new System.Drawing.Point(39, 59);
            this.listMenu.Name = "listMenu";
            this.listMenu.Size = new System.Drawing.Size(139, 251);
            this.listMenu.TabIndex = 0;
            this.listMenu.SelectedIndexChanged += new System.EventHandler(this.listMenu_SelectedIndexChanged);
            // 
            // listFoodChosen
            // 
            this.listFoodChosen.FormattingEnabled = true;
            this.listFoodChosen.Location = new System.Drawing.Point(274, 59);
            this.listFoodChosen.Name = "listFoodChosen";
            this.listFoodChosen.Size = new System.Drawing.Size(139, 251);
            this.listFoodChosen.TabIndex = 1;
            // 
            // Add1Button
            // 
            this.Add1Button.Location = new System.Drawing.Point(207, 101);
            this.Add1Button.Name = "Add1Button";
            this.Add1Button.Size = new System.Drawing.Size(41, 34);
            this.Add1Button.TabIndex = 2;
            this.Add1Button.Text = ">";
            this.Add1Button.UseVisualStyleBackColor = true;
            this.Add1Button.Click += new System.EventHandler(this.Add1Button_Click);
            // 
            // AddAllButton
            // 
            this.AddAllButton.Location = new System.Drawing.Point(207, 151);
            this.AddAllButton.Name = "AddAllButton";
            this.AddAllButton.Size = new System.Drawing.Size(41, 34);
            this.AddAllButton.TabIndex = 3;
            this.AddAllButton.Text = ">>";
            this.AddAllButton.UseVisualStyleBackColor = true;
            this.AddAllButton.Click += new System.EventHandler(this.AddAllButton_Click);
            // 
            // Remove1Button
            // 
            this.Remove1Button.Location = new System.Drawing.Point(207, 202);
            this.Remove1Button.Name = "Remove1Button";
            this.Remove1Button.Size = new System.Drawing.Size(41, 34);
            this.Remove1Button.TabIndex = 4;
            this.Remove1Button.Text = "<";
            this.Remove1Button.UseVisualStyleBackColor = true;
            this.Remove1Button.Click += new System.EventHandler(this.Remove1Button_Click);
            // 
            // RemoveAllButton
            // 
            this.RemoveAllButton.Location = new System.Drawing.Point(207, 252);
            this.RemoveAllButton.Name = "RemoveAllButton";
            this.RemoveAllButton.Size = new System.Drawing.Size(41, 34);
            this.RemoveAllButton.TabIndex = 5;
            this.RemoveAllButton.Text = "<<";
            this.RemoveAllButton.UseVisualStyleBackColor = true;
            this.RemoveAllButton.Click += new System.EventHandler(this.RemoveAllButton_Click);
            // 
            // AddFoodButton
            // 
            this.AddFoodButton.Location = new System.Drawing.Point(338, 12);
            this.AddFoodButton.Name = "AddFoodButton";
            this.AddFoodButton.Size = new System.Drawing.Size(75, 23);
            this.AddFoodButton.TabIndex = 6;
            this.AddFoodButton.Text = "Add";
            this.AddFoodButton.UseVisualStyleBackColor = true;
            this.AddFoodButton.Click += new System.EventHandler(this.AddFoodButton_Click);
            // 
            // nameFoodText
            // 
            this.nameFoodText.Location = new System.Drawing.Point(150, 12);
            this.nameFoodText.Name = "nameFoodText";
            this.nameFoodText.Size = new System.Drawing.Size(157, 20);
            this.nameFoodText.TabIndex = 7;
            this.nameFoodText.TextChanged += new System.EventHandler(this.nameFoodText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Add food";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(338, 317);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 357);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameFoodText);
            this.Controls.Add(this.AddFoodButton);
            this.Controls.Add(this.RemoveAllButton);
            this.Controls.Add(this.Remove1Button);
            this.Controls.Add(this.AddAllButton);
            this.Controls.Add(this.Add1Button);
            this.Controls.Add(this.listFoodChosen);
            this.Controls.Add(this.listMenu);
            this.Name = "Form1";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listMenu;
        private System.Windows.Forms.ListBox listFoodChosen;
        private System.Windows.Forms.Button Add1Button;
        private System.Windows.Forms.Button AddAllButton;
        private System.Windows.Forms.Button Remove1Button;
        private System.Windows.Forms.Button RemoveAllButton;
        private System.Windows.Forms.Button AddFoodButton;
        private System.Windows.Forms.TextBox nameFoodText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitButton;
    }
}

