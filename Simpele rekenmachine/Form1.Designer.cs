
namespace Simpele_rekenmachine
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
            this.lblGetal1 = new System.Windows.Forms.Label();
            this.lblGetal2 = new System.Windows.Forms.Label();
            this.lblUitkomst = new System.Windows.Forms.Label();
            this.lblSom = new System.Windows.Forms.Label();
            this.tbGetal1 = new System.Windows.Forms.TextBox();
            this.tbGetal2 = new System.Windows.Forms.TextBox();
            this.tbUitkomst = new System.Windows.Forms.TextBox();
            this.tbSom = new System.Windows.Forms.TextBox();
            this.gbActie = new System.Windows.Forms.GroupBox();
            this.rbWortel = new System.Windows.Forms.RadioButton();
            this.rbKwadraad = new System.Windows.Forms.RadioButton();
            this.rbDelen = new System.Windows.Forms.RadioButton();
            this.rbVermenigvuldigen = new System.Windows.Forms.RadioButton();
            this.rbAftrekken = new System.Windows.Forms.RadioButton();
            this.rbOptellen = new System.Windows.Forms.RadioButton();
            this.btnBereken = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEvenGetallen = new System.Windows.Forms.RadioButton();
            this.rbFibonaccieReeks = new System.Windows.Forms.RadioButton();
            this.rbPriemGetallen = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbActie.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGetal1
            // 
            this.lblGetal1.AutoSize = true;
            this.lblGetal1.Location = new System.Drawing.Point(105, 54);
            this.lblGetal1.Name = "lblGetal1";
            this.lblGetal1.Size = new System.Drawing.Size(41, 13);
            this.lblGetal1.TabIndex = 0;
            this.lblGetal1.Text = "Getal 1";
            // 
            // lblGetal2
            // 
            this.lblGetal2.AutoSize = true;
            this.lblGetal2.Location = new System.Drawing.Point(105, 80);
            this.lblGetal2.Name = "lblGetal2";
            this.lblGetal2.Size = new System.Drawing.Size(41, 13);
            this.lblGetal2.TabIndex = 1;
            this.lblGetal2.Text = "Getal 2";
            // 
            // lblUitkomst
            // 
            this.lblUitkomst.AutoSize = true;
            this.lblUitkomst.Location = new System.Drawing.Point(98, 106);
            this.lblUitkomst.Name = "lblUitkomst";
            this.lblUitkomst.Size = new System.Drawing.Size(48, 13);
            this.lblUitkomst.TabIndex = 2;
            this.lblUitkomst.Text = "Uitkomst";
            // 
            // lblSom
            // 
            this.lblSom.AutoSize = true;
            this.lblSom.Location = new System.Drawing.Point(115, 132);
            this.lblSom.Name = "lblSom";
            this.lblSom.Size = new System.Drawing.Size(31, 13);
            this.lblSom.TabIndex = 3;
            this.lblSom.Text = "Som ";
            // 
            // tbGetal1
            // 
            this.tbGetal1.Location = new System.Drawing.Point(166, 51);
            this.tbGetal1.Name = "tbGetal1";
            this.tbGetal1.Size = new System.Drawing.Size(100, 20);
            this.tbGetal1.TabIndex = 4;
            // 
            // tbGetal2
            // 
            this.tbGetal2.Location = new System.Drawing.Point(166, 77);
            this.tbGetal2.Name = "tbGetal2";
            this.tbGetal2.Size = new System.Drawing.Size(100, 20);
            this.tbGetal2.TabIndex = 5;
            // 
            // tbUitkomst
            // 
            this.tbUitkomst.Location = new System.Drawing.Point(166, 103);
            this.tbUitkomst.Name = "tbUitkomst";
            this.tbUitkomst.ReadOnly = true;
            this.tbUitkomst.Size = new System.Drawing.Size(100, 20);
            this.tbUitkomst.TabIndex = 6;
            // 
            // tbSom
            // 
            this.tbSom.Location = new System.Drawing.Point(166, 129);
            this.tbSom.Name = "tbSom";
            this.tbSom.ReadOnly = true;
            this.tbSom.Size = new System.Drawing.Size(100, 20);
            this.tbSom.TabIndex = 7;
            // 
            // gbActie
            // 
            this.gbActie.Controls.Add(this.rbWortel);
            this.gbActie.Controls.Add(this.rbKwadraad);
            this.gbActie.Controls.Add(this.rbDelen);
            this.gbActie.Controls.Add(this.rbVermenigvuldigen);
            this.gbActie.Controls.Add(this.rbAftrekken);
            this.gbActie.Controls.Add(this.rbOptellen);
            this.gbActie.Location = new System.Drawing.Point(308, 51);
            this.gbActie.Name = "gbActie";
            this.gbActie.Size = new System.Drawing.Size(142, 173);
            this.gbActie.TabIndex = 8;
            this.gbActie.TabStop = false;
            this.gbActie.Text = "Actie";
            // 
            // rbWortel
            // 
            this.rbWortel.AutoSize = true;
            this.rbWortel.Location = new System.Drawing.Point(18, 139);
            this.rbWortel.Name = "rbWortel";
            this.rbWortel.Size = new System.Drawing.Size(56, 17);
            this.rbWortel.TabIndex = 5;
            this.rbWortel.TabStop = true;
            this.rbWortel.Text = "Wortel";
            this.rbWortel.UseVisualStyleBackColor = true;
            // 
            // rbKwadraad
            // 
            this.rbKwadraad.AutoSize = true;
            this.rbKwadraad.Location = new System.Drawing.Point(18, 116);
            this.rbKwadraad.Name = "rbKwadraad";
            this.rbKwadraad.Size = new System.Drawing.Size(73, 17);
            this.rbKwadraad.TabIndex = 4;
            this.rbKwadraad.TabStop = true;
            this.rbKwadraad.Text = "Kwadraad";
            this.rbKwadraad.UseVisualStyleBackColor = true;
            // 
            // rbDelen
            // 
            this.rbDelen.AutoSize = true;
            this.rbDelen.Location = new System.Drawing.Point(18, 93);
            this.rbDelen.Name = "rbDelen";
            this.rbDelen.Size = new System.Drawing.Size(53, 17);
            this.rbDelen.TabIndex = 3;
            this.rbDelen.TabStop = true;
            this.rbDelen.Text = "Delen";
            this.rbDelen.UseVisualStyleBackColor = true;
            // 
            // rbVermenigvuldigen
            // 
            this.rbVermenigvuldigen.AutoSize = true;
            this.rbVermenigvuldigen.Location = new System.Drawing.Point(18, 70);
            this.rbVermenigvuldigen.Name = "rbVermenigvuldigen";
            this.rbVermenigvuldigen.Size = new System.Drawing.Size(109, 17);
            this.rbVermenigvuldigen.TabIndex = 2;
            this.rbVermenigvuldigen.TabStop = true;
            this.rbVermenigvuldigen.Text = "Vermenigvuldigen";
            this.rbVermenigvuldigen.UseVisualStyleBackColor = true;
            // 
            // rbAftrekken
            // 
            this.rbAftrekken.AutoSize = true;
            this.rbAftrekken.Location = new System.Drawing.Point(18, 47);
            this.rbAftrekken.Name = "rbAftrekken";
            this.rbAftrekken.Size = new System.Drawing.Size(71, 17);
            this.rbAftrekken.TabIndex = 1;
            this.rbAftrekken.TabStop = true;
            this.rbAftrekken.Text = "Aftrekken";
            this.rbAftrekken.UseVisualStyleBackColor = true;
            // 
            // rbOptellen
            // 
            this.rbOptellen.AutoSize = true;
            this.rbOptellen.Location = new System.Drawing.Point(18, 24);
            this.rbOptellen.Name = "rbOptellen";
            this.rbOptellen.Size = new System.Drawing.Size(64, 17);
            this.rbOptellen.TabIndex = 0;
            this.rbOptellen.TabStop = true;
            this.rbOptellen.Text = "Optellen";
            this.rbOptellen.UseVisualStyleBackColor = true;
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(166, 155);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(100, 23);
            this.btnBereken.TabIndex = 9;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPriemGetallen);
            this.groupBox1.Controls.Add(this.rbFibonaccieReeks);
            this.groupBox1.Controls.Add(this.rbEvenGetallen);
            this.groupBox1.Location = new System.Drawing.Point(75, 302);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rbEvenGetallen
            // 
            this.rbEvenGetallen.AutoSize = true;
            this.rbEvenGetallen.Location = new System.Drawing.Point(7, 20);
            this.rbEvenGetallen.Name = "rbEvenGetallen";
            this.rbEvenGetallen.Size = new System.Drawing.Size(154, 17);
            this.rbEvenGetallen.TabIndex = 0;
            this.rbEvenGetallen.TabStop = true;
            this.rbEvenGetallen.Text = "Even getallen (25 getallen) ";
            this.rbEvenGetallen.UseVisualStyleBackColor = true;
            // 
            // rbFibonaccieReeks
            // 
            this.rbFibonaccieReeks.AutoSize = true;
            this.rbFibonaccieReeks.Location = new System.Drawing.Point(7, 43);
            this.rbFibonaccieReeks.Name = "rbFibonaccieReeks";
            this.rbFibonaccieReeks.Size = new System.Drawing.Size(161, 17);
            this.rbFibonaccieReeks.TabIndex = 1;
            this.rbFibonaccieReeks.TabStop = true;
            this.rbFibonaccieReeks.Text = "Fibonacci reeks (10 getallen)";
            this.rbFibonaccieReeks.UseVisualStyleBackColor = true;
            // 
            // rbPriemGetallen
            // 
            this.rbPriemGetallen.AutoSize = true;
            this.rbPriemGetallen.Location = new System.Drawing.Point(6, 66);
            this.rbPriemGetallen.Name = "rbPriemGetallen";
            this.rbPriemGetallen.Size = new System.Drawing.Size(152, 17);
            this.rbPriemGetallen.TabIndex = 2;
            this.rbPriemGetallen.TabStop = true;
            this.rbPriemGetallen.Text = "Priem getallen (10 getallen)";
            this.rbPriemGetallen.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(308, 302);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(436, 100);
            this.textBox1.TabIndex = 11;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(669, 408);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.gbActie);
            this.Controls.Add(this.tbSom);
            this.Controls.Add(this.tbUitkomst);
            this.Controls.Add(this.tbGetal2);
            this.Controls.Add(this.tbGetal1);
            this.Controls.Add(this.lblSom);
            this.Controls.Add(this.lblUitkomst);
            this.Controls.Add(this.lblGetal2);
            this.Controls.Add(this.lblGetal1);
            this.Name = "Form1";
            this.Text = "M";
            this.gbActie.ResumeLayout(false);
            this.gbActie.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGetal1;
        private System.Windows.Forms.Label lblGetal2;
        private System.Windows.Forms.Label lblUitkomst;
        private System.Windows.Forms.Label lblSom;
        private System.Windows.Forms.TextBox tbGetal1;
        private System.Windows.Forms.TextBox tbGetal2;
        private System.Windows.Forms.TextBox tbUitkomst;
        private System.Windows.Forms.TextBox tbSom;
        private System.Windows.Forms.GroupBox gbActie;
        private System.Windows.Forms.RadioButton rbWortel;
        private System.Windows.Forms.RadioButton rbKwadraad;
        private System.Windows.Forms.RadioButton rbDelen;
        private System.Windows.Forms.RadioButton rbVermenigvuldigen;
        private System.Windows.Forms.RadioButton rbAftrekken;
        private System.Windows.Forms.RadioButton rbOptellen;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPriemGetallen;
        private System.Windows.Forms.RadioButton rbFibonaccieReeks;
        private System.Windows.Forms.RadioButton rbEvenGetallen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnExit;
    }
}

