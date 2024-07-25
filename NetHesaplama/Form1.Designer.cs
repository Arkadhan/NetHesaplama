
namespace NetHesaplama
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTurkceDogru = new System.Windows.Forms.TextBox();
            this.tbTurkceYanlis = new System.Windows.Forms.TextBox();
            this.tbTurkceNet = new System.Windows.Forms.TextBox();
            this.tbMatNet = new System.Windows.Forms.TextBox();
            this.tbMatYanlis = new System.Windows.Forms.TextBox();
            this.tbMatDoğru = new System.Windows.Forms.TextBox();
            this.btNetHesapla = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btNetHesapla);
            this.groupBox1.Controls.Add(this.tbMatNet);
            this.groupBox1.Controls.Add(this.tbMatYanlis);
            this.groupBox1.Controls.Add(this.tbMatDoğru);
            this.groupBox1.Controls.Add(this.tbTurkceNet);
            this.groupBox1.Controls.Add(this.tbTurkceYanlis);
            this.groupBox1.Controls.Add(this.tbTurkceDogru);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(45, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sınav Neti Hesaplama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Türkçe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matematik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doğru";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yanlış";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Net";
            // 
            // tbTurkceDogru
            // 
            this.tbTurkceDogru.Location = new System.Drawing.Point(172, 51);
            this.tbTurkceDogru.Name = "tbTurkceDogru";
            this.tbTurkceDogru.Size = new System.Drawing.Size(66, 20);
            this.tbTurkceDogru.TabIndex = 5;
            // 
            // tbTurkceYanlis
            // 
            this.tbTurkceYanlis.Location = new System.Drawing.Point(264, 51);
            this.tbTurkceYanlis.Name = "tbTurkceYanlis";
            this.tbTurkceYanlis.Size = new System.Drawing.Size(66, 20);
            this.tbTurkceYanlis.TabIndex = 6;
            // 
            // tbTurkceNet
            // 
            this.tbTurkceNet.Location = new System.Drawing.Point(352, 51);
            this.tbTurkceNet.Name = "tbTurkceNet";
            this.tbTurkceNet.ReadOnly = true;
            this.tbTurkceNet.Size = new System.Drawing.Size(66, 20);
            this.tbTurkceNet.TabIndex = 7;
            // 
            // tbMatNet
            // 
            this.tbMatNet.Location = new System.Drawing.Point(352, 84);
            this.tbMatNet.Name = "tbMatNet";
            this.tbMatNet.ReadOnly = true;
            this.tbMatNet.Size = new System.Drawing.Size(66, 20);
            this.tbMatNet.TabIndex = 10;
            // 
            // tbMatYanlis
            // 
            this.tbMatYanlis.Location = new System.Drawing.Point(264, 84);
            this.tbMatYanlis.Name = "tbMatYanlis";
            this.tbMatYanlis.Size = new System.Drawing.Size(66, 20);
            this.tbMatYanlis.TabIndex = 9;
            // 
            // tbMatDoğru
            // 
            this.tbMatDoğru.Location = new System.Drawing.Point(172, 84);
            this.tbMatDoğru.Name = "tbMatDoğru";
            this.tbMatDoğru.Size = new System.Drawing.Size(66, 20);
            this.tbMatDoğru.TabIndex = 8;
            // 
            // btNetHesapla
            // 
            this.btNetHesapla.Location = new System.Drawing.Point(172, 135);
            this.btNetHesapla.Name = "btNetHesapla";
            this.btNetHesapla.Size = new System.Drawing.Size(246, 23);
            this.btNetHesapla.TabIndex = 11;
            this.btNetHesapla.Text = "Net Hesapla";
            this.btNetHesapla.UseVisualStyleBackColor = true;
            this.btNetHesapla.Click += new System.EventHandler(this.btNetHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 272);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Net Hesaplama";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btNetHesapla;
        private System.Windows.Forms.TextBox tbMatNet;
        private System.Windows.Forms.TextBox tbMatYanlis;
        private System.Windows.Forms.TextBox tbMatDoğru;
        private System.Windows.Forms.TextBox tbTurkceNet;
        private System.Windows.Forms.TextBox tbTurkceYanlis;
        private System.Windows.Forms.TextBox tbTurkceDogru;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

