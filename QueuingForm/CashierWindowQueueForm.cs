using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace QueuingForm
{
    
    public partial class CashierWindowQueueForm : Form
    {
        private System.Windows.Forms.Timer timer;
        public CashierWindowQueueForm()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(timer1_tick);
            timer.Start();
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
            if (CashierClass.CashierQueue.Count > 0)
            {
                CashierClass.CashierQueue.Dequeue();
                DisplayCashierQueue(CashierClass.CashierQueue);
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