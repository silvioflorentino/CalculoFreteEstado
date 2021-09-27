﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoFreteEstado
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

       private void Calcular()
        {
            decimal valor = 0;
            decimal porcentagem = 0;

            valor = Convert.ToDecimal(txtValor.Text);

            switch (cbEstado.Text)
            {
                case "AM":
                    porcentagem = 0.6m;
                    break;
                case "MG":
                    porcentagem = 0.35m;
                    break;
                case "RJ":
                    porcentagem = 0.30m;
                    break;
                case "SP":
                    porcentagem = 0.2m;
                    break;
                default:
                    porcentagem = 0.75m;
                    break;
            }
            // N3 é para colocar os valores em decimal com 3 casas
            txtValor.Text = valor.ToString("N2");

            txtFrete.Text = porcentagem.ToString("P1");

            lblResultado.Text = (valor * (1 + porcentagem)).ToString("c2");

        }

        private void LimparTudo()
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtFrete.Text = string.Empty;
            lblResultado.Text = string.Empty;

            if (txtNome.Text.Trim().Equals(""))
            {
                MessageBox.Show("O campo Nome é  obrigatório", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNome.Focus();
                return;
            }

            if (txtValor.Text.Trim().Equals(""))
            {
                MessageBox.Show("O campo Valor é  obrigatório", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtValor.Focus();
                return;
            }

            Calcular();
        }
    }
}
