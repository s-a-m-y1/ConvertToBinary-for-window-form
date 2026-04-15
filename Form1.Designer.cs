namespace WindowsFormsApp1
{
    partial class Market
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Market));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextInput = new System.Windows.Forms.TextBox();
            this.TextOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Convert = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Enable = new System.Windows.Forms.Button();
            this.Desible = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(822, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(465, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcone";
            // 
            // TextInput
            // 
            this.TextInput.BackColor = System.Drawing.Color.MediumPurple;
            this.TextInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextInput.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextInput.ForeColor = System.Drawing.Color.Goldenrod;
            this.TextInput.Location = new System.Drawing.Point(167, 276);
            this.TextInput.Name = "TextInput";
            this.TextInput.Size = new System.Drawing.Size(266, 63);
            this.TextInput.TabIndex = 3;
            this.TextInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // TextOutput
            // 
            this.TextOutput.BackColor = System.Drawing.Color.MediumPurple;
            this.TextOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextOutput.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextOutput.ForeColor = System.Drawing.Color.Gold;
            this.TextOutput.Location = new System.Drawing.Point(613, 276);
            this.TextOutput.Name = "TextOutput";
            this.TextOutput.Size = new System.Drawing.Size(266, 63);
            this.TextOutput.TabIndex = 4;
            this.TextOutput.TextChanged += new System.EventHandler(this.TextOutput_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(255, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(687, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Binary Code";
            // 
            // Convert
            // 
            this.Convert.BackColor = System.Drawing.Color.Gold;
            this.Convert.Location = new System.Drawing.Point(451, 419);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(149, 38);
            this.Convert.TabIndex = 7;
            this.Convert.Text = "Convert :)";
            this.Convert.UseVisualStyleBackColor = false;
            this.Convert.Click += new System.EventHandler(this.button1_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Clear.Location = new System.Drawing.Point(451, 463);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(149, 38);
            this.Clear.TabIndex = 8;
            this.Clear.Text = "Clear :)";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Enable
            // 
            this.Enable.BackColor = System.Drawing.Color.RoyalBlue;
            this.Enable.Location = new System.Drawing.Point(918, 413);
            this.Enable.Name = "Enable";
            this.Enable.Size = new System.Drawing.Size(122, 38);
            this.Enable.TabIndex = 10;
            this.Enable.Text = "Eneble";
            this.Enable.UseVisualStyleBackColor = false;
            this.Enable.Click += new System.EventHandler(this.Enable_Click);
            // 
            // Desible
            // 
            this.Desible.BackColor = System.Drawing.Color.RoyalBlue;
            this.Desible.Location = new System.Drawing.Point(918, 369);
            this.Desible.Name = "Desible";
            this.Desible.Size = new System.Drawing.Size(122, 38);
            this.Desible.TabIndex = 9;
            this.Desible.Text = "Desible";
            this.Desible.UseVisualStyleBackColor = false;
            this.Desible.Click += new System.EventHandler(this.Desible_Click);
            // 
            // Market
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1070, 817);
            this.Controls.Add(this.Enable);
            this.Controls.Add(this.Desible);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextOutput);
            this.Controls.Add(this.TextInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Market";
            this.Opacity = 0.95D;
            this.Text = "ConvertToBinary";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextInput;
        private System.Windows.Forms.TextBox TextOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Enable;
        private System.Windows.Forms.Button Desible;
    }
}

