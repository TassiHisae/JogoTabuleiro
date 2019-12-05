using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuleiro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i<=65; i++)
            {
                Controls["panel" + i].Parent = pictureBox1;
                pictureBox2.Parent = panel0;
                pictureBox2.Left = 0;
                pictureBox2.Top = 0;
            }
            
        }

        int casa = 0;
        Random r = new Random();

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            int x = r.Next(1,8);
            pictureBox3.Image = Image.FromFile("C:/Users/tassi.LAPTOP-RD0CSL1O/OneDrive/Imagens/numero" + x+".png");

            casa += x;
            if (casa > 65)
            {
                casa -= x;
                pictureBox2.Parent = pictureBox1.Controls["panel65"];
            }
            else {
                pictureBox2.Parent = pictureBox1.Controls["panel" + casa];

                if (pictureBox2.Parent == pictureBox1.Controls["panel4"]) {
                    MessageBox.Show("Vamos avançar duas casas com a ajuda do Buzz");
                    casa += 2;
                    pictureBox2.Parent = pictureBox1.Controls["panel" + casa];
                } else if (pictureBox2.Parent == pictureBox1.Controls["panel12"]) {
                    MessageBox.Show("Esconda-se do Lotso, retone 3 casas");
                    casa -= 3;
                    pictureBox2.Parent = pictureBox1.Controls["panel" + casa];
                }
                else if (pictureBox2.Parent == pictureBox1.Controls["panel19"])
                {
                    MessageBox.Show("Jogue os dados novamente");
                    pictureBox2.Parent = pictureBox1.Controls["panel" + casa];
                }
                else if (pictureBox2.Parent == pictureBox1.Controls["panel23"])
                {
                    MessageBox.Show("Perca uma rodada");
                    pictureBox2.Parent = pictureBox1.Controls["panel23"];
                }
                else if (pictureBox2.Parent == pictureBox1.Controls["panel30"])
                {
                    MessageBox.Show("Avance três casas com a ajuda do Woody");
                    casa += 3;
                    pictureBox2.Parent = pictureBox1.Controls["panel" + casa];
                }
                else if (pictureBox2.Parent == pictureBox1.Controls["panel37"])
                {
                    MessageBox.Show("Esconda-se do Zurg, retone 2 casas");
                    casa -= 2;
                    pictureBox2.Parent = pictureBox1.Controls["panel" + casa];
                }
                else if (pictureBox2.Parent == pictureBox1.Controls["panel43"])
                {
                    MessageBox.Show("Jogue os dados novamente");
                    pictureBox2.Parent = pictureBox1.Controls["panel" + casa];
                }
                else if (pictureBox2.Parent == pictureBox1.Controls["panel54"])
                {
                    MessageBox.Show("Perca uma rodada");
                    pictureBox2.Parent = pictureBox1.Controls["panel54"];
                }
                else if (pictureBox2.Parent == pictureBox1.Controls["panel61"])
                {
                    MessageBox.Show("Avance uma casa com a ajuda do Sr. Cabeça de Batata");
                    casa += 1;
                    pictureBox2.Parent = pictureBox1.Controls["panel" + casa];
                }
            }

            if (casa == 65 || pictureBox2.Parent == pictureBox1.Controls["panel65"])
            {
                MessageBox.Show("Parabéns! Você venceu!");
                pictureBox3.Enabled = false;
            }
        }
    }
}
