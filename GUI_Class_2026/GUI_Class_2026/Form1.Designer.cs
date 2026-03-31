namespace GUI_Class_2026
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
            this.lab_ChangeLabel = new System.Windows.Forms.Label();
            this.btn_ChangeLabel = new System.Windows.Forms.Button();
            this.btn_Counter = new System.Windows.Forms.Button();
            this.lab_Counter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Thistle;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "B04170082-阿文";
            // 
            // btn_ClickMe
            // 
            this.btn_ClickMe.Location = new System.Drawing.Point(23, 96);
            this.btn_ClickMe.Name = "btn_ClickMe";
            this.btn_ClickMe.Size = new System.Drawing.Size(204, 65);
            this.btn_ClickMe.TabIndex = 1;
            this.btn_ClickMe.Text = "按我一下";
            this.btn_ClickMe.UseVisualStyleBackColor = true;
            this.btn_ClickMe.Click += new System.EventHandler(this.btn_ClickMe_Click);
            // 
            // lab_ChangeLabel
            // 
            this.lab_ChangeLabel.AutoSize = true;
            this.lab_ChangeLabel.Font = new System.Drawing.Font("新細明體", 20F);
            this.lab_ChangeLabel.Location = new System.Drawing.Point(153, 193);
            this.lab_ChangeLabel.Name = "lab_ChangeLabel";
            this.lab_ChangeLabel.Size = new System.Drawing.Size(74, 27);
            this.lab_ChangeLabel.TabIndex = 2;
            this.lab_ChangeLabel.Text = "label2";
            // 
            // btn_ChangeLabel
            // 
            this.btn_ChangeLabel.Location = new System.Drawing.Point(23, 193);
            this.btn_ChangeLabel.Name = "btn_ChangeLabel";
            this.btn_ChangeLabel.Size = new System.Drawing.Size(107, 34);
            this.btn_ChangeLabel.TabIndex = 3;
            this.btn_ChangeLabel.Text = "按我切換標籤";
            this.btn_ChangeLabel.UseVisualStyleBackColor = true;
            this.btn_ChangeLabel.Click += new System.EventHandler(this.btn_ChangeLabel_Click);
            // 
            // btn_Counter
            // 
            this.btn_Counter.Location = new System.Drawing.Point(23, 247);
            this.btn_Counter.Name = "btn_Counter";
            this.btn_Counter.Size = new System.Drawing.Size(107, 34);
            this.btn_Counter.TabIndex = 5;
            this.btn_Counter.Text = "按我加1";
            this.btn_Counter.UseVisualStyleBackColor = true;
            this.btn_Counter.Click += new System.EventHandler(this.btn_Counter_Click);
            // 
            // lab_Counter
            // 
            this.lab_Counter.AutoSize = true;
            this.lab_Counter.Font = new System.Drawing.Font("新細明體", 20F);
            this.lab_Counter.Location = new System.Drawing.Point(153, 247);
            this.lab_Counter.Name = "lab_Counter";
            this.lab_Counter.Size = new System.Drawing.Size(25, 27);
            this.lab_Counter.TabIndex = 4;
            this.lab_Counter.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Counter);
            this.Controls.Add(this.lab_Counter);
            this.Controls.Add(this.btn_ChangeLabel);
            this.Controls.Add(this.lab_ChangeLabel);
            this.Controls.Add(this.btn_ClickMe);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ClickMe;
        private System.Windows.Forms.Label lab_ChangeLabel;
        private System.Windows.Forms.Button btn_ChangeLabel;
        private System.Windows.Forms.Button btn_Counter;
        private System.Windows.Forms.Label lab_Counter;
    }
}

