using System;
using System.Threading;
using System.Windows.Forms;
using AutoUpdaterDotNET;

namespace Capital_Bank
{
    public partial class ГлавнаяФорма : Form
    {
        public ГлавнаяФорма()
        {
            InitializeComponent();
            verLbl.Text = "v." + Application.ProductVersion;
            MessageBox.Show("ВСЕ НЕ ЦЕЛЫЕ ЗНАЧЕНИЯ ПИШУТСЯ С ЗАПЯТОЙ(,)");
        }
        private void расчетКредитаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/brXU4WmEMm");
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            double S = Convert.ToDouble(sNum.Text);//Сумма займа
            richTextBox1.Text= "S= " + Convert.ToString(S);
            double P = Convert.ToDouble(pNum.Text);//Ставка
            richTextBox1.Text =richTextBox1.Text + "\r\n" + "P= " + Convert.ToString(P);
            double N = Convert.ToDouble(mNum.Text);//Длительность
            richTextBox1.Text = richTextBox1.Text + "\r\n" + "N= " + Convert.ToString(N);

            //double I = S * P;//доля процентов (I) в ежемесячном взносе
            double P1 = P++;
            richTextBox1.Text = richTextBox1.Text + "\r\n" +"P1= "+ Convert.ToString(P);

            double znamenatel = Math.Pow(P1, N);
            richTextBox1.Text = richTextBox1.Text + "\r\n" + "znamenatel= " + Convert.ToString(znamenatel);

            double znamenatel1 = znamenatel - 1;
            richTextBox1.Text = richTextBox1.Text + "\r\n" + "znamenatel1= " + Convert.ToString(znamenatel1);
            double delitel = P;
            double drob = delitel / znamenatel1;
            drobTxt.Text =Convert.ToString(drob);
            double skobki = P + drob;
            skoba.Text =Convert.ToString(skobki);
            double X = S * skobki;
            xNum.Text = Convert.ToString(X);
        }
    }
}
