using OrdersService.Models;
using OrdersService.Models.Report;
using OrdersService.Utils.DataLoaders;
using OrdersService.ViewModels;
using OrdersService.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace OrdersService.Utils
{
    public class ReportResolver
    {
        private ReportType reportType;

        public ReportResolver(ReportType reportType)
        {
            this.reportType = reportType;
        }

        public UserControl GetReportPage()
        {
            var view = GetView();
            view.DataContext = GetViewModel();
            return view;
        }

        private object GetViewModel()
        {
            switch (reportType)
            {
                case ReportType.Quarter:
                    return new ReportViewModel<QuarterReportItem>(new QuarterReportItemDataLoader());
                case ReportType.CustomerSales:
                    return new ReportViewModel<CustomerReportItem>(new CustomerReportItemDataLoader());
            }
            return null;
        }

        private UserControl GetView()
        {
            switch (reportType)
            {
                case ReportType.Quarter:
                    return new QuarterReport();
                case ReportType.CustomerSales:
                    return new CustomerReport();
            }
            return null;
        }
    }
}