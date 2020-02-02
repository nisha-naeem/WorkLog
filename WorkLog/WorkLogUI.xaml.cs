using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WorkLog
{
    /// <summary>
    /// Interaction logic for WorkLogUI.xaml
    /// </summary>
    public partial class WorkLogUI : Window
    {
        public WorkLogUI()
        {
            InitializeComponent();
            // ListViewMenu.se
        }

        private void ButtonPopupLogout_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }


        private void GridMenu_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ListViewMenu_Selected(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;
            MoveCursorMenu(index);
            switch(index)
            {
                case 0:
                    GridPrincipal?.Children.Clear();
                    GridPrincipal?.Children.Add(new UserControlIssue());
                    break;

                default:
                    break;
            }
                
        }
        private void MoveCursorMenu(int index)
        {
            TransitioningContentSlide.OnApplyTemplate();
            SelectionIndicatorGrid.Margin = new Thickness(0, (150+(60* index)), 0, 0);
        }

        //Selected="ListViewMenu_Selected"
        private void ListViewMenu_Selected_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
