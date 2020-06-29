using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace EXAMEN.Pages
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class p2 : Page
    {
        public p2()
        {
            this.InitializeComponent();
        }

        private void bp2_Click(object sender, RoutedEventArgs e)
        {
            frame3.Content = new p2ejemplo();
        }

        private void f0_Click(object sender, RoutedEventArgs e)
        {
            frame3.Content = new p2_0();
        }

        private void f1_Click(object sender, RoutedEventArgs e)
        {
            frame3.Content = new p2_1();
        }

        private void f2_Click(object sender, RoutedEventArgs e)
        {
            frame3.Content = new p2_2();
        }

        private void f3_Click(object sender, RoutedEventArgs e)
        {
            frame3.Content = new p2_3();
        }

        private void f4_Click(object sender, RoutedEventArgs e)
        {
            frame3.Content = new p2_4();
        }

        private void f5_Click(object sender, RoutedEventArgs e)
        {
            frame3.Content = new p2_5();
        }
    }
}