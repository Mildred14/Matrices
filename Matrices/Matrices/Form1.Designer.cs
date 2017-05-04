namespace Matrices
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
            this.txt_Matriz = new System.Windows.Forms.TextBox();
            this.txtTamaño = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Crear = new System.Windows.Forms.Button();
            this.btn_Llenar = new System.Windows.Forms.Button();
            this.btn_Mostrar = new System.Windows.Forms.Button();
            this.btnColumnas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bntDiagonapPp = new System.Windows.Forms.Button();
            this.btnDiagonalSec = new System.Windows.Forms.Button();
            this.arribaPersonal = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Matriz
            // 
            this.txt_Matriz.Location = new System.Drawing.Point(277, 50);
            this.txt_Matriz.Multiline = true;
            this.txt_Matriz.Name = "txt_Matriz";
            this.txt_Matriz.Size = new System.Drawing.Size(219, 140);
            this.txt_Matriz.TabIndex = 0;
            // 
            // txtTamaño
            // 
            this.txtTamaño.Location = new System.Drawing.Point(174, 50);
            this.txtTamaño.Multiline = true;
            this.txtTamaño.Name = "txtTamaño";
            this.txtTamaño.Size = new System.Drawing.Size(72, 26);
            this.txtTamaño.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tamaño";
            // 
            // btn_Crear
            // 
            this.btn_Crear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Crear.Location = new System.Drawing.Point(94, 94);
            this.btn_Crear.Name = "btn_Crear";
            this.btn_Crear.Size = new System.Drawing.Size(75, 32);
            this.btn_Crear.TabIndex = 3;
            this.btn_Crear.Text = "Crear ";
            this.btn_Crear.UseVisualStyleBackColor = true;
            this.btn_Crear.Click += new System.EventHandler(this.btn_Crear_Click);
            // 
            // btn_Llenar
            // 
            this.btn_Llenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Llenar.Location = new System.Drawing.Point(94, 132);
            this.btn_Llenar.Name = "btn_Llenar";
            this.btn_Llenar.Size = new System.Drawing.Size(75, 32);
            this.btn_Llenar.TabIndex = 4;
            this.btn_Llenar.Text = "Llenar";
            this.btn_Llenar.UseVisualStyleBackColor = true;
            this.btn_Llenar.Click += new System.EventHandler(this.btn_Llenar_Click);
            // 
            // btn_Mostrar
            // 
            this.btn_Mostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mostrar.Location = new System.Drawing.Point(94, 170);
            this.btn_Mostrar.Name = "btn_Mostrar";
            this.btn_Mostrar.Size = new System.Drawing.Size(75, 32);
            this.btn_Mostrar.TabIndex = 5;
            this.btn_Mostrar.Text = "Mostrar";
            this.btn_Mostrar.UseVisualStyleBackColor = true;
            this.btn_Mostrar.Click += new System.EventHandler(this.btn_Mostrar_Click);
            // 
            // btnColumnas
            // 
            this.btnColumnas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColumnas.Location = new System.Drawing.Point(94, 208);
            this.btnColumnas.Name = "btnColumnas";
            this.btnColumnas.Size = new System.Drawing.Size(152, 32);
            this.btnColumnas.TabIndex = 6;
            this.btnColumnas.Text = "Llenar por Columnas";
            this.btnColumnas.UseVisualStyleBackColor = true;
            this.btnColumnas.Click += new System.EventHandler(this.btnColumnas_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(344, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Llenar renglon Inverso";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bntDiagonapPp
            // 
            this.bntDiagonapPp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntDiagonapPp.Location = new System.Drawing.Point(94, 260);
            this.bntDiagonapPp.Name = "bntDiagonapPp";
            this.bntDiagonapPp.Size = new System.Drawing.Size(198, 32);
            this.bntDiagonapPp.TabIndex = 8;
            this.bntDiagonapPp.Text = "Mostrar diagonal Principal";
            this.bntDiagonapPp.UseVisualStyleBackColor = true;
            this.bntDiagonapPp.Click += new System.EventHandler(this.bntDiagonapPp_Click);
            // 
            // btnDiagonalSec
            // 
            this.btnDiagonalSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiagonalSec.Location = new System.Drawing.Point(298, 260);
            this.btnDiagonalSec.Name = "btnDiagonalSec";
            this.btnDiagonalSec.Size = new System.Drawing.Size(198, 32);
            this.btnDiagonalSec.TabIndex = 9;
            this.btnDiagonalSec.Text = "Mostrar diagonal Secundaria";
            this.btnDiagonalSec.UseVisualStyleBackColor = true;
            this.btnDiagonalSec.Click += new System.EventHandler(this.btnDiagonalSec_Click);
            // 
            // arribaPersonal
            // 
            this.arribaPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arribaPersonal.Location = new System.Drawing.Point(94, 312);
            this.arribaPersonal.Name = "arribaPersonal";
            this.arribaPersonal.Size = new System.Drawing.Size(198, 32);
            this.arribaPersonal.TabIndex = 10;
            this.arribaPersonal.Text = "Mostrar arriba Principal";
            this.arribaPersonal.UseVisualStyleBackColor = true;
            this.arribaPersonal.Click += new System.EventHandler(this.arribaPersonal_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(298, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 32);
            this.button2.TabIndex = 11;
            this.button2.Text = "Mostrar abajo Principal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(192, 366);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 32);
            this.button3.TabIndex = 12;
            this.button3.Text = "Invertir Diagonal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 458);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.arribaPersonal);
            this.Controls.Add(this.btnDiagonalSec);
            this.Controls.Add(this.bntDiagonapPp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnColumnas);
            this.Controls.Add(this.btn_Mostrar);
            this.Controls.Add(this.btn_Llenar);
            this.Controls.Add(this.btn_Crear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTamaño);
            this.Controls.Add(this.txt_Matriz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Matriz;
        private System.Windows.Forms.TextBox txtTamaño;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Crear;
        private System.Windows.Forms.Button btn_Llenar;
        private System.Windows.Forms.Button btn_Mostrar;
        private System.Windows.Forms.Button btnColumnas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bntDiagonapPp;
        private System.Windows.Forms.Button btnDiagonalSec;
        private System.Windows.Forms.Button arribaPersonal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

