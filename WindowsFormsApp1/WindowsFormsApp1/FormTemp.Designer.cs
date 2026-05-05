namespace WindowsFormsApp1
{
    partial class FormTemp
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
            this.btnConvert = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labFahrenheit = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.labCelsius = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(119, 78);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 28;
            this.btnConvert.Text = "轉換";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("新細明體", 20F);
            this.textBox1.Location = new System.Drawing.Point(119, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 39);
            this.textBox1.TabIndex = 29;
            // 
            // labFahrenheit
            // 
            this.labFahrenheit.AutoSize = true;
            this.labFahrenheit.Font = new System.Drawing.Font("新細明體", 20F);
            this.labFahrenheit.Location = new System.Drawing.Point(12, 23);
            this.labFahrenheit.Name = "labFahrenheit";
            this.labFahrenheit.Size = new System.Drawing.Size(97, 27);
            this.labFahrenheit.TabIndex = 30;
            this.labFahrenheit.Text = "華氏(f):";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("新細明體", 20F);
            this.labelResult.Location = new System.Drawing.Point(104, 117);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(336, 27);
            this.labelResult.TabIndex = 31;
            this.labelResult.Text = "請輸入華氏後按下轉換按鈕";
            // 
            // labCelsius
            // 
            this.labCelsius.AutoSize = true;
            this.labCelsius.Font = new System.Drawing.Font("新細明體", 20F);
            this.labCelsius.Location = new System.Drawing.Point(9, 117);
            this.labCelsius.Name = "labCelsius";
            this.labCelsius.Size = new System.Drawing.Size(100, 27);
            this.labCelsius.TabIndex = 32;
            this.labCelsius.Text = "攝氏(c):";
            // 
            // FormTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labCelsius);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labFahrenheit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnConvert);
            this.Name = "FormTemp";
            this.Text = "FormTemp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labFahrenheit;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labCelsius;
    }
}