﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2ArregloObjetosPaisesYColores
{
    public partial class frmDatosPaises : Form
    {
        Pais[] ArrayPais;
        int Contador;
        int Index;
        private int CantidadPaises;
        private int encuentra = 0;
        public frmDatosPaises()
        {
            InitializeComponent();

            gbxIntroducirDatos.Enabled = false;
            gbxBuscarPais.Enabled = false;
        }
        
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void gbxBuscarPais_Enter(object sender, EventArgs e)
        {

        }
        private void btnListo_Click(object sender, EventArgs e)
        {
            CantidadPaises = Convert.ToInt16(txtCantidadPaises.Text);
            ArrayPais = new Pais[CantidadPaises];
            Contador = 0;
            gbxIntroducirDatos.Enabled = true;
            btnListo.Enabled = false;
            txtCantidadPaises.Enabled = false;
            gbxBuscarPais.Enabled = false;
            MessageBox.Show("Listo se definio la cantidad de paises a introducir", "Paises", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //secccion para verficar que todos los datos del programa son datos validos
            if (txtNombrePais.Text == "")
            {
                errorProvider1.SetError(txtNombrePais, "Introduce el nombre del pais");
                txtNombrePais.Focus();
                return;
            }
            errorProvider1.SetError(txtNombrePais, "");

            //Verificar si los datos introducidos de poblacion son numericos y positivos
            decimal verificar;
            if (!Decimal.TryParse(txtTotalPoblacion.Text, out verificar))
            {
                errorProvider1.SetError(txtTotalPoblacion, "Debe introducir datos numericos");
                txtTotalPoblacion.Focus();
                return;
            }
            errorProvider1.SetError(txtTotalPoblacion, "");

            if (verificar <= 0)
            {
                errorProvider1.SetError(txtTotalPoblacion, "Introduzca datos validos (numeros positivos)");
                txtTotalPoblacion.Focus();
                return;
            }
            errorProvider1.SetError(txtTotalPoblacion, "");

            //secccion para verficar que todos los datos del programa son datos validos
            if (txtIdiomaPredominante.Text == "")
            {
                errorProvider1.SetError(txtIdiomaPredominante, "Introduce el idioma predominante del pais");
                txtIdiomaPredominante.Focus();
                return;
            }
            errorProvider1.SetError(txtIdiomaPredominante, "");

            if (txtColor1.Text == "")
            {
                errorProvider1.SetError(txtColor1, "Introduce el primer color del pais");
                txtColor1.Focus();
                return;
            }
            errorProvider1.SetError(txtColor1, "");

            if (txtColor2.Text == "")
            {
                errorProvider1.SetError(txtColor2, "Introduce el segundo color del pais, sino cuenta con uno coloca (Sin color)");
                txtColor2.Focus();
                return;
            }
            errorProvider1.SetError(txtColor2, "");

            if (txtColor3.Text == "")
            {
                errorProvider1.SetError(txtColor3, "Introduce el tercer color del pais, sino cuenta con uno coloca (Sin color)");
                txtColor3.Focus();
                return;
            }
            errorProvider1.SetError(txtColor3, "");


            
            if(Contador<ArrayPais.Length)
            {
                ArrayPais[Contador] = new Pais();
                ArrayPais[Contador].NombrePais = txtNombrePais.Text;
                ArrayPais[Contador].TotalPoblacion = Convert.ToInt32(txtTotalPoblacion.Text);
                ArrayPais[Contador].IdiomaPredominante = txtIdiomaPredominante.Text;
                //introducir el tamaño del arreglo de los colores de la bandera
                ArrayPais[Contador].ColoresBandera = new string[3];
                //definir en que indice del arreglo va a recibir cada dato
                ArrayPais[Contador].ColoresBandera[0] = txtColor1.Text.ToString();
                ArrayPais[Contador].ColoresBandera[1] = txtColor2.Text.ToString();
                ArrayPais[Contador].ColoresBandera[2] = txtColor3.Text.ToString();
                Contador++;
                //mensaje para mostrar que los datos se han guardado
                MessageBox.Show("Datos del pais guardados", "Paises", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarControles();
                txtNombrePais.Focus();
            }
            if (Contador == ArrayPais.Length)
            {
                gbxIntroducirDatos.Enabled = false;
                gbxBuscarPais.Enabled = true;
                MessageBox.Show("Se han cargados los datos de todos los paises ", "Paises", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
                
                
            
            
        }

        private void txtCantidadPaises_TextChanged(object sender, EventArgs e)
        {
            
        }

        
        private void btnBuscarDatos_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < ArrayPais.Length; i++)
            {
                if (txtBusPais.Text==ArrayPais[i].NombrePais)
                {
                    
                    encuentra = 1;
                    MessageBox.Show("El Paises se encontro. Datos listos para ser impresos", "Paises", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblResNombrePais.Text = ArrayPais[i].NombrePais;
                    lblResTotaPoblacion.Text = ArrayPais[i].TotalPoblacion.ToString();
                    lblResIdiomaPredominante.Text = ArrayPais[i].IdiomaPredominante;
                    lblResColor1.Text = ArrayPais[i].ColoresBandera[0];
                    lblResColor2.Text = ArrayPais[i].ColoresBandera[1];
                    lblResColor3.Text = ArrayPais[i].ColoresBandera[2];
                    

                }
            }
                                   
            if (encuentra == 0)
            {

                MessageBox.Show("Los datos del pais que solicita no se introdujeron", "Paises", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            btnListo.Enabled = true;
            txtCantidadPaises.Enabled = true;

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            
        }
        private void LimpiarControles()
        {
            //limpiar los controles para posteriormente de usarlos
            txtNombrePais.Clear();
            txtTotalPoblacion.Clear();
            txtIdiomaPredominante.Clear();
            txtColor1.Clear();
            txtColor2.Clear();
            txtColor3.Clear();
        }

        
    }
}