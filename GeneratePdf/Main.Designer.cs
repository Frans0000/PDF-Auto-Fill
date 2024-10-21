namespace GeneratePdf
{
    partial class Main
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
            this.testPdf = new System.Windows.Forms.Button();
            this.test1TextBox = new System.Windows.Forms.TextBox();
            this.test2TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // testPdf
            // 
            this.testPdf.Location = new System.Drawing.Point(349, 316);
            this.testPdf.Name = "testPdf";
            this.testPdf.Size = new System.Drawing.Size(75, 23);
            this.testPdf.TabIndex = 0;
            this.testPdf.Text = "Test pdf";
            this.testPdf.UseVisualStyleBackColor = true;
            this.testPdf.Click += new System.EventHandler(this.testPdf_Click_1);
            // 
            // test1TextBox
            // 
            this.test1TextBox.Location = new System.Drawing.Point(338, 121);
            this.test1TextBox.Name = "test1TextBox";
            this.test1TextBox.Size = new System.Drawing.Size(100, 20);
            this.test1TextBox.TabIndex = 1;
            // 
            // test2TextBox
            // 
            this.test2TextBox.Location = new System.Drawing.Point(338, 147);
            this.test2TextBox.Name = "test2TextBox";
            this.test2TextBox.Size = new System.Drawing.Size(100, 20);
            this.test2TextBox.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.test2TextBox);
            this.Controls.Add(this.test1TextBox);
            this.Controls.Add(this.testPdf);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button testPdf;
        private System.Windows.Forms.TextBox test1TextBox;
        private System.Windows.Forms.TextBox test2TextBox;
    }
}

