
namespace ConvertPic
{
    partial class BrowseForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.browseButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.normalButton = new System.Windows.Forms.Button();
            this.invertButton = new System.Windows.Forms.Button();
            this.specialButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(568, 54);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(138, 46);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(34, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(484, 46);
            this.textBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox1.Location = new System.Drawing.Point(39, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(666, 498);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // normalButton
            // 
            this.normalButton.Location = new System.Drawing.Point(39, 680);
            this.normalButton.Name = "normalButton";
            this.normalButton.Size = new System.Drawing.Size(200, 38);
            this.normalButton.TabIndex = 5;
            this.normalButton.Text = "NORMAL";
            this.normalButton.UseVisualStyleBackColor = true;
            this.normalButton.Click += new System.EventHandler(this.normalButton_Click);
            // 
            // invertButton
            // 
            this.invertButton.Location = new System.Drawing.Point(275, 680);
            this.invertButton.Name = "invertButton";
            this.invertButton.Size = new System.Drawing.Size(200, 38);
            this.invertButton.TabIndex = 6;
            this.invertButton.Text = "INVERTED";
            this.invertButton.UseVisualStyleBackColor = true;
            this.invertButton.Click += new System.EventHandler(this.invertButton_Click);
            // 
            // specialButton
            // 
            this.specialButton.Location = new System.Drawing.Point(506, 680);
            this.specialButton.Name = "specialButton";
            this.specialButton.Size = new System.Drawing.Size(200, 38);
            this.specialButton.TabIndex = 7;
            this.specialButton.Text = "SPECIAL";
            this.specialButton.UseVisualStyleBackColor = true;
            this.specialButton.Click += new System.EventHandler(this.specialButton_Click);
            // 
            // BrowseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 770);
            this.Controls.Add(this.specialButton);
            this.Controls.Add(this.invertButton);
            this.Controls.Add(this.normalButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.browseButton);
            this.Name = "BrowseForm";
            this.Text = "New Art";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button normalButton;
        private System.Windows.Forms.Button invertButton;
        private System.Windows.Forms.Button specialButton;
    }
}

