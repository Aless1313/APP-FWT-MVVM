using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace App_FWT_MVVM.ViewModels
{
    public class GraficaViewModel
    {
        public ObservableCollection<OxygenRate> MonthsData { get; set; }

        public GraficaViewModel()
        {
            DateTime date = new DateTime(2017, 5, 1);

            MonthsData = new ObservableCollection<OxygenRate>();

            MonthsData.Add(new OxygenRate { High = 29, Low = 80, Date = date });
            MonthsData.Add(new OxygenRate { High = 33, Low = 80, Date = date.AddDays(30) });
            MonthsData.Add(new OxygenRate { High = 24, Low = 80, Date = date.AddDays(60) });
            MonthsData.Add(new OxygenRate { High = 28, Low = 80, Date = date.AddDays(90) });
            MonthsData.Add(new OxygenRate { High = 26, Low = 80, Date = date.AddDays(120) });
            MonthsData.Add(new OxygenRate { High = 38, Low = 80, Date = date.AddDays(150) });
            MonthsData.Add(new OxygenRate { High = 32, Low = 80, Date = date.AddDays(180) });
            MonthsData.Add(new OxygenRate { High = 20, Low = 80, Date = date.AddDays(210) });
            MonthsData.Add(new OxygenRate { High = 35, Low = 80, Date = date.AddDays(240) });
            MonthsData.Add(new OxygenRate { High = 18, Low = 80, Date = date.AddDays(270) });
            MonthsData.Add(new OxygenRate { High = 10, Low = 80, Date = date.AddDays(300) });
            MonthsData.Add(new OxygenRate { High = 50, Low = 80, Date = date.AddDays(330) });
            MonthsData.Add(new OxygenRate { High = 41, Low = 80, Date = date.AddDays(360) });

        }
    }

    public class OxygenRate
    {
        public double High
        {
            get;
            set;
        }

        public double Low
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
