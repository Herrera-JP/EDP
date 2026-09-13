using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace QueuingForm
{
    
    public partial class CashierWindowQueueForm : Form
    {

        public CashierWindowQueueForm()
        {
            InitializeComponent();
            timer1.Tick += new EventHandler(timer1_tick); 
            timer1.Start();

        }
        private void timer1_tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            { 
                CashierClass.CashierQueue.Dequeue();
                DisplayCashierQueue(CashierClass.CashierQueue);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("No number in queue: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }

        }
    }
}