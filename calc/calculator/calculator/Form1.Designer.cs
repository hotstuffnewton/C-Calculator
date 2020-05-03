namespace WindowsFormsApplication1
{
    partial class Calculator
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnBksp = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnMclr = new System.Windows.Forms.Button();
            this.btnMrec = new System.Windows.Forms.Button();
            this.btnMsub = new System.Windows.Forms.Button();
            this.btnMadd = new System.Windows.Forms.Button();
            this.btndp = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(220, 250);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 45);
            this.btnAdd.TabIndex = 47;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(220, 97);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(65, 45);
            this.btnDiv.TabIndex = 46;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(220, 148);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(65, 45);
            this.btnMult.TabIndex = 45;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(220, 199);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(65, 45);
            this.btnSub.TabIndex = 44;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(291, 199);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(65, 96);
            this.btnEquals.TabIndex = 43;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnBksp
            // 
            this.btnBksp.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnBksp.Location = new System.Drawing.Point(291, 148);
            this.btnBksp.Name = "btnBksp";
            this.btnBksp.Size = new System.Drawing.Size(65, 45);
            this.btnBksp.TabIndex = 42;
            this.btnBksp.Text = "f";
            this.btnBksp.UseVisualStyleBackColor = true;
            this.btnBksp.Click += new System.EventHandler(this.btnBksp_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClear.Location = new System.Drawing.Point(291, 97);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(65, 45);
            this.btnClear.TabIndex = 41;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSign
            // 
            this.btnSign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSign.Location = new System.Drawing.Point(291, 32);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(65, 45);
            this.btnSign.TabIndex = 40;
            this.btnSign.Text = "+/-";
            this.btnSign.UseVisualStyleBackColor = false;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnMclr
            // 
            this.btnMclr.BackColor = System.Drawing.Color.Teal;
            this.btnMclr.Location = new System.Drawing.Point(220, 32);
            this.btnMclr.Name = "btnMclr";
            this.btnMclr.Size = new System.Drawing.Size(65, 45);
            this.btnMclr.TabIndex = 39;
            this.btnMclr.Text = "mc";
            this.btnMclr.UseVisualStyleBackColor = false;
            this.btnMclr.Click += new System.EventHandler(this.btnMclr_Click);
            // 
            // btnMrec
            // 
            this.btnMrec.BackColor = System.Drawing.Color.Teal;
            this.btnMrec.Location = new System.Drawing.Point(149, 32);
            this.btnMrec.Name = "btnMrec";
            this.btnMrec.Size = new System.Drawing.Size(65, 45);
            this.btnMrec.TabIndex = 38;
            this.btnMrec.Text = "mr";
            this.btnMrec.UseVisualStyleBackColor = false;
            this.btnMrec.Click += new System.EventHandler(this.btnMrec_Click);
            // 
            // btnMsub
            // 
            this.btnMsub.BackColor = System.Drawing.Color.Teal;
            this.btnMsub.Location = new System.Drawing.Point(78, 32);
            this.btnMsub.Name = "btnMsub";
            this.btnMsub.Size = new System.Drawing.Size(65, 45);
            this.btnMsub.TabIndex = 37;
            this.btnMsub.Text = "m-";
            this.btnMsub.UseVisualStyleBackColor = false;
            this.btnMsub.Click += new System.EventHandler(this.btnMsub_Click);
            // 
            // btnMadd
            // 
            this.btnMadd.BackColor = System.Drawing.Color.Teal;
            this.btnMadd.Location = new System.Drawing.Point(7, 32);
            this.btnMadd.Name = "btnMadd";
            this.btnMadd.Size = new System.Drawing.Size(65, 45);
            this.btnMadd.TabIndex = 36;
            this.btnMadd.Text = "m+";
            this.btnMadd.UseVisualStyleBackColor = false;
            this.btnMadd.Click += new System.EventHandler(this.btnMadd_Click);
            // 
            // btndp
            // 
            this.btndp.Font = new System.Drawing.Font("Webdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btndp.Location = new System.Drawing.Point(149, 250);
            this.btndp.Name = "btndp";
            this.btndp.Size = new System.Drawing.Size(65, 45);
            this.btndp.TabIndex = 35;
            this.btndp.Text = "n";
            this.btndp.UseVisualStyleBackColor = true;
            this.btndp.Click += new System.EventHandler(this.btndp_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(7, 250);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(136, 45);
            this.btn0.TabIndex = 34;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(149, 97);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(65, 45);
            this.btn9.TabIndex = 33;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(78, 97);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(65, 45);
            this.btn8.TabIndex = 32;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(7, 97);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(65, 45);
            this.btn7.TabIndex = 31;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(149, 148);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(65, 45);
            this.btn6.TabIndex = 30;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(78, 148);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(65, 45);
            this.btn5.TabIndex = 29;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(7, 148);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(65, 45);
            this.btn4.TabIndex = 28;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(149, 199);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(65, 45);
            this.btn3.TabIndex = 27;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(78, 199);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(65, 45);
            this.btn2.TabIndex = 26;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(7, 199);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(65, 45);
            this.btn1.TabIndex = 25;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtDisplay.ForeColor = System.Drawing.Color.MintCream;
            this.txtDisplay.Location = new System.Drawing.Point(7, 6);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(349, 20);
            this.txtDisplay.TabIndex = 24;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(359, 297);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnBksp);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.btnMclr);
            this.Controls.Add(this.btnMrec);
            this.Controls.Add(this.btnMsub);
            this.Controls.Add(this.btnMadd);
            this.Controls.Add(this.btndp);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.Text = "c# calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnBksp;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnMclr;
        private System.Windows.Forms.Button btnMrec;
        private System.Windows.Forms.Button btnMsub;
        private System.Windows.Forms.Button btnMadd;
        private System.Windows.Forms.Button btndp;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtDisplay;
    }
}

