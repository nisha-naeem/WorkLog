using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.Views
{
    public partial class ReportView : Form
    {
        private List<ReportParameter> _parameters;

        public ReportView(List<ReportParameter> parameters)
        {
            InitializeComponent();
            this._parameters = parameters;
        }

        private void ReportView_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.SetParameters(_parameters);
            this.reportViewer1.RefreshReport();
        }
    }
}
