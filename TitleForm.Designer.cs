
namespace ConvertPic
{
    partial class TitleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitleForm));
            this.newButton = new System.Windows.Forms.Button();
            this.albumButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newButton
            // 
            this.newButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newButton.Location = new System.Drawing.Point(89, 422);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(330, 50);
            this.newButton.TabIndex = 1;
            this.newButton.Text = "Create New Art";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // albumButton
            // 
            this.albumButton.Location = new System.Drawing.Point(89, 501);
            this.albumButton.Name = "albumButton";
            this.albumButton.Size = new System.Drawing.Size(330, 50);
            this.albumButton.TabIndex = 2;
            this.albumButton.Text = "View Album";
            this.albumButton.UseVisualStyleBackColor = true;
            this.albumButton.Click += new System.EventHandler(this.albumButton_Click_1);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(89, 577);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(330, 50);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 13.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 73);
            this.label1.TabIndex = 4;
            this.label1.Text = "Image ASCII Converter";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Courier New", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(127, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 256);
            this.label2.TabIndex = 5;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // TitleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(504, 667);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.albumButton);
            this.Controls.Add(this.newButton);
            this.Name = "TitleForm";
            this.Text = "Title Page";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button albumButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}