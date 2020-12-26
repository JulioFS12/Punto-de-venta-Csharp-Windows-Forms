using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace Presentation
{
    public partial class ReportesVenta : Form
    {
        public ReportesVenta()
        {
            InitializeComponent();
        }

        private void getSalesReport(DateTime startDate, DateTime endDate)
        {
            SalesReport reportModel = new SalesReport();
            reportModel.createSalesOrderReport(startDate, endDate);

            SalesReportBindingSource.DataSource = reportModel;
            SalesListingBindingSource.DataSource = reportModel.salesListing;
            NetSalesByPeriodBindingSource.DataSource = reportModel.netSalesByPeriod;

            this.reportViewer1.RefreshReport();
        }


        private void ReportesVenta_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today;
            var toDate = DateTime.Now;

            getSalesReport(fromDate, toDate);
        }

        private void btnLastWeaK_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today.AddDays(-7);
            var toDate = DateTime.Now;

            getSalesReport(fromDate, toDate);
        }

        private void thisMonth_Click(object sender, EventArgs e)
        {
            var fromDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var toDate = DateTime.Now;

            getSalesReport(fromDate, toDate);
        }

        private void btnlast30days_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today.AddDays(-30);
            var toDate = DateTime.Now;

            getSalesReport(fromDate, toDate);
        }

        private void btnthisYear_Click(object sender, EventArgs e)
        {
            var fromDate = new DateTime(DateTime.Now.Year, 1, 1);
            var toDate = DateTime.Now;

            getSalesReport(fromDate, toDate);
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            var fromDate = dateTimePickerFromDate.Value;
            var toDate = dateTimePickerToDate.Value;

            getSalesReport(fromDate, new DateTime(toDate.Year, toDate.Month, toDate.Day, 23, 59, 59));
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
