namespace M03UF5PR1
{
    partial class RescatForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.idAnimal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.animalId = new System.Windows.Forms.Label();
            this.localitzacio = new System.Windows.Forms.Label();
            this.ga = new System.Windows.Forms.Label();
            this.especie = new System.Windows.Forms.Label();
            this.dataRescat = new System.Windows.Forms.Label();
            this.numRescat = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorNom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorOfici = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorNom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorOfici)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "USUARI";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(92, 137);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "OFICI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "NOM";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numRescat);
            this.groupBox2.Controls.Add(this.dataRescat);
            this.groupBox2.Controls.Add(this.especie);
            this.groupBox2.Controls.Add(this.ga);
            this.groupBox2.Controls.Add(this.localitzacio);
            this.groupBox2.Controls.Add(this.animalId);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Location = new System.Drawing.Point(286, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 239);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RESCAT";
            // 
            // idAnimal
            // 
            this.idAnimal.AutoSize = true;
            this.idAnimal.Location = new System.Drawing.Point(210, 216);
            this.idAnimal.Name = "idAnimal";
            this.idAnimal.Size = new System.Drawing.Size(0, 16);
            this.idAnimal.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 7;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 36);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 16);
            this.label20.TabIndex = 8;
            this.label20.Text = "ID ANIMAL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "LOCALITZACIÓ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "GRAU D\'AFECTACIÓ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "ESPÈCIE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "DATA RESCAT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "NUMERO RESCAT";
            // 
            // animalId
            // 
            this.animalId.AutoSize = true;
            this.animalId.Location = new System.Drawing.Point(282, 36);
            this.animalId.Name = "animalId";
            this.animalId.Size = new System.Drawing.Size(0, 16);
            this.animalId.TabIndex = 14;
            // 
            // localitzacio
            // 
            this.localitzacio.AutoSize = true;
            this.localitzacio.Location = new System.Drawing.Point(254, 66);
            this.localitzacio.Name = "localitzacio";
            this.localitzacio.Size = new System.Drawing.Size(0, 16);
            this.localitzacio.TabIndex = 15;
            // 
            // ga
            // 
            this.ga.AutoSize = true;
            this.ga.Location = new System.Drawing.Point(217, 94);
            this.ga.Name = "ga";
            this.ga.Size = new System.Drawing.Size(0, 16);
            this.ga.TabIndex = 16;
            // 
            // especie
            // 
            this.especie.AutoSize = true;
            this.especie.Location = new System.Drawing.Point(290, 125);
            this.especie.Name = "especie";
            this.especie.Size = new System.Drawing.Size(0, 16);
            this.especie.TabIndex = 17;
            // 
            // dataRescat
            // 
            this.dataRescat.AutoSize = true;
            this.dataRescat.Location = new System.Drawing.Point(252, 152);
            this.dataRescat.Name = "dataRescat";
            this.dataRescat.Size = new System.Drawing.Size(0, 16);
            this.dataRescat.TabIndex = 18;
            // 
            // numRescat
            // 
            this.numRescat.AutoSize = true;
            this.numRescat.Location = new System.Drawing.Point(229, 179);
            this.numRescat.Name = "numRescat";
            this.numRescat.Size = new System.Drawing.Size(0, 16);
            this.numRescat.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 64);
            this.button1.TabIndex = 8;
            this.button1.Text = "RESCATAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(360, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 64);
            this.button2.TabIndex = 9;
            this.button2.Text = "ENRERE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorNom
            // 
            this.errorNom.ContainerControl = this;
            // 
            // errorOfici
            // 
            this.errorOfici.ContainerControl = this;
            // 
            // RescatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 404);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idAnimal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "RescatForm";
            this.Text = "RescatForm";
            this.Load += new System.EventHandler(this.RescatForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorNom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorOfici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label idAnimal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label numRescat;
        private System.Windows.Forms.Label dataRescat;
        private System.Windows.Forms.Label especie;
        private System.Windows.Forms.Label ga;
        private System.Windows.Forms.Label localitzacio;
        private System.Windows.Forms.Label animalId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorNom;
        private System.Windows.Forms.ErrorProvider errorOfici;
    }
}