namespace AsyncExample
{
    partial class Form1
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
            this.GreenSquare = new System.Windows.Forms.Button();
            this.RedSquare = new System.Windows.Forms.Button();
            this.BlueSquare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GreenSquare
            // 
            this.GreenSquare.Location = new System.Drawing.Point(511, 203);
            this.GreenSquare.Name = "GreenSquare";
            this.GreenSquare.Size = new System.Drawing.Size(161, 45);
            this.GreenSquare.TabIndex = 5;
            this.GreenSquare.Text = "Yeşil Kare";
            this.GreenSquare.UseVisualStyleBackColor = true;
            this.GreenSquare.Click += new System.EventHandler(this.GreenSquare_Click);
            // 
            // RedSquare
            // 
            this.RedSquare.Location = new System.Drawing.Point(318, 203);
            this.RedSquare.Name = "RedSquare";
            this.RedSquare.Size = new System.Drawing.Size(161, 45);
            this.RedSquare.TabIndex = 4;
            this.RedSquare.Text = "Kırmızı Kare";
            this.RedSquare.UseVisualStyleBackColor = true;
            this.RedSquare.Click += new System.EventHandler(this.RedSquare_Click);
            // 
            // BlueSquare
            // 
            this.BlueSquare.Location = new System.Drawing.Point(128, 203);
            this.BlueSquare.Name = "BlueSquare";
            this.BlueSquare.Size = new System.Drawing.Size(161, 45);
            this.BlueSquare.TabIndex = 3;
            this.BlueSquare.Text = "Mavi Kare";
            this.BlueSquare.UseVisualStyleBackColor = true;
            this.BlueSquare.Click += new System.EventHandler(this.BlueSquare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GreenSquare);
            this.Controls.Add(this.RedSquare);
            this.Controls.Add(this.BlueSquare);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button GreenSquare;
        private Button RedSquare;
        private Button BlueSquare;
    }
}