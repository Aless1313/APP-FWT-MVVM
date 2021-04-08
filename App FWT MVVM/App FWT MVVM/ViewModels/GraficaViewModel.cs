using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace App_FWT_MVVM.ViewModels
{
    //DATOS DE LA GRAFICA
    public class GraficaViewModel
    {
        public ObservableCollection<ChartDataMarker> AnualData { get; set; }
        public GraficaViewModel()
        {
            DateTime date = new DateTime(2021, 4, 7);

            AnualData = new ObservableCollection<ChartDataMarker>
            {
                new ChartDataMarker { High = 10, Date = date },
                new ChartDataMarker { High = 17, Date = date.AddMonths(1) },
                new ChartDataMarker { High = 10, Date = date.AddMonths(2) },
                new ChartDataMarker { High = 15, Date = date.AddMonths(3) },
                new ChartDataMarker { High = 20, Date = date.AddMonths(4) },
                new ChartDataMarker { High = 13, Date = date.AddMonths(5) },
                new ChartDataMarker { High = 4, Date = date.AddMonths(6) },
                new ChartDataMarker { High = 5, Date = date.AddMonths(7) },
                new ChartDataMarker { High = 8, Date = date.AddMonths(8) },
                new ChartDataMarker { High = 15, Date = date.AddMonths(9) },
                new ChartDataMarker { High = 17, Date = date.AddMonths(10) },
                new ChartDataMarker { High = 18, Date = date.AddMonths(11) },
                new ChartDataMarker { High = 15, Date = date.AddMonths(12) }
            };

        }

    }
    
    public class ChartDataMarker
    {
        public double High
        {
            get;
            set;
        }

        public DateTime Date
        {
            get;
            set;
        }

    }
 }
