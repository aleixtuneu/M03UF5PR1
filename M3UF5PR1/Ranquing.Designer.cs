using M03UF5PR1.Models.DTOs;

namespace M03UF5PR1
{
    partial class Ranquing
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSourcePersona = new System.Windows.Forms.BindingSource(this.components);
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumRescat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ofici = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePersona)).BeginInit();
            this.SuspendLayout();
            // 
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.NumRescat,
            this.Ofici,
            this.XP});
            this.dataGridView1.DataSource = this.bindingSourcePersona;
            this.dataGridView1.Location = new System.Drawing.Point(12, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(549, 197);
            this.dataGridView1.TabIndex = 0;
            // 
            // Nom
            // 
            this.Nom.DataPropertyName = "Nom";
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 6;
            this.Nom.Name = "Nom";
            this.Nom.Width = 125;
            // 
            // NumRescat
            // 
            this.NumRescat.DataPropertyName = "NumRescat";
            this.NumRescat.HeaderText = "Numero Rescat";
            this.NumRescat.MinimumWidth = 6;
            this.NumRescat.Name = "NumRescat";
            this.NumRescat.Width = 125;
            // 
            // Ofici
            // 
            this.Ofici.DataPropertyName = "Ofici";
            this.Ofici.HeaderText = "Ofici";
            this.Ofici.MinimumWidth = 6;
            this.Ofici.Name = "Ofici";
            this.Ofici.Width = 125;
            // 
            // XP
            // 
            this.XP.HeaderText = "XP";
            this.XP.MinimumWidth = 6;
            this.XP.Name = "XP";
            this.XP.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "RANQUING";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 64);
            this.button1.TabIndex = 4;
            this.button1.Text = "ENRERE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ranquing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 887);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Ranquing";
            this.Text = "Ranquing";
            this.Load += new System.EventHandler(this.Ranquing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePersona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.BindingSource bindingSourcePersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumRescat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ofici;
        private System.Windows.Forms.DataGridViewTextBoxColumn XP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}