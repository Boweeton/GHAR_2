namespace GHAR_2
{
    partial class GenPathsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenPathsForm));
            this.calculateButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.copyEaRawDataPathButton = new System.Windows.Forms.Button();
            this.copyTmlRawDataPathButton = new System.Windows.Forms.Button();
            this.eaRawDataPathTextBox = new System.Windows.Forms.TextBox();
            this.tmlRawDataPathTextBox = new System.Windows.Forms.TextBox();
            this.eaRawDataLabel = new System.Windows.Forms.Label();
            this.tmlRawDataLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(380, 157);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.OnCalculateButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(299, 157);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.OnCancelButton_Click);
            // 
            // copyEaRawDataPathButton
            // 
            this.copyEaRawDataPathButton.BackColor = System.Drawing.SystemColors.Control;
            this.copyEaRawDataPathButton.Location = new System.Drawing.Point(334, 30);
            this.copyEaRawDataPathButton.Name = "copyEaRawDataPathButton";
            this.copyEaRawDataPathButton.Size = new System.Drawing.Size(103, 23);
            this.copyEaRawDataPathButton.TabIndex = 2;
            this.copyEaRawDataPathButton.Text = "Copy to Clipboard";
            this.copyEaRawDataPathButton.UseVisualStyleBackColor = false;
            this.copyEaRawDataPathButton.Click += new System.EventHandler(this.OnCopyEaRawDataPathButton_Click);
            // 
            // copyTmlRawDataPathButton
            // 
            this.copyTmlRawDataPathButton.Location = new System.Drawing.Point(335, 82);
            this.copyTmlRawDataPathButton.Name = "copyTmlRawDataPathButton";
            this.copyTmlRawDataPathButton.Size = new System.Drawing.Size(103, 23);
            this.copyTmlRawDataPathButton.TabIndex = 3;
            this.copyTmlRawDataPathButton.Text = "Copy to Clipboard";
            this.copyTmlRawDataPathButton.UseVisualStyleBackColor = true;
            this.copyTmlRawDataPathButton.Click += new System.EventHandler(this.OnCopyTmlRawDataPathButton_Click);
            // 
            // eaRawDataPathTextBox
            // 
            this.eaRawDataPathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eaRawDataPathTextBox.Location = new System.Drawing.Point(12, 30);
            this.eaRawDataPathTextBox.Name = "eaRawDataPathTextBox";
            this.eaRawDataPathTextBox.ReadOnly = true;
            this.eaRawDataPathTextBox.Size = new System.Drawing.Size(316, 20);
            this.eaRawDataPathTextBox.TabIndex = 4;
            // 
            // tmlRawDataPathTextBox
            // 
            this.tmlRawDataPathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tmlRawDataPathTextBox.Location = new System.Drawing.Point(12, 82);
            this.tmlRawDataPathTextBox.Name = "tmlRawDataPathTextBox";
            this.tmlRawDataPathTextBox.ReadOnly = true;
            this.tmlRawDataPathTextBox.Size = new System.Drawing.Size(316, 20);
            this.tmlRawDataPathTextBox.TabIndex = 5;
            // 
            // eaRawDataLabel
            // 
            this.eaRawDataLabel.AutoSize = true;
            this.eaRawDataLabel.Location = new System.Drawing.Point(12, 11);
            this.eaRawDataLabel.Name = "eaRawDataLabel";
            this.eaRawDataLabel.Size = new System.Drawing.Size(171, 13);
            this.eaRawDataLabel.TabIndex = 6;
            this.eaRawDataLabel.Text = "Expected Arrivals [Raw Data Path]";
            // 
            // tmlRawDataLabel
            // 
            this.tmlRawDataLabel.AutoSize = true;
            this.tmlRawDataLabel.Location = new System.Drawing.Point(13, 63);
            this.tmlRawDataLabel.Name = "tmlRawDataLabel";
            this.tmlRawDataLabel.Size = new System.Drawing.Size(187, 13);
            this.tmlRawDataLabel.TabIndex = 7;
            this.tmlRawDataLabel.Text = "Ticket Master Listing [Raw Data Path]";
            // 
            // GenPathsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 191);
            this.Controls.Add(this.tmlRawDataLabel);
            this.Controls.Add(this.eaRawDataLabel);
            this.Controls.Add(this.tmlRawDataPathTextBox);
            this.Controls.Add(this.eaRawDataPathTextBox);
            this.Controls.Add(this.copyTmlRawDataPathButton);
            this.Controls.Add(this.copyEaRawDataPathButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.calculateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GenPathsForm";
            this.ShowInTaskbar = false;
            this.Text = "GeneratePathsSubWindowForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.OnGeneratePathsSubWindowFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button copyEaRawDataPathButton;
        private System.Windows.Forms.Button copyTmlRawDataPathButton;
        private System.Windows.Forms.TextBox eaRawDataPathTextBox;
        private System.Windows.Forms.TextBox tmlRawDataPathTextBox;
        private System.Windows.Forms.Label eaRawDataLabel;
        private System.Windows.Forms.Label tmlRawDataLabel;
    }
}