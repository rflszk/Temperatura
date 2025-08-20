using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbldata.Text = DateTime.Now.ToString();
        }

        private void pibimagem_Click(object sender, EventArgs e)
        {

        }

        private void btnclima_Click(object sender, EventArgs e)
        {
            

            if (lbltempo.Text == "")
            {
                MessageBox.Show("Por favor Digite a temperatura!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int tempo = int.Parse(txbtempo.Text);
                if (tempo < 15)
                {
                    pibimagem.Image = Properties.Resources.snow;
                    lblresultado.Text = $"A temperatura de hoje é {tempo}ºC! O clima está frio!";
                }
                else if(tempo < 30)
                {
                    pibimagem.Image = Properties.Resources.clouds;
                    lblresultado.Text = $"A temperatura de hoje é {tempo}ºC! O clima está agradável!";
                }
                else if (tempo >= 30)
                {
                    pibimagem.Image = Properties.Resources.sun;
                    lblresultado.Text = $"A temperatura de hoje é {tempo}ºC! O clima está quente!";
                }
                else
                {
                    MessageBox.Show("O medidor de temperatura não pode calcular corretamente!");
                } 
                    
            }
        }
        }
    }

