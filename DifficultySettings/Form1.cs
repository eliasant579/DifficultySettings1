using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DifficultySettings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nameTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                titleLabel.Text = "Welcome hero " + nameTextbox.Text;

                nameLabel.Visible = false;
                chooseLabel.Visible = true;
                nameTextbox.Visible = false;
                easyButton.Visible = true;
                mediumButton.Visible = true;
                hardButton.Visible = true;
            }


        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "The clever hero always follow the easy path";
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "The clever hero always follow the medium path";

        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "The brave hero always follow the hard path";

        }
    }
}
