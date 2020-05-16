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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Z6
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int VotesCount { get; set; }
        public Dictionary<string, int> Votes { get; set; } = new Dictionary<string, int>
        {
            { "A", 0 },
            { "B", 0 },
            { "C", 0 },
            { "D", 0 }
        };
        public MainWindow()
        {
            InitializeComponent();
            questionBlock.Text = "Wolisz A, B, C czy D?";
        }

        private void A_Button_Click(object sender, RoutedEventArgs e)
        {
            var maxHeight = statParent.ActualHeight;
            var choice = (sender as Button).Content.ToString();

            Votes[choice]++;
            VotesCount++;
            rectA.Height = maxHeight * (Votes["A"] / (double)VotesCount);
            rectB.Height = maxHeight * (Votes["B"] / (double)VotesCount);
            rectC.Height = maxHeight * (Votes["C"] / (double)VotesCount);
            rectD.Height = maxHeight * (Votes["D"] / (double)VotesCount);

            statsCount.Text = VotesCount.ToString();
            statsMax.Text = Votes.Max(x => x.Value).ToString();
        }
    }
}
