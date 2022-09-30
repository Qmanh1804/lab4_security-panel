using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Security_Panel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnRezo_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtSecurityCode.Text += btn.Text;
            txtSecurityCode.Focus();
            txtSecurityCode.SelectionStart = txtSecurityCode.Text.Length;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text = "";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            String thongbao = "";
            switch (txtSecurityCode.Text)
            {
                case"1645":
                case "1689":
                    thongbao = "Technicians";
                    break;
                case "8345":
                    thongbao = "Custodians";
                    break;
                case "9998":
                case "1006":
                case "1008":
                    thongbao = "Scientist";
                    break;
                default:
                    thongbao = "Restricted Access";
                    break;

            }
            lbAcceslog.Items.Add(DateTime.Now.ToString("dd:MM:yyyy hh:mm:ss") + "    " + thongbao);
            txtSecurityCode.Text = "";
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string path = "";
            StreamWriter streamWriter;
            path = "../Texts.txt";
            if (!File.Exists(path))
            {
                streamWriter = new StreamWriter(path);
                foreach (string item in lbAcceslog.Items)
                {
                    streamWriter.WriteLine(item);
                }
                MessageBox.Show("Save", "Lưu file", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                streamWriter.Close();
            }
            else
            {
                streamWriter = File.AppendText(path);
                foreach (string item in lbAcceslog.Items)
                {
                    streamWriter.WriteLine(item);
                }
                MessageBox.Show("Lưu thành công", "Lưu file", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
