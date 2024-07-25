using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btNetHesapla_Click(object sender, EventArgs e)
        {
            int tDogru =Convert.ToInt16(tbTurkceDogru.Text);
            int tYanlis = Convert.ToInt16(tbTurkceYanlis.Text);
            int mDogru = Convert.ToInt16(tbMatDoğru.Text);
            int mYanlis = Convert.ToInt16(tbMatYanlis.Text);
            tbTurkceNet.Text =Convert.ToString(tDogru - (tYanlis / 4));
            tbMatNet.Text = Convert.ToString(mDogru - (mYanlis / 4));

        }
    }
}
