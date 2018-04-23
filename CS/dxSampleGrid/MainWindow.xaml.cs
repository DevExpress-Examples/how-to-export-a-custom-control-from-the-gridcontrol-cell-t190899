using DevExpress.Xpf.Grid;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Threading;
using DevExpress.Xpf.Charts;

namespace dxSampleGrid {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            vm = new MyViewModel();
            DataContext = vm;

        }
        MyViewModel vm;



        private void Button_Click_1(object sender, RoutedEventArgs e) {
            //Dispatcher.BeginInvoke((Action)(() => {
            //    Debug.Print("sdf");
            //}), DispatcherPriority.Input);
            tableView1.ShowPrintPreview(this);
        }


    }


    public static class Helper {
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.RegisterAttached("Value", typeof(object), typeof(Helper), new PropertyMetadata(null, OnValuePropertyChanged));
        public static object GetValue(DependencyObject obj) {
            return (object)obj.GetValue(ValueProperty);
        }
        public static void SetValue(DependencyObject obj, object value) {
            obj.SetValue(ValueProperty, value);
        }
        static void OnValuePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) {
            if (!(e.NewValue is int))
                return;
            PieSeries2D ps = d as PieSeries2D;
            if (ps == null)
                return;
            ps.Points.Clear();
            ps.Points.Add(new SeriesPoint { Value = (int)e.NewValue, Argument = "Missing" });
            ps.Points.Add(new SeriesPoint { Value = 1, Argument = "EnteredAnotherStation" });
            ps.Points.Add(new SeriesPoint { Value = 1, Argument = "Entered" });
        }
    }





}
