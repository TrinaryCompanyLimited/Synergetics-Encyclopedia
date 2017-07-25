using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SynergeticsEncyclopedia
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

       

       

        private void ribbonPanel8_Click(object sender, EventArgs e)
        {
            FullersBiography biography = new FullersBiography();
            biography.Show(); 
        }

        

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
        }

        private void ribbonBiograpghyPanel_Click(object sender, EventArgs e)
        {
            FullersBiography biography = new FullersBiography();
            biography.Show();
        }

        private void inventionsRibbonPanel(object sender, EventArgs e)
        {
            Inventions invention = new Inventions();
            invention.Show();
        }

        private void patentsRibbonPanel_Click(object sender, EventArgs e)
        {
            Patents patent = new Patents();
            patent.Show();
        }

        private void SynergeticsRibbonPanel_Click(object sender, EventArgs e)
        {
            SynergeticBook synergeticsBook = new SynergeticBook();
            synergeticsBook.Show();
        }

        private void ribbonButton8_Click(object sender, EventArgs e)
        {
            Grunch grunchOfGiants = new Grunch();
            grunchOfGiants.Show();
        }

        private void ribbonPanel13_Click(object sender, EventArgs e)
        {
            OperatingManual operatingmanual = new OperatingManual();
            operatingmanual.Show();
        }

        private void ribbonPanel11_Click(object sender, EventArgs e)
        {
            FullerExplanation fullerExplanation = new FullerExplanation();
            fullerExplanation.Show();
           
        }
    }
}
