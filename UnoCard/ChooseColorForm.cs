using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnoProject
{
    public partial class ChooseColorForm : Form
    {
        public Color chosenColor = Color.AliceBlue;

        public ChooseColorForm()
        {
            InitializeComponent();

            foreach (var item in this.tbPanel.Controls)
            {
                ((Panel)item).Click += ChooseColorForm_Click;
                ((Panel)item).MouseMove += ChooseColorForm_MouseMove;
                ((Panel)item).MouseLeave += ChooseColorForm_MouseLeave;
            }

            this.FormClosing += ChooseColorForm_FormClosing;
        }

        void ChooseColorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.chosenColor == Color.AliceBlue)
                this.chosenColor = this.panel1.BackColor;
        }

        private void ChooseColorForm_MouseLeave(object sender, EventArgs e)
        {
            ((Panel)sender).BorderStyle = BorderStyle.None;
        }

        private void ChooseColorForm_MouseMove(object sender, MouseEventArgs e)
        {
            ((Panel)sender).BorderStyle = BorderStyle.Fixed3D;
        }

        private void ChooseColorForm_Click(object sender, EventArgs e)
        {
            Panel tmp = sender as Panel;
            chosenColor = tmp.BackColor;
            this.Close();
        }
    }
}
