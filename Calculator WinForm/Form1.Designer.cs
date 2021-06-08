
namespace Calculator_WinForm
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
            this.ResultTxtBox = new System.Windows.Forms.TextBox();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.btnfraction = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btnminus = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btnv = new System.Windows.Forms.Button();
            this.Btnsubs = new System.Windows.Forms.Button();
            this.BtnSum = new System.Windows.Forms.Button();
            this.Btnequal = new System.Windows.Forms.Button();
            this.Btnb = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.Btnf = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResultTxtBox
            // 
            this.ResultTxtBox.BackColor = System.Drawing.Color.White;
            this.ResultTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTxtBox.Location = new System.Drawing.Point(0, 30);
            this.ResultTxtBox.Multiline = true;
            this.ResultTxtBox.Name = "ResultTxtBox";
            this.ResultTxtBox.Size = new System.Drawing.Size(335, 51);
            this.ResultTxtBox.TabIndex = 0;
            this.ResultTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Btn7
            // 
            this.Btn7.BackColor = System.Drawing.SystemColors.Info;
            this.Btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn7.Location = new System.Drawing.Point(0, 177);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(70, 55);
            this.Btn7.TabIndex = 1;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.NumbersClick);
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.SystemColors.Info;
            this.Btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.Location = new System.Drawing.Point(174, 330);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(70, 55);
            this.Btn3.TabIndex = 2;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.NumbersClick);
            // 
            // Btn4
            // 
            this.Btn4.BackColor = System.Drawing.SystemColors.Info;
            this.Btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4.Location = new System.Drawing.Point(-1, 250);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(70, 55);
            this.Btn4.TabIndex = 3;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.NumbersClick);
            // 
            // btnfraction
            // 
            this.btnfraction.BackColor = System.Drawing.SystemColors.Info;
            this.btnfraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfraction.Location = new System.Drawing.Point(174, 404);
            this.btnfraction.Name = "btnfraction";
            this.btnfraction.Size = new System.Drawing.Size(70, 55);
            this.btnfraction.TabIndex = 4;
            this.btnfraction.Text = ",";
            this.btnfraction.UseVisualStyleBackColor = false;
            this.btnfraction.Click += new System.EventHandler(this.NumbersClick);
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.SystemColors.Info;
            this.Btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.Location = new System.Drawing.Point(-1, 329);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(70, 55);
            this.Btn1.TabIndex = 5;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.NumbersClick);
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.SystemColors.Info;
            this.Btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.Location = new System.Drawing.Point(85, 329);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(70, 55);
            this.Btn2.TabIndex = 6;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.NumbersClick);
            // 
            // Btnminus
            // 
            this.Btnminus.BackColor = System.Drawing.SystemColors.Info;
            this.Btnminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnminus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btnminus.Location = new System.Drawing.Point(-1, 404);
            this.Btnminus.Name = "Btnminus";
            this.Btnminus.Size = new System.Drawing.Size(70, 55);
            this.Btnminus.TabIndex = 7;
            this.Btnminus.Text = "+/-";
            this.Btnminus.UseVisualStyleBackColor = false;
            this.Btnminus.Click += new System.EventHandler(this.NumbersClick);
            // 
            // Btn0
            // 
            this.Btn0.BackColor = System.Drawing.SystemColors.Info;
            this.Btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn0.Location = new System.Drawing.Point(85, 404);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(70, 55);
            this.Btn0.TabIndex = 8;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = false;
            this.Btn0.Click += new System.EventHandler(this.NumbersClick);
            // 
            // Btn5
            // 
            this.Btn5.BackColor = System.Drawing.SystemColors.Info;
            this.Btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn5.Location = new System.Drawing.Point(85, 250);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(70, 55);
            this.Btn5.TabIndex = 9;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.NumbersClick);
            // 
            // Btn6
            // 
            this.Btn6.BackColor = System.Drawing.SystemColors.Info;
            this.Btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn6.Location = new System.Drawing.Point(174, 250);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(70, 55);
            this.Btn6.TabIndex = 10;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.NumbersClick);
            // 
            // Btn8
            // 
            this.Btn8.BackColor = System.Drawing.SystemColors.Info;
            this.Btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn8.Location = new System.Drawing.Point(85, 177);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(70, 55);
            this.Btn8.TabIndex = 11;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.NumbersClick);
            // 
            // Btn9
            // 
            this.Btn9.BackColor = System.Drawing.SystemColors.Info;
            this.Btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn9.Location = new System.Drawing.Point(174, 177);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(70, 55);
            this.Btn9.TabIndex = 12;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.NumbersClick);
            // 
            // Btnv
            // 
            this.Btnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnv.Location = new System.Drawing.Point(264, 177);
            this.Btnv.Name = "Btnv";
            this.Btnv.Size = new System.Drawing.Size(70, 55);
            this.Btnv.TabIndex = 13;
            this.Btnv.Text = "*";
            this.Btnv.UseVisualStyleBackColor = true;
            this.Btnv.Click += new System.EventHandler(this.oppress);
            // 
            // Btnsubs
            // 
            this.Btnsubs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnsubs.Location = new System.Drawing.Point(264, 250);
            this.Btnsubs.Name = "Btnsubs";
            this.Btnsubs.Size = new System.Drawing.Size(70, 55);
            this.Btnsubs.TabIndex = 14;
            this.Btnsubs.Text = "-";
            this.Btnsubs.UseVisualStyleBackColor = true;
            this.Btnsubs.Click += new System.EventHandler(this.oppress);
            // 
            // BtnSum
            // 
            this.BtnSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSum.Location = new System.Drawing.Point(264, 330);
            this.BtnSum.Name = "BtnSum";
            this.BtnSum.Size = new System.Drawing.Size(70, 55);
            this.BtnSum.TabIndex = 15;
            this.BtnSum.Text = "+";
            this.BtnSum.UseVisualStyleBackColor = true;
            this.BtnSum.Click += new System.EventHandler(this.oppress);
            // 
            // Btnequal
            // 
            this.Btnequal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btnequal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnequal.Location = new System.Drawing.Point(264, 404);
            this.Btnequal.Name = "Btnequal";
            this.Btnequal.Size = new System.Drawing.Size(70, 55);
            this.Btnequal.TabIndex = 16;
            this.Btnequal.Text = "=";
            this.Btnequal.UseVisualStyleBackColor = false;
            this.Btnequal.Click += new System.EventHandler(this.op_result);
            // 
            // Btnb
            // 
            this.Btnb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnb.Location = new System.Drawing.Point(264, 106);
            this.Btnb.Name = "Btnb";
            this.Btnb.Size = new System.Drawing.Size(70, 55);
            this.Btnb.TabIndex = 17;
            this.Btnb.Text = "/";
            this.Btnb.UseVisualStyleBackColor = true;
            this.Btnb.Click += new System.EventHandler(this.oppress);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(-1, 106);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(70, 55);
            this.btnclear.TabIndex = 18;
            this.btnclear.Text = "C";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Btnf
            // 
            this.Btnf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnf.Location = new System.Drawing.Point(174, 106);
            this.Btnf.Name = "Btnf";
            this.Btnf.Size = new System.Drawing.Size(70, 55);
            this.Btnf.TabIndex = 19;
            this.Btnf.Text = "<--";
            this.Btnf.UseVisualStyleBackColor = true;
            this.Btnf.Click += new System.EventHandler(this.Btnf_Click);
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(85, 106);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(70, 55);
            this.button20.TabIndex = 20;
            this.button20.Text = "CE";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(260, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(334, 466);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.Btnf);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.Btnb);
            this.Controls.Add(this.Btnequal);
            this.Controls.Add(this.BtnSum);
            this.Controls.Add(this.Btnsubs);
            this.Controls.Add(this.Btnv);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.Btnminus);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.btnfraction);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.ResultTxtBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximumSize = new System.Drawing.Size(350, 505);
            this.MinimumSize = new System.Drawing.Size(350, 505);
            this.Name = "Form1";
            this.Text = "Basic Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ResultTxtBox;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button btnfraction;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btnminus;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btnv;
        private System.Windows.Forms.Button Btnsubs;
        private System.Windows.Forms.Button BtnSum;
        private System.Windows.Forms.Button Btnequal;
        private System.Windows.Forms.Button Btnb;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button Btnf;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Label label1;
    }
}

