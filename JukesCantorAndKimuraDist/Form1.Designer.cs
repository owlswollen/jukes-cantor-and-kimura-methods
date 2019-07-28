namespace JukesCantorAndKimuraDist
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSeq1 = new System.Windows.Forms.TextBox();
            this.textBoxSeq2 = new System.Windows.Forms.TextBox();
            this.radioButtonJC = new System.Windows.Forms.RadioButton();
            this.radioButtonKimura = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(41, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "SEQ1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(41, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "SEQ2:";
            // 
            // textBoxSeq1
            // 
            this.textBoxSeq1.Location = new System.Drawing.Point(119, 44);
            this.textBoxSeq1.Name = "textBoxSeq1";
            this.textBoxSeq1.Size = new System.Drawing.Size(431, 22);
            this.textBoxSeq1.TabIndex = 2;
            // 
            // textBoxSeq2
            // 
            this.textBoxSeq2.Location = new System.Drawing.Point(119, 86);
            this.textBoxSeq2.Name = "textBoxSeq2";
            this.textBoxSeq2.Size = new System.Drawing.Size(431, 22);
            this.textBoxSeq2.TabIndex = 3;
            // 
            // radioButtonJC
            // 
            this.radioButtonJC.AllowDrop = true;
            this.radioButtonJC.AutoSize = true;
            this.radioButtonJC.Checked = true;
            this.radioButtonJC.Location = new System.Drawing.Point(23, 30);
            this.radioButtonJC.Name = "radioButtonJC";
            this.radioButtonJC.Size = new System.Drawing.Size(113, 21);
            this.radioButtonJC.TabIndex = 4;
            this.radioButtonJC.TabStop = true;
            this.radioButtonJC.Text = "Jukes-Cantor";
            this.radioButtonJC.UseVisualStyleBackColor = true;
            // 
            // radioButtonKimura
            // 
            this.radioButtonKimura.AutoSize = true;
            this.radioButtonKimura.Location = new System.Drawing.Point(23, 71);
            this.radioButtonKimura.Name = "radioButtonKimura";
            this.radioButtonKimura.Size = new System.Drawing.Size(73, 21);
            this.radioButtonKimura.TabIndex = 5;
            this.radioButtonKimura.Text = "Kimura";
            this.radioButtonKimura.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonJC);
            this.groupBox1.Controls.Add(this.radioButtonKimura);
            this.groupBox1.Location = new System.Drawing.Point(113, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 108);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Distance Model";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(328, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 55);
            this.button1.TabIndex = 7;
            this.button1.Text = "CALCULATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(266, 39);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(153, 22);
            this.textBoxResult.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(177, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Result:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxSeq1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxSeq2);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(25, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(603, 286);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBoxResult);
            this.groupBox3.Location = new System.Drawing.Point(25, 341);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(603, 100);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 484);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Location = new System.Drawing.Point(150, 100);
            this.Name = "Form1";
            this.Text = "Jukes-Cantor & Kimura Distances";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSeq1;
        private System.Windows.Forms.TextBox textBoxSeq2;
        private System.Windows.Forms.RadioButton radioButtonJC;
        private System.Windows.Forms.RadioButton radioButtonKimura;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

