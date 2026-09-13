using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp.Style
{
    public class CustomButton : Button
    {
        //依赖属性

        public CornerRadius ButtonCornerRadius
        {
            get { return (CornerRadius)GetValue(ButtonCornerRadiusProperty); }
            set { SetValue(ButtonCornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ButtonCornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonCornerRadiusProperty =
            DependencyProperty.Register("ButtonCornerRadius", typeof(CornerRadius), typeof(CustomButton));



        public Brush BackgroundOver
        {
            get { return (Brush)GetValue(BackgroundOverProperty); }
            set { SetValue(BackgroundOverProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BackgroundOverProperty =
            DependencyProperty.Register("BackgroundOver", typeof(Brush), typeof(CustomButton));



        public Brush BackgroundPress
        {
            get { return (Brush)GetValue(BackgroundPressProperty); }
            set { SetValue(BackgroundPressProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BackgroundPressProperty =
            DependencyProperty.Register("BackgroundPress", typeof(Brush), typeof(CustomButton));



    }
}
