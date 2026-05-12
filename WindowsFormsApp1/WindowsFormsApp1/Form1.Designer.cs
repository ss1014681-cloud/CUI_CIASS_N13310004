namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ClickMe = new System.Windows.Forms.Button();
            this.btn_ChangeLabel = new System.Windows.Forms.Button();
            this.lab_ChangLabel = new System.Windows.Forms.Label();
            this.lab_Counter = new System.Windows.Forms.Label();
            this.btn_Counter = new System.Windows.Forms.Button();
            this.btnBigger = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(51, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "N13310004";
            // 
            // btn_ClickMe
            // 
            this.btn_ClickMe.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClickMe.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_ClickMe.Location = new System.Drawing.Point(42, 83);
            this.btn_ClickMe.Name = "btn_ClickMe";
            this.btn_ClickMe.Size = new System.Drawing.Size(143, 54);
            this.btn_ClickMe.TabIndex = 1;
            this.btn_ClickMe.Text = "按我一下";
            this.btn_ClickMe.UseVisualStyleBackColor = true;
            this.btn_ClickMe.Click += new System.EventHandler(this.btn_ClickMe_Click);
            // 
            // btn_ChangeLabel
            // 
            this.btn_ChangeLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.btn_ChangeLabel.Location = new System.Drawing.Point(42, 171);
            this.btn_ChangeLabel.Name = "btn_ChangeLabel";
            this.btn_ChangeLabel.Size = new System.Drawing.Size(143, 23);
            this.btn_ChangeLabel.TabIndex = 2;
            this.btn_ChangeLabel.Text = "按我切換標籤";
            this.btn_ChangeLabel.UseVisualStyleBackColor = true;
            this.btn_ChangeLabel.Click += new System.EventHandler(this.btn_ChangeLabel_Click);
            // 
            // lab_ChangLabel
            // 
            this.lab_ChangLabel.AutoSize = true;
            this.lab_ChangLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.lab_ChangLabel.Location = new System.Drawing.Point(247, 171);
            this.lab_ChangLabel.Name = "lab_ChangLabel";
            this.lab_ChangLabel.Size = new System.Drawing.Size(45, 16);
            this.lab_ChangLabel.TabIndex = 3;
            this.lab_ChangLabel.Text = "label2";
            // 
            // lab_Counter
            // 
            this.lab_Counter.AutoSize = true;
            this.lab_Counter.Font = new System.Drawing.Font("新細明體", 12F);
            this.lab_Counter.Location = new System.Drawing.Point(261, 240);
            this.lab_Counter.Name = "lab_Counter";
            this.lab_Counter.Size = new System.Drawing.Size(15, 16);
            this.lab_Counter.TabIndex = 5;
            this.lab_Counter.Text = "0";
            // 
            // btn_Counter
            // 
            this.btn_Counter.Font = new System.Drawing.Font("新細明體", 12F);
            this.btn_Counter.Location = new System.Drawing.Point(42, 237);
            this.btn_Counter.Name = "btn_Counter";
            this.btn_Counter.Size = new System.Drawing.Size(143, 23);
            this.btn_Counter.TabIndex = 4;
            this.btn_Counter.Text = "按我加1";
            this.btn_Counter.UseVisualStyleBackColor = true;
            this.btn_Counter.Click += new System.EventHandler(this.btn_Counter_Click);
            // 
            // btnBigger
            // 
            this.btnBigger.Location = new System.Drawing.Point(200, 83);
            this.btnBigger.Name = "btnBigger";
            this.btnBigger.Size = new System.Drawing.Size(128, 54);
            this.btnBigger.TabIndex = 6;
            this.btnBigger.Text = "按鈕放大";
            this.btnBigger.UseVisualStyleBackColor = true;
            this.btnBigger.Click += new System.EventHandler(this.btnBigger_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "按我複製至串到Label";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 309);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // btnCalculator
            // 
            this.btnCalculator.Location = new System.Drawing.Point(344, 83);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(124, 54);
            this.btnCalculator.TabIndex = 10;
            this.btnCalculator.Text = "計算機";
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "0";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(42, 375);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "加1";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(280, 375);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 23);
            this.btnMinus.TabIndex = 13;
            this.btnMinus.Text = "減1";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(490, 83);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(123, 54);
            this.btn.TabIndex = 20;
            this.btn.Text = "攝氏華氏度";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 585);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBigger);
            this.Controls.Add(this.lab_Counter);
            this.Controls.Add(this.btn_Counter);
            this.Controls.Add(this.lab_ChangLabel);
            this.Controls.Add(this.btn_ChangeLabel);
            this.Controls.Add(this.btn_ClickMe);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ClickMe;
        private System.Windows.Forms.Button btn_ChangeLabel;
        private System.Windows.Forms.Label lab_ChangLabel;
        private System.Windows.Forms.Label lab_Counter;
        private System.Windows.Forms.Button btn_Counter;
        private System.Windows.Forms.Button btnBigger;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btn;
    }
}

