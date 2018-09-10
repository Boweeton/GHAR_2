namespace GHAR_2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.megasysHelper2TabControl = new System.Windows.Forms.TabControl();
            this.gateHousePage = new System.Windows.Forms.TabPage();
            this.openGenPathsButton = new System.Windows.Forms.Button();
            this.megasysHelper2TabControl.SuspendLayout();
            this.gateHousePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // megasysHelper2TabControl
            // 
            this.megasysHelper2TabControl.Controls.Add(this.gateHousePage);
            this.megasysHelper2TabControl.Location = new System.Drawing.Point(17, 16);
            this.megasysHelper2TabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.megasysHelper2TabControl.Name = "megasysHelper2TabControl";
            this.megasysHelper2TabControl.SelectedIndex = 0;
            this.megasysHelper2TabControl.Size = new System.Drawing.Size(775, 673);
            this.megasysHelper2TabControl.TabIndex = 0;
            // 
            // gateHousePage
            // 
            this.gateHousePage.Controls.Add(this.openGenPathsButton);
            this.gateHousePage.Location = new System.Drawing.Point(4, 25);
            this.gateHousePage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gateHousePage.Name = "gateHousePage";
            this.gateHousePage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gateHousePage.Size = new System.Drawing.Size(767, 644);
            this.gateHousePage.TabIndex = 0;
            this.gateHousePage.Text = "Gate House";
            this.gateHousePage.UseVisualStyleBackColor = true;
            // 
            // openGenPathsButton
            // 
            this.openGenPathsButton.Location = new System.Drawing.Point(9, 9);
            this.openGenPathsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.openGenPathsButton.Name = "openGenPathsButton";
            this.openGenPathsButton.Size = new System.Drawing.Size(135, 28);
            this.openGenPathsButton.TabIndex = 0;
            this.openGenPathsButton.Text = "Open Gen Paths";
            this.openGenPathsButton.UseVisualStyleBackColor = true;
            this.openGenPathsButton.Click += new System.EventHandler(this.OnOpenGenPathsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 704);
            this.Controls.Add(this.megasysHelper2TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Megasys Helper 2.0";
            this.Load += new System.EventHandler(this.OnGharMainScreenFormLoad);
            this.megasysHelper2TabControl.ResumeLayout(false);
            this.gateHousePage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl megasysHelper2TabControl;
        private System.Windows.Forms.TabPage gateHousePage;
        private System.Windows.Forms.Button openGenPathsButton;
    }
}

