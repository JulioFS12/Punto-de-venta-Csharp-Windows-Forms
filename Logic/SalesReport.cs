using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Logic
{
    public class SalesReport
    {
        //Attributes-Properties
        public DateTime reportDate { get; private set; }
        public DateTime startDate { get; private set; }
        public DateTime endDate { get; private set; }
        public List<SalesListing> salesListing { get; private set; }
        public List<NetSalesByPeriod> netSalesByPeriod { get; private set; }
       

        //Methods
        public void createSalesOrderReport(DateTime fromDate, DateTime toDate)
        {
            //implement dates
            reportDate = DateTime.Now;
            startDate = fromDate;
            endDate = toDate;
            //create sales listing
            var orderDao = new OrderDao();
            var result = orderDao.getSalesOrder(fromDate, toDate);

            salesListing = new List<SalesListing>();

            foreach (System.Data.DataRow rows in result.Rows)
            {
                var salesModel = new SalesListing()
                {
                    orderDate = Convert.ToDateTime(rows[0]),
                    nombre = Convert.ToString(rows[1]),
                    precio_unitario = Convert.ToDouble(rows[2]),
                    cantidad = Convert.ToDecimal(rows[3]),
                    descuento = Convert.ToDouble(rows[4]),
                    precio_total = Convert.ToDouble(rows[5])
                };
                salesListing.Add(salesModel);

            }
            //create net sales by period
            ////create temp list net sales by date
            var listSalesByDate = (from sales in salesListing
                                   group sales by sales.orderDate
                                       into listSales
                                       select new
                                       {
                                           date = listSales.Key,
                                           amount = listSales.Sum(item => item.precio_total)
                                       }).AsEnumerable();
            ////get number of days
            int totalDays = Convert.ToInt32((toDate - fromDate).Days);

            ////group period by days
            if (totalDays <= 7)
            {
                netSalesByPeriod = (from sales in listSalesByDate
                                    group sales by sales.date.ToString("dd-MMM-yyyy")
                                        into listSales
                                        select new NetSalesByPeriod
                                        {
                                            period = listSales.Key,
                                            netSales = listSales.Sum(item => item.amount)
                                        }).ToList();
            }
            ////group period by weeks
            else if (totalDays <= 30)
            {
                netSalesByPeriod = (from sales in listSalesByDate
                                    group sales by
                                    System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                        sales.date, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                        into listSales
                                        select new NetSalesByPeriod
                                        {
                                            period = "Week " + listSales.Key.ToString(),
                                            netSales = listSales.Sum(item => item.amount)
                                        }).ToList();
            }
            ////group period by months
            else if (totalDays <= 365)
            {
                netSalesByPeriod = (from sales in listSalesByDate
                                    group sales by sales.date.ToString("MMM-yyyy")
                                        into listSales
                                        select new NetSalesByPeriod
                                        {
                                            period = listSales.Key,
                                            netSales = listSales.Sum(item => item.amount)
                                        }).ToList();
            }
            ////group period by years
            else
            {
                netSalesByPeriod = (from sales in listSalesByDate
                                    group sales by sales.date.ToString("yyyy")
                                        into listSales
                                        select new NetSalesByPeriod
                                        {
                                            period = listSales.Key,
                                            netSales = listSales.Sum(item => item.amount)
                                        }).ToList();
            }
        }
    }
}
