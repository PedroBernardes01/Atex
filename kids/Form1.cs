using Mysql_Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mysql_Object;

namespace kids
{
    public partial class Form1 : Form
    {
        private WorkBench Querry;
        public Form1(string host, string username, string schema, string password)
        {
            Querry = new WorkBench(host, username, schema, password);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
