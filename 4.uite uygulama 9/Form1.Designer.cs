namespace _4.uite_uygulama_9
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
            this.txtDiziSatirSayisi = new System.Windows.Forms.TextBox();
            this.txtRasgeleEnbuyukSAyısı = new System.Windows.Forms.TextBox();
            this.txtRAsgeleEndusukSayı = new System.Windows.Forms.TextBox();
            this.txtDiziSutunSayısı = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtDiziSatirSayisi
            // 
            this.txtDiziSatirSayisi.Location = new System.Drawing.Point(169, 28);
            this.txtDiziSatirSayisi.Name = "txtDiziSatirSayisi";
            this.txtDiziSatirSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtDiziSatirSayisi.TabIndex = 0;
            // 
            // txtRasgeleEnbuyukSAyısı
            // 
            this.txtRasgeleEnbuyukSAyısı.Location = new System.Drawing.Point(160, 199);
            this.txtRasgeleEnbuyukSAyısı.Name = "txtRasgeleEnbuyukSAyısı";
            this.txtRasgeleEnbuyukSAyısı.Size = new System.Drawing.Size(100, 20);
            this.txtRasgeleEnbuyukSAyısı.TabIndex = 1;
            // 
            // txtRAsgeleEndusukSayı
            // 
            this.txtRAsgeleEndusukSayı.Location = new System.Drawing.Point(160, 141);
            this.txtRAsgeleEndusukSayı.Name = "txtRAsgeleEndusukSayı";
            this.txtRAsgeleEndusukSayı.Size = new System.Drawing.Size(100, 20);
            this.txtRAsgeleEndusukSayı.TabIndex = 2;
            // 
            // txtDiziSutunSayısı
            // 
            this.txtDiziSutunSayısı.Location = new System.Drawing.Point(160, 87);
            this.txtDiziSutunSayısı.Name = "txtDiziSutunSayısı";
            this.txtDiziSutunSayısı.Size = new System.Drawing.Size(100, 20);
            this.txtDiziSutunSayısı.TabIndex = 3;
            this.txtDiziSutunSayısı.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "dizi satır sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "RasgeleEnbuyukSAyısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "RAsgeleEndusukSayı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "dizi sutun sayısı";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "dizi olustur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(430, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "dizi goster";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(385, 76);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiziSutunSayısı);
            this.Controls.Add(this.txtRAsgeleEndusukSayı);
            this.Controls.Add(this.txtRasgeleEnbuyukSAyısı);
            this.Controls.Add(this.txtDiziSatirSayisi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDiziSatirSayisi;
        private System.Windows.Forms.TextBox txtRasgeleEnbuyukSAyısı;
        private System.Windows.Forms.TextBox txtRAsgeleEndusukSayı;
        private System.Windows.Forms.TextBox txtDiziSutunSayısı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
    }
}

