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
            this.btnInsertarA = new System.Windows.Forms.Button();
            this.txtColumnaA = new System.Windows.Forms.TextBox();
            this.txtFilaA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMostrarA = new System.Windows.Forms.Button();
            this.btnMostrarB = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsertarA
            // 
            this.btnInsertarA.Location = new System.Drawing.Point(75, 8);
            this.btnInsertarA.Name = "btnInsertarA";
            this.btnInsertarA.Size = new System.Drawing.Size(75, 23);
            this.btnInsertarA.TabIndex = 0;
            this.btnInsertarA.Text = "Insertar";
            this.btnInsertarA.UseVisualStyleBackColor = true;
            this.btnInsertarA.Click += new System.EventHandler(this.btnInsertarA_Click);
            // 
            // txtColumnaA
            // 
            this.txtColumnaA.Location = new System.Drawing.Point(12, 91);
            this.txtColumnaA.Name = "txtColumnaA";
            this.txtColumnaA.Size = new System.Drawing.Size(35, 20);
            this.txtColumnaA.TabIndex = 3;
            // 
            // txtFilaA
            // 
            this.txtFilaA.Location = new System.Drawing.Point(12, 50);
            this.txtFilaA.Name = "txtFilaA";
            this.txtFilaA.Size = new System.Drawing.Size(35, 20);
            this.txtFilaA.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fila";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "columna";
            // 
            // btnMostrarA
            // 
            this.btnMostrarA.Location = new System.Drawing.Point(61, 163);
            this.btnMostrarA.Name = "btnMostrarA";
            this.btnMostrarA.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarA.TabIndex = 7;
            this.btnMostrarA.Text = "Mostrar";
            this.btnMostrarA.UseVisualStyleBackColor = true;
            this.btnMostrarA.Click += new System.EventHandler(this.btnMostrarA_Click);
            // 
            // btnMostrarB
            // 
            this.btnMostrarB.Location = new System.Drawing.Point(630, 176);
            this.btnMostrarB.Name = "btnMostrarB";
            this.btnMostrarB.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarB.TabIndex = 14;
            this.btnMostrarB.Text = "Mostrar";
            this.btnMostrarB.UseVisualStyleBackColor = true;
            this.btnMostrarB.Click += new System.EventHandler(this.btnMostrarB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(581, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "columna";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(581, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fila";
            // 
            // txtFilaB
            // 
            this.txtFilaB.Location = new System.Drawing.Point(581, 63);
            this.txtFilaB.Name = "txtFilaB";
            this.txtFilaB.Size = new System.Drawing.Size(35, 20);
            this.txtFilaB.TabIndex = 11;
            // 
            // txtComulnaB
            // 
            this.txtComulnaB.Location = new System.Drawing.Point(581, 104);
            this.txtComulnaB.Name = "txtComulnaB";
            this.txtComulnaB.Size = new System.Drawing.Size(35, 20);
            this.txtComulnaB.TabIndex = 10;
            // 
            // btnInsertarB
            // 
            this.btnInsertarB.Location = new System.Drawing.Point(644, 21);
            this.btnInsertarB.Name = "btnInsertarB";
            this.btnInsertarB.Size = new System.Drawing.Size(75, 23);
            this.btnInsertarB.TabIndex = 8;
            this.btnInsertarB.Text = "Insertar";
            this.btnInsertarB.UseVisualStyleBackColor = true;
            this.btnInsertarB.Click += new System.EventHandler(this.btnInsertarB_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(224, 270);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 21;
            this.button5.Text = "Sumar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(411, 270);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 22;
            this.button6.Text = "Multiplicar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(323, 270);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 23;
            this.button7.Text = "Restar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "matriz A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(778, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Matriz B";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(331, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Matriz resultante";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(284, 115);
            this.dataGridView1.TabIndex = 29;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(634, 50);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(284, 115);
            this.dataGridView2.TabIndex = 30;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(226, 325);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(284, 115);
            this.dataGridView3.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 481);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnMostrarB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFilaB);
            this.Controls.Add(this.txtComulnaB);
            this.Controls.Add(this.btnInsertarB);
            this.Controls.Add(this.btnMostrarA);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertarA;
        private System.Windows.Forms.TextBox txtColumnaA;
        private System.Windows.Forms.TextBox txtFilaA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMostrarA;
        private System.Windows.Forms.Button btnMostrarB;
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
    }
}

