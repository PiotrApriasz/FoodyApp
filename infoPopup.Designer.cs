namespace FoodAppWindow
{
    partial class infoPopup
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbCreator = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("SF Pro Display", 15.68317F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbName.Location = new System.Drawing.Point(203, 69);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(163, 26);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "FoodY - C# App";
            // 
            // lbCreator
            // 
            this.lbCreator.AutoSize = true;
            this.lbCreator.Font = new System.Drawing.Font("SF Pro Display", 14.25743F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCreator.Location = new System.Drawing.Point(12, 119);
            this.lbCreator.Name = "lbCreator";
            this.lbCreator.Size = new System.Drawing.Size(555, 24);
            this.lbCreator.TabIndex = 1;
            this.lbCreator.Text = "Created by: Piotr Apriasz - 2nd year student of Computer Science";
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.Font = new System.Drawing.Font("SF Pro Display", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbVersion.Location = new System.Drawing.Point(12, 262);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(93, 20);
            this.lbVersion.TabIndex = 2;
            this.lbVersion.Text = "Version: 0.3";
            // 
            // infoPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(603, 326);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.lbCreator);
            this.Controls.Add(this.lbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "infoPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbCreator;
        private System.Windows.Forms.Label lbVersion;
    }
}