using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QueuingForm
{
    public partial class QueuingTP : Form
    {
        public QueuingTP()
        {
            InitializeComponent();
            timer1.Start();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                lblView.Text = CashierClass.CashierQueue.Peek();
            }
            catch (InvalidOperationException)
            {
                lblView.Text = "P - _____";
            }
        }
    }
}
