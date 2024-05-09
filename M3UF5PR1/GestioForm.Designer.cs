using System.Drawing;

namespace M03UF5PR1
{
    partial class GestioForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inserirPes = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.inserirEspecie = new System.Windows.Forms.TextBox();
            this.inserirNom = new System.Windows.Forms.TextBox();
            this.inserirId = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.actualitzarEspecie = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.actualitzarPes = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.actualitzarNom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Borrar = new System.Windows.Forms.Button();
            this.errorNom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPes = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorText = new System.Windows.Forms.ErrorProvider(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.errorEspecie = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorId = new System.Windows.Forms.ErrorProvider(this.components);
            this.inserirSuperfamilia = new System.Windows.Forms.ComboBox();
            this.actualitzarSuperfamilia = new System.Windows.Forms.ComboBox();
            this.actualitzarId = new System.Windows.Forms.ComboBox();
            this.borrarId = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorNom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEspecie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorId)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inserirSuperfamilia);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.inserirPes);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INSERIR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Superfamilia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Espècie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pes";
            // 
            // inserirPes
            // 
            this.inserirPes.Location = new System.Drawing.Point(146, 295);
            this.inserirPes.Name = "inserirPes";
            this.inserirPes.Size = new System.Drawing.Size(125, 22);
            this.inserirPes.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 47);
            this.button1.TabIndex = 10;
            this.button1.Text = "INSERIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inserirEspecie
            // 
            this.inserirEspecie.Location = new System.Drawing.Point(158, 273);
            this.inserirEspecie.Name = "inserirEspecie";
            this.inserirEspecie.Size = new System.Drawing.Size(125, 22);
            this.inserirEspecie.TabIndex = 7;
            // 
            // inserirNom
            // 
            this.inserirNom.Location = new System.Drawing.Point(158, 112);
            this.inserirNom.Name = "inserirNom";
            this.inserirNom.Size = new System.Drawing.Size(125, 22);
            this.inserirNom.TabIndex = 6;
            // 
            // inserirId
            // 
            this.inserirId.Location = new System.Drawing.Point(158, 55);
            this.inserirId.Name = "inserirId";
            this.inserirId.Size = new System.Drawing.Size(124, 22);
            this.inserirId.TabIndex = 5;
            this.inserirId.Text = " ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.actualitzarId);
            this.groupBox2.Controls.Add(this.actualitzarSuperfamilia);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.actualitzarEspecie);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.actualitzarPes);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.actualitzarNom);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(390, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ACTUALITZAR";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "Pes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Espècie";
            // 
            // actualitzarEspecie
            // 
            this.actualitzarEspecie.Location = new System.Drawing.Point(158, 255);
            this.actualitzarEspecie.Name = "actualitzarEspecie";
            this.actualitzarEspecie.Size = new System.Drawing.Size(125, 22);
            this.actualitzarEspecie.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Superfamilia";
            // 
            // actualitzarPes
            // 
            this.actualitzarPes.Location = new System.Drawing.Point(158, 292);
            this.actualitzarPes.Name = "actualitzarPes";
            this.actualitzarPes.Size = new System.Drawing.Size(125, 22);
            this.actualitzarPes.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(134, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 44);
            this.button2.TabIndex = 20;
            this.button2.Text = "ACTUALITZAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Nom";
            // 
            // actualitzarNom
            // 
            this.actualitzarNom.Location = new System.Drawing.Point(158, 100);
            this.actualitzarNom.Name = "actualitzarNom";
            this.actualitzarNom.Size = new System.Drawing.Size(125, 22);
            this.actualitzarNom.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "ID";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.borrarId);
            this.groupBox3.Controls.Add(this.Borrar);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(768, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(372, 162);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BORRAR";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(57, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "ID";
            // 
            // Borrar
            // 
            this.Borrar.Location = new System.Drawing.Point(130, 100);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(107, 44);
            this.Borrar.TabIndex = 28;
            this.Borrar.Text = "BORRAR";
            this.Borrar.UseVisualStyleBackColor = true;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // errorNom
            // 
            this.errorNom.ContainerControl = this;
            // 
            // errorPes
            // 
            this.errorPes.ContainerControl = this;
            // 
            // errorText
            // 
            this.errorText.ContainerControl = this;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(325, 453);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 64);
            this.button3.TabIndex = 11;
            this.button3.Text = "ENRERE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // errorEspecie
            // 
            this.errorEspecie.ContainerControl = this;
            // 
            // errorId
            // 
            this.errorId.ContainerControl = this;
            // 
            // inserirSuperfamilia
            // 
            this.inserirSuperfamilia.FormattingEnabled = true;
            this.inserirSuperfamilia.Location = new System.Drawing.Point(146, 160);
            this.inserirSuperfamilia.Name = "inserirSuperfamilia";
            this.inserirSuperfamilia.Size = new System.Drawing.Size(121, 24);
            this.inserirSuperfamilia.TabIndex = 9;
            // 
            // actualitzarSuperfamilia
            // 
            this.actualitzarSuperfamilia.FormattingEnabled = true;
            this.actualitzarSuperfamilia.Location = new System.Drawing.Point(158, 157);
            this.actualitzarSuperfamilia.Name = "actualitzarSuperfamilia";
            this.actualitzarSuperfamilia.Size = new System.Drawing.Size(121, 24);
            this.actualitzarSuperfamilia.TabIndex = 10;
            // 
            // actualitzarId
            // 
            this.actualitzarId.FormattingEnabled = true;
            this.actualitzarId.Location = new System.Drawing.Point(158, 46);
            this.actualitzarId.Name = "actualitzarId";
            this.actualitzarId.Size = new System.Drawing.Size(125, 24);
            this.actualitzarId.TabIndex = 27;
            // 
            // borrarId
            // 
            this.borrarId.FormattingEnabled = true;
            this.borrarId.Location = new System.Drawing.Point(130, 46);
            this.borrarId.Name = "borrarId";
            this.borrarId.Size = new System.Drawing.Size(125, 24);
            this.borrarId.TabIndex = 28;
            // 
            // GestioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 527);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.inserirId);
            this.Controls.Add(this.inserirNom);
            this.Controls.Add(this.inserirEspecie);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "GestioForm";
            this.Text = "GestioForm";
            this.Load += new System.EventHandler(this.GestioForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorNom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEspecie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inserirPes;
        private System.Windows.Forms.TextBox inserirEspecie;
        private System.Windows.Forms.TextBox inserirNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inserirId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox actualitzarPes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox actualitzarNom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox actualitzarEspecie;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.ErrorProvider errorNom;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ErrorProvider errorPes;
        private System.Windows.Forms.ErrorProvider errorText;
        private System.Windows.Forms.ErrorProvider errorEspecie;
        private System.Windows.Forms.ErrorProvider errorId;
        private System.Windows.Forms.ComboBox actualitzarSuperfamilia;
        private System.Windows.Forms.ComboBox inserirSuperfamilia;
        private System.Windows.Forms.ComboBox actualitzarId;
        private System.Windows.Forms.ComboBox borrarId;
    }
}