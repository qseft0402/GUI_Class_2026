namespace GUI_Class_2026
{
    partial class FormMidC2F
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
            this.btnCauC2F = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labResult = new System.Windows.Forms.Label();
            this.tbC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCauC2F
            // 
            this.btnCauC2F.Location = new System.Drawing.Point(185, 186);
            this.btnCauC2F.Name = "btnCauC2F";
            this.btnCauC2F.Size = new System.Drawing.Size(75, 23);
            this.btnCauC2F.TabIndex = 0;
            this.btnCauC2F.Text = "計算";
            this.btnCauC2F.UseVisualStyleBackColor = true;
            this.btnCauC2F.Click += new System.EventHandler(this.btnCauC2F_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "攝氏C:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "華氏F:";
            // 
            // labResult
            // 
            this.labResult.AutoSize = true;
            this.labResult.Location = new System.Drawing.Point(183, 232);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(137, 12);
            this.labResult.TabIndex = 3;
            this.labResult.Text = "請輸入攝氏按下計算案紐";
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(185, 158);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(100, 22);
            this.tbC.TabIndex = 4;
            // 
            // FormMidC2F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbC);
            this.Controls.Add(this.labResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCauC2F);
            this.Name = "FormMidC2F";
            this.Text = "FormMidC2F";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCauC2F;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labResult;
        private System.Windows.Forms.TextBox tbC;
    }
}