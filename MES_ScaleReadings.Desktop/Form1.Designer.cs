namespace MES_ScaleReadings.Desktop
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
            this.btnGet100 = new System.Windows.Forms.Button();
            this.tbInfo100 = new System.Windows.Forms.TextBox();
            this.btnDisConnect = new System.Windows.Forms.Button();
            this.tbInfo101 = new System.Windows.Forms.TextBox();
            this.btnGet101 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGet100
            // 
            this.btnGet100.Location = new System.Drawing.Point(381, 10);
            this.btnGet100.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGet100.Name = "btnGet100";
            this.btnGet100.Size = new System.Drawing.Size(114, 46);
            this.btnGet100.TabIndex = 0;
            this.btnGet100.Text = "Get 100";
            this.btnGet100.UseVisualStyleBackColor = true;
            this.btnGet100.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbInfo100
            // 
            this.tbInfo100.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbInfo100.Location = new System.Drawing.Point(0, 0);
            this.tbInfo100.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbInfo100.Multiline = true;
            this.tbInfo100.Name = "tbInfo100";
            this.tbInfo100.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInfo100.Size = new System.Drawing.Size(376, 378);
            this.tbInfo100.TabIndex = 1;
            // 
            // btnDisConnect
            // 
            this.btnDisConnect.Location = new System.Drawing.Point(381, 326);
            this.btnDisConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDisConnect.Name = "btnDisConnect";
            this.btnDisConnect.Size = new System.Drawing.Size(103, 42);
            this.btnDisConnect.TabIndex = 2;
            this.btnDisConnect.Text = "Clear";
            this.btnDisConnect.UseVisualStyleBackColor = true;
            this.btnDisConnect.Click += new System.EventHandler(this.btnDisConnect_Click);
            // 
            // tbInfo101
            // 
            this.tbInfo101.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbInfo101.Location = new System.Drawing.Point(500, 0);
            this.tbInfo101.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbInfo101.Multiline = true;
            this.tbInfo101.Name = "tbInfo101";
            this.tbInfo101.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInfo101.Size = new System.Drawing.Size(376, 378);
            this.tbInfo101.TabIndex = 3;
            // 
            // btnGet101
            // 
            this.btnGet101.Location = new System.Drawing.Point(381, 60);
            this.btnGet101.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGet101.Name = "btnGet101";
            this.btnGet101.Size = new System.Drawing.Size(114, 46);
            this.btnGet101.TabIndex = 4;
            this.btnGet101.Text = "Get 101";
            this.btnGet101.UseVisualStyleBackColor = true;
            this.btnGet101.Click += new System.EventHandler(this.btnGet101_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 198);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Get";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(409, 248);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(86, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(461, 274);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(34, 22);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "IP:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "PORT:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 378);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGet101);
            this.Controls.Add(this.tbInfo101);
            this.Controls.Add(this.btnDisConnect);
            this.Controls.Add(this.tbInfo100);
            this.Controls.Add(this.btnGet100);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGet100;
        private System.Windows.Forms.TextBox tbInfo100;
        private System.Windows.Forms.Button btnDisConnect;
        private System.Windows.Forms.TextBox tbInfo101;
        private System.Windows.Forms.Button btnGet101;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

