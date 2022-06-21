namespace pr25_26
{
    partial class frmain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btMS2016 = new System.Windows.Forms.Button();
            this.btHLM = new System.Windows.Forms.Button();
            this.btBMR = new System.Windows.Forms.Button();
            this.btBMI = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 54);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(227, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "MARATHON SKILLS 2016";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Demi", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(225, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(570, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "ИНФОРМАЦИЯ О MARATHON SKILLS 2016";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(-2, 622);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1012, 59);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(298, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(408, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "18 дней 8 часов и 17 минут до старта марафона!";
            // 
            // btMS2016
            // 
            this.btMS2016.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btMS2016.Location = new System.Drawing.Point(225, 218);
            this.btMS2016.Name = "btMS2016";
            this.btMS2016.Size = new System.Drawing.Size(234, 95);
            this.btMS2016.TabIndex = 2;
            this.btMS2016.Text = "Marathon Skills 2016";
            this.btMS2016.UseVisualStyleBackColor = true;
            this.btMS2016.Click += new System.EventHandler(this.btMS2016_Click);
            // 
            // btHLM
            // 
            this.btHLM.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btHLM.Location = new System.Drawing.Point(561, 218);
            this.btHLM.Name = "btHLM";
            this.btHLM.Size = new System.Drawing.Size(234, 95);
            this.btHLM.TabIndex = 4;
            this.btHLM.Text = "Насколько долгий марафон";
            this.btHLM.UseVisualStyleBackColor = true;
            // 
            // btBMR
            // 
            this.btBMR.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btBMR.Location = new System.Drawing.Point(561, 384);
            this.btBMR.Name = "btBMR";
            this.btBMR.Size = new System.Drawing.Size(234, 95);
            this.btBMR.TabIndex = 5;
            this.btBMR.Text = "BMR калькулятор";
            this.btBMR.UseVisualStyleBackColor = true;
            this.btBMR.Click += new System.EventHandler(this.btBMR_Click);
            // 
            // btBMI
            // 
            this.btBMI.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btBMI.Location = new System.Drawing.Point(225, 384);
            this.btBMI.Name = "btBMI";
            this.btBMI.Size = new System.Drawing.Size(234, 95);
            this.btBMI.TabIndex = 6;
            this.btBMI.Text = "BMI калькулятор";
            this.btBMI.UseVisualStyleBackColor = true;
            this.btBMI.Click += new System.EventHandler(this.btBMI_Click);
            // 
            // frmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.btBMI);
            this.Controls.Add(this.btBMR);
            this.Controls.Add(this.btHLM);
            this.Controls.Add(this.btMS2016);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmain";
            this.Text = "Marathon Skills 2016 - Find out more information";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private Button btMS2016;
        private Button btHLM;
        private Button btBMR;
        private Button btBMI;
    }
}