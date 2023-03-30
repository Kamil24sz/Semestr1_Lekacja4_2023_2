namespace Zadanie2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonMars = new System.Windows.Forms.Button();
            this.buttonJowisz = new System.Windows.Forms.Button();
            this.buttonKsiężyc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(45, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Waga przedmiotu na Ziemi [kg]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(46, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wynik";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 20);
            this.textBox1.TabIndex = 2;
            // 
            // buttonMars
            // 
            this.buttonMars.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMars.Location = new System.Drawing.Point(49, 154);
            this.buttonMars.Name = "buttonMars";
            this.buttonMars.Size = new System.Drawing.Size(252, 35);
            this.buttonMars.TabIndex = 3;
            this.buttonMars.Text = "Ile to na Marsie?";
            this.buttonMars.UseVisualStyleBackColor = true;
            this.buttonMars.Click += new System.EventHandler(this.buttonMars_Click);
            // 
            // buttonJowisz
            // 
            this.buttonJowisz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonJowisz.Location = new System.Drawing.Point(49, 211);
            this.buttonJowisz.Name = "buttonJowisz";
            this.buttonJowisz.Size = new System.Drawing.Size(252, 35);
            this.buttonJowisz.TabIndex = 4;
            this.buttonJowisz.Text = "Ile to na Jowiszu";
            this.buttonJowisz.UseVisualStyleBackColor = true;
            this.buttonJowisz.Click += new System.EventHandler(this.buttonJowisz_Click);
            // 
            // buttonKsiężyc
            // 
            this.buttonKsiężyc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonKsiężyc.Location = new System.Drawing.Point(49, 265);
            this.buttonKsiężyc.Name = "buttonKsiężyc";
            this.buttonKsiężyc.Size = new System.Drawing.Size(252, 35);
            this.buttonKsiężyc.TabIndex = 5;
            this.buttonKsiężyc.Text = "Ile to na  Księżycu?";
            this.buttonKsiężyc.UseVisualStyleBackColor = true;
            this.buttonKsiężyc.Click += new System.EventHandler(this.buttonKsiężyc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 464);
            this.Controls.Add(this.buttonKsiężyc);
            this.Controls.Add(this.buttonJowisz);
            this.Controls.Add(this.buttonMars);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonMars;
        private System.Windows.Forms.Button buttonJowisz;
        private System.Windows.Forms.Button buttonKsiężyc;
    }
}

