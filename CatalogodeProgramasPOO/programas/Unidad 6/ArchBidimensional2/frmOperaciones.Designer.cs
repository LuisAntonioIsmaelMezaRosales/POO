﻿namespace ArchBidimensional2
{
    partial class frmOperaciones
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
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gbxOperacion = new System.Windows.Forms.GroupBox();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.gbxMatrizBidimensional = new System.Windows.Forms.GroupBox();
            this.btnIngresarDatosB = new System.Windows.Forms.Button();
            this.btnIngresarDatosA = new System.Windows.Forms.Button();
            this.btnTamañoMatriz = new System.Windows.Forms.Button();
            this.gbxOperacion.SuspendLayout();
            this.gbxMatrizBidimensional.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(470, 108);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(22, 24);
            this.lblResultado.TabIndex = 17;
            this.lblResultado.Text = "=";
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacion.Location = new System.Drawing.Point(327, 108);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(22, 24);
            this.lblOperacion.TabIndex = 16;
            this.lblOperacion.Text = "+";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(502, 67);
            this.txtC.Multiline = true;
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 101);
            this.txtC.TabIndex = 15;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(356, 67);
            this.txtB.Multiline = true;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 101);
            this.txtB.TabIndex = 14;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(221, 67);
            this.txtA.Multiline = true;
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 101);
            this.txtA.TabIndex = 13;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(474, 273);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(474, 216);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // gbxOperacion
            // 
            this.gbxOperacion.BackColor = System.Drawing.Color.LightGreen;
            this.gbxOperacion.Controls.Add(this.btnDivision);
            this.gbxOperacion.Controls.Add(this.btnSuma);
            this.gbxOperacion.Controls.Add(this.btnResta);
            this.gbxOperacion.Controls.Add(this.btnMultiplicacion);
            this.gbxOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxOperacion.Location = new System.Drawing.Point(207, 197);
            this.gbxOperacion.Name = "gbxOperacion";
            this.gbxOperacion.Size = new System.Drawing.Size(221, 105);
            this.gbxOperacion.TabIndex = 10;
            this.gbxOperacion.TabStop = false;
            this.gbxOperacion.Text = "Operacion";
            // 
            // btnDivision
            // 
            this.btnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.Location = new System.Drawing.Point(124, 66);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(75, 23);
            this.btnDivision.TabIndex = 3;
            this.btnDivision.Text = "Division";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.Location = new System.Drawing.Point(24, 19);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(90, 23);
            this.btnSuma.TabIndex = 3;
            this.btnSuma.Text = "Suma";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnResta
            // 
            this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.Location = new System.Drawing.Point(124, 19);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(75, 23);
            this.btnResta.TabIndex = 5;
            this.btnResta.Text = "Resta";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacion.Location = new System.Drawing.Point(24, 66);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(90, 23);
            this.btnMultiplicacion.TabIndex = 4;
            this.btnMultiplicacion.Text = "Multiplicacion";
            this.btnMultiplicacion.UseVisualStyleBackColor = true;
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnMultiplicacion_Click);
            // 
            // gbxMatrizBidimensional
            // 
            this.gbxMatrizBidimensional.BackColor = System.Drawing.Color.LightSeaGreen;
            this.gbxMatrizBidimensional.Controls.Add(this.btnIngresarDatosB);
            this.gbxMatrizBidimensional.Controls.Add(this.btnIngresarDatosA);
            this.gbxMatrizBidimensional.Controls.Add(this.btnTamañoMatriz);
            this.gbxMatrizBidimensional.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMatrizBidimensional.Location = new System.Drawing.Point(15, 41);
            this.gbxMatrizBidimensional.Name = "gbxMatrizBidimensional";
            this.gbxMatrizBidimensional.Size = new System.Drawing.Size(160, 212);
            this.gbxMatrizBidimensional.TabIndex = 9;
            this.gbxMatrizBidimensional.TabStop = false;
            this.gbxMatrizBidimensional.Text = "Matriz Bidimensional";
            // 
            // btnIngresarDatosB
            // 
            this.btnIngresarDatosB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarDatosB.Location = new System.Drawing.Point(41, 144);
            this.btnIngresarDatosB.Name = "btnIngresarDatosB";
            this.btnIngresarDatosB.Size = new System.Drawing.Size(75, 37);
            this.btnIngresarDatosB.TabIndex = 2;
            this.btnIngresarDatosB.Text = "Ingresar Datos B";
            this.btnIngresarDatosB.UseVisualStyleBackColor = true;
            this.btnIngresarDatosB.Click += new System.EventHandler(this.btnIngresarDatosB_Click);
            // 
            // btnIngresarDatosA
            // 
            this.btnIngresarDatosA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarDatosA.Location = new System.Drawing.Point(41, 86);
            this.btnIngresarDatosA.Name = "btnIngresarDatosA";
            this.btnIngresarDatosA.Size = new System.Drawing.Size(75, 41);
            this.btnIngresarDatosA.TabIndex = 1;
            this.btnIngresarDatosA.Text = "Ingresar Datos A";
            this.btnIngresarDatosA.UseVisualStyleBackColor = true;
            this.btnIngresarDatosA.Click += new System.EventHandler(this.btnIngresarDatosA_Click);
            // 
            // btnTamañoMatriz
            // 
            this.btnTamañoMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTamañoMatriz.Location = new System.Drawing.Point(41, 26);
            this.btnTamañoMatriz.Name = "btnTamañoMatriz";
            this.btnTamañoMatriz.Size = new System.Drawing.Size(75, 43);
            this.btnTamañoMatriz.TabIndex = 0;
            this.btnTamañoMatriz.Text = "Tamaño Matriz";
            this.btnTamañoMatriz.UseVisualStyleBackColor = true;
            this.btnTamañoMatriz.Click += new System.EventHandler(this.btnTamañoMatriz_Click);
            // 
            // frmOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 343);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblOperacion);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbxOperacion);
            this.Controls.Add(this.gbxMatrizBidimensional);
            this.Name = "frmOperaciones";
            this.Text = "frmOperaciones";
            this.gbxOperacion.ResumeLayout(false);
            this.gbxMatrizBidimensional.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox gbxOperacion;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.GroupBox gbxMatrizBidimensional;
        private System.Windows.Forms.Button btnIngresarDatosB;
        private System.Windows.Forms.Button btnIngresarDatosA;
        private System.Windows.Forms.Button btnTamañoMatriz;
    }
}