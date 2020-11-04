namespace calculadora_de_matrices
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
         {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnInsertarA = new System.Windows.Forms.Button();
            this.txtColumnaA = new System.Windows.Forms.TextBox();
            this.txtFilaA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFilaB = new System.Windows.Forms.TextBox();
            this.txtComulnaB = new System.Windows.Forms.TextBox();
            this.btnInsertarB = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnEscalar = new System.Windows.Forms.Button();
            this.txtEscalar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsertarA
            // 
            this.btnInsertarA.Location = new System.Drawing.Point(183, 21);
            this.btnInsertarA.Name = "btnInsertarA";
            this.btnInsertarA.Size = new System.Drawing.Size(75, 23);
            this.btnInsertarA.TabIndex = 0;
            this.btnInsertarA.Text = "Insertar";
            this.btnInsertarA.UseVisualStyleBackColor = true;
            this.btnInsertarA.Click += new System.EventHandler(this.btnInsertarA_Click);
            // 
            // txtColumnaA
            // 
            this.txtColumnaA.Location = new System.Drawing.Point(120, 104);
            this.txtColumnaA.Name = "txtColumnaA";
            this.txtColumnaA.Size = new System.Drawing.Size(35, 20);
            this.txtColumnaA.TabIndex = 3;
            // 
            // txtFilaA
            // 
            this.txtFilaA.Location = new System.Drawing.Point(120, 63);
            this.txtFilaA.Name = "txtFilaA";
            this.txtFilaA.Size = new System.Drawing.Size(35, 20);
            this.txtFilaA.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fila";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "columna";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(576, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "columna";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(576, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fila";
            // 
            // txtFilaB
            // 
            this.txtFilaB.Location = new System.Drawing.Point(576, 64);
            this.txtFilaB.Name = "txtFilaB";
            this.txtFilaB.Size = new System.Drawing.Size(35, 20);
            this.txtFilaB.TabIndex = 11;
            // 
            // txtComulnaB
            // 
            this.txtComulnaB.Location = new System.Drawing.Point(576, 105);
            this.txtComulnaB.Name = "txtComulnaB";
            this.txtComulnaB.Size = new System.Drawing.Size(35, 20);
            this.txtComulnaB.TabIndex = 10;
            // 
            // btnInsertarB
            // 
            this.btnInsertarB.Location = new System.Drawing.Point(639, 22);
            this.btnInsertarB.Name = "btnInsertarB";
            this.btnInsertarB.Size = new System.Drawing.Size(75, 23);
            this.btnInsertarB.TabIndex = 8;
            this.btnInsertarB.Text = "Insertar";
            this.btnInsertarB.UseVisualStyleBackColor = true;
            this.btnInsertarB.Click += new System.EventHandler(this.btnInsertarB_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(301, 216);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 42);
            this.button5.TabIndex = 21;
            this.button5.Text = "Sumar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(301, 333);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(76, 42);
            this.button6.TabIndex = 22;
            this.button6.Text = "Multiplicar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(301, 275);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 42);
            this.button7.TabIndex = 23;
            this.button7.Text = "Restar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(280, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Matriz A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(734, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Matriz B";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(476, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Matriz resultante";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(169, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(284, 115);
            this.dataGridView1.TabIndex = 29;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(629, 51);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(284, 115);
            this.dataGridView2.TabIndex = 30;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(430, 275);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(284, 115);
            this.dataGridView3.TabIndex = 31;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // btnEscalar
            // 
            this.btnEscalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscalar.Location = new System.Drawing.Point(301, 396);
            this.btnEscalar.Name = "btnEscalar";
            this.btnEscalar.Size = new System.Drawing.Size(62, 42);
            this.btnEscalar.TabIndex = 33;
            this.btnEscalar.Text = "Escalar";
            this.btnEscalar.UseVisualStyleBackColor = true;
            this.btnEscalar.Click += new System.EventHandler(this.btnEscalar_Click);
            // 
            // txtEscalar
            // 
            this.txtEscalar.Location = new System.Drawing.Point(374, 408);
            this.txtEscalar.Name = "txtEscalar";
            this.txtEscalar.Size = new System.Drawing.Size(35, 20);
            this.txtEscalar.TabIndex = 32;
            this.txtEscalar.TextChanged += new System.EventHandler(this.txtEscalar_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 172);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 302);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1002, 481);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEscalar);
            this.Controls.Add(this.txtEscalar);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFilaB);
            this.Controls.Add(this.txtComulnaB);
            this.Controls.Add(this.btnInsertarB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilaA);
            this.Controls.Add(this.txtColumnaA);
            this.Controls.Add(this.btnInsertarA);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertarA;
        private System.Windows.Forms.TextBox txtColumnaA;
        private System.Windows.Forms.TextBox txtFilaA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFilaB;
        private System.Windows.Forms.TextBox txtComulnaB;
        private System.Windows.Forms.Button btnInsertarB;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnEscalar;
        private System.Windows.Forms.TextBox txtEscalar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

