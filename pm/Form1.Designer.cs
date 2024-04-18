namespace pm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnEnEmp = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tBxPasEn = new System.Windows.Forms.TextBox();
            this.tBxPhEn = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(-12, -15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 98);
            this.panel1.TabIndex = 28;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReg.ForeColor = System.Drawing.Color.Honeydew;
            this.btnReg.Location = new System.Drawing.Point(475, 143);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(127, 23);
            this.btnReg.TabIndex = 45;
            this.btnReg.Text = "Зарегистрироваться";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnEnEmp
            // 
            this.btnEnEmp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEnEmp.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnEmp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEnEmp.Location = new System.Drawing.Point(460, 431);
            this.btnEnEmp.Name = "btnEnEmp";
            this.btnEnEmp.Size = new System.Drawing.Size(142, 62);
            this.btnEnEmp.TabIndex = 47;
            this.btnEnEmp.Text = "Войти";
            this.btnEnEmp.UseVisualStyleBackColor = false;
            this.btnEnEmp.Click += new System.EventHandler(this.btnEnEmp_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(395, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 70);
            this.panel2.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(102, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "Вход";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(475, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 28);
            this.label6.TabIndex = 44;
            this.label6.Text = "Пароль";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(425, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 28);
            this.label5.TabIndex = 43;
            this.label5.Text = "Номер телефона";
            // 
            // tBxPasEn
            // 
            this.tBxPasEn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tBxPasEn.Location = new System.Drawing.Point(426, 356);
            this.tBxPasEn.Name = "tBxPasEn";
            this.tBxPasEn.Size = new System.Drawing.Size(216, 29);
            this.tBxPasEn.TabIndex = 42;
            // 
            // tBxPhEn
            // 
            this.tBxPhEn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tBxPhEn.Location = new System.Drawing.Point(425, 274);
            this.tBxPhEn.Name = "tBxPhEn";
            this.tBxPhEn.Size = new System.Drawing.Size(217, 29);
            this.tBxPhEn.TabIndex = 41;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1097, 583);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEnEmp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tBxPhEn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tBxPasEn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button btnReg;
        private Button btnEnEmp;
        private Panel panel2;
        private Label label1;
        private Label label6;
        private Label label5;
        private TextBox tBxPasEn;
        private TextBox tBxPhEn;
    }
}