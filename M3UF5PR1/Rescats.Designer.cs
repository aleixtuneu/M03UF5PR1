namespace M03UF5PR1
{
    partial class Rescats
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumRescat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRescat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localitzacio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceRescat = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.location = new System.Windows.Forms.Label();
            this.grauAfectacio = new System.Windows.Forms.Label();
            this.animalID = new System.Windows.Forms.Label();
            this.rescueDate = new System.Windows.Forms.Label();
            this.rescueNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorComboBox = new System.Windows.Forms.ErrorProvider(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRescat)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorComboBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "ENRERE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 360);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RESCATS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NumRescat,
            this.dataRescat,
            this.Animal,
            this.Ga,
            this.Localitzacio});
            this.dataGridView1.Location = new System.Drawing.Point(6, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(414, 276);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // NumRescat
            // 
            this.NumRescat.HeaderText = "Numero Rescat";
            this.NumRescat.MinimumWidth = 6;
            this.NumRescat.Name = "NumRescat";
            this.NumRescat.Width = 125;
            // 
            // dataRescat
            // 
            this.dataRescat.HeaderText = "Data Rescat";
            this.dataRescat.MinimumWidth = 6;
            this.dataRescat.Name = "dataRescat";
            this.dataRescat.Width = 125;
            // 
            // Animal
            // 
            this.Animal.HeaderText = "Animal";
            this.Animal.MinimumWidth = 6;
            this.Animal.Name = "Animal";
            this.Animal.Width = 125;
            // 
            // Ga
            // 
            this.Ga.HeaderText = "Grau d\'Afectació";
            this.Ga.MinimumWidth = 6;
            this.Ga.Name = "Ga";
            this.Ga.Width = 125;
            // 
            // Localitzacio
            // 
            this.Localitzacio.HeaderText = "Localitzacio";
            this.Localitzacio.MinimumWidth = 6;
            this.Localitzacio.Name = "Localitzacio";
            this.Localitzacio.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.rescueNum);
            this.groupBox2.Controls.Add(this.rescueDate);
            this.groupBox2.Controls.Add(this.animalID);
            this.groupBox2.Controls.Add(this.grauAfectacio);
            this.groupBox2.Controls.Add(this.location);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(454, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 360);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BUSCAR PER ID";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(185, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(78, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // location
            // 
            this.location.AutoSize = true;
            this.location.Location = new System.Drawing.Point(219, 112);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(44, 16);
            this.location.TabIndex = 1;
            this.location.Text = "label1";
            // 
            // grauAfectacio
            // 
            this.grauAfectacio.AutoSize = true;
            this.grauAfectacio.Location = new System.Drawing.Point(219, 140);
            this.grauAfectacio.Name = "grauAfectacio";
            this.grauAfectacio.Size = new System.Drawing.Size(44, 16);
            this.grauAfectacio.TabIndex = 2;
            this.grauAfectacio.Text = "label1";
            // 
            // animalID
            // 
            this.animalID.AutoSize = true;
            this.animalID.Location = new System.Drawing.Point(219, 167);
            this.animalID.Name = "animalID";
            this.animalID.Size = new System.Drawing.Size(44, 16);
            this.animalID.TabIndex = 3;
            this.animalID.Text = "label1";
            // 
            // rescueDate
            // 
            this.rescueDate.AutoSize = true;
            this.rescueDate.Location = new System.Drawing.Point(219, 195);
            this.rescueDate.Name = "rescueDate";
            this.rescueDate.Size = new System.Drawing.Size(44, 16);
            this.rescueDate.TabIndex = 4;
            this.rescueDate.Text = "label1";
            // 
            // rescueNum
            // 
            this.rescueNum.AutoSize = true;
            this.rescueNum.Location = new System.Drawing.Point(219, 224);
            this.rescueNum.Name = "rescueNum";
            this.rescueNum.Size = new System.Drawing.Size(44, 16);
            this.rescueNum.TabIndex = 5;
            this.rescueNum.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "LOCALITZACIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "GRAU AFECTACIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID ANIMAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "DATA RESCAT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "NUM RESCAT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "ID";
            // 
            // errorComboBox
            // 
            this.errorComboBox.ContainerControl = this;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 36);
            this.button2.TabIndex = 12;
            this.button2.Text = "SELECCIONAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Rescats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Rescats";
            this.Text = "Rescats";
            this.Load += new System.EventHandler(this.Rescats_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRescat)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorComboBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumRescat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRescat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localitzacio;
        private System.Windows.Forms.BindingSource bindingSourceRescat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label location;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rescueNum;
        private System.Windows.Forms.Label rescueDate;
        private System.Windows.Forms.Label animalID;
        private System.Windows.Forms.Label grauAfectacio;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorComboBox;
    }
}