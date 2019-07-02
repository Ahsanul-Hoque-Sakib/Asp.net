namespace WindowsFormsApplication1
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
            this.btnhello = new System.Windows.Forms.Button();
            this.lblshow = new System.Windows.Forms.Label();
            this.txtoutput = new System.Windows.Forms.TextBox();
            this.txtinput = new System.Windows.Forms.TextBox();
            this.Font = new System.Windows.Forms.Button();
            this.Color = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // btnhello
            // 
            this.btnhello.BackColor = System.Drawing.Color.Lime;
            this.btnhello.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhello.Location = new System.Drawing.Point(23, 184);
            this.btnhello.Name = "btnhello";
            this.btnhello.Size = new System.Drawing.Size(236, 65);
            this.btnhello.TabIndex = 0;
            this.btnhello.Text = "Show Message";
            this.btnhello.UseVisualStyleBackColor = false;
            this.btnhello.Click += new System.EventHandler(this.btnhello_Click);
            // 
            // lblshow
            // 
            this.lblshow.Location = new System.Drawing.Point(42, 34);
            this.lblshow.Name = "lblshow";
            this.lblshow.Size = new System.Drawing.Size(200, 100);
            this.lblshow.TabIndex = 1;
            this.lblshow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblshow.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtoutput
            // 
            this.txtoutput.Location = new System.Drawing.Point(321, 34);
            this.txtoutput.Multiline = true;
            this.txtoutput.Name = "txtoutput";
            this.txtoutput.Size = new System.Drawing.Size(200, 100);
            this.txtoutput.TabIndex = 2;
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(321, 184);
            this.txtinput.Multiline = true;
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(200, 65);
            this.txtinput.TabIndex = 3;
            // 
            // Font
            // 
            this.Font.Location = new System.Drawing.Point(624, 47);
            this.Font.Name = "Font";
            this.Font.Size = new System.Drawing.Size(75, 23);
            this.Font.TabIndex = 4;
            this.Font.Text = "Font";
            this.Font.UseVisualStyleBackColor = true;
            this.Font.Click += new System.EventHandler(this.button1_Click);
            // 
            // Color
            // 
            this.Color.Location = new System.Drawing.Point(624, 91);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(75, 23);
            this.Color.TabIndex = 5;
            this.Color.Text = "Color";
            this.Color.UseVisualStyleBackColor = true;
            this.Color.Click += new System.EventHandler(this.Color_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 315);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.Font);
            this.Controls.Add(this.txtinput);
            this.Controls.Add(this.txtoutput);
            this.Controls.Add(this.lblshow);
            this.Controls.Add(this.btnhello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhello;
        private System.Windows.Forms.Label lblshow;
        private System.Windows.Forms.TextBox txtoutput;
        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.Button Font;
        private System.Windows.Forms.Button Color;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

