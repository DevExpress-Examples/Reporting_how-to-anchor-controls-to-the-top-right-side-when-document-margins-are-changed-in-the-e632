using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
namespace WindowsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            new XtraReport1().ShowPreview();
        }
    }
}