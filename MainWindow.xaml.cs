using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataGrid_Dashboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var converter = new BrushConverter();
            ObservableCollection<Member> members = new ObservableCollection<Member>();

            //Create DataGrid Items Information
            members.Add(new Member { Number = "1", Character = "A", BgColor = (Brush)converter.ConvertFromString("#1098AD"), Name = "John Doe", Position = "Coach", Email = "JohnDoe@Coach", Phone = "1234-5678" });
            members.Add(new Member { Number = "2", Character = "B", BgColor = (Brush)converter.ConvertFromString("#1E88E5"), Name = "Reza Alavi", Position = "Administrator", Email = "RezaAlavi@Administrator", Phone = "9876-5432" });
            members.Add(new Member { Number = "3", Character = "F", BgColor = (Brush)converter.ConvertFromString("#FF8F00"), Name = "Dennis Castillo", Position = "Coach", Email = "DennisCastillo@Coach", Phone = "1234-5678" });
            members.Add(new Member { Number = "4", Character = "G", BgColor = (Brush)converter.ConvertFromString("#FF5252"), Name = "Gabriel Cox", Position = "Coach", Email = "GabrielCox@Coach", Phone = "9876-5432" });
            members.Add(new Member { Number = "5", Character = "R", BgColor = (Brush)converter.ConvertFromString("#0CA678"), Name = "Lena Jones", Position = "Manager", Email = "LenaJones@Manager", Phone = "1234-5678" });
            members.Add(new Member { Number = "6", Character = "H", BgColor = (Brush)converter.ConvertFromString("#6741D9"), Name = "Benjamin Caliword", Position = "Administrator", Email = "BenjaminCaliword@Administrator", Phone = "9876-5432" });
            members.Add(new Member { Number = "7", Character = "D", BgColor = (Brush)converter.ConvertFromString("#FF6D00"), Name = "Shophia Muris", Position = "Coach", Email = "ShophiaMuris@Coach", Phone = "1234-5678" });
            members.Add(new Member { Number = "8", Character = "F", BgColor = (Brush)converter.ConvertFromString("#FF5252"), Name = "Ali Pormand", Position = "Manager", Email = "AliPormand@Manager", Phone = "9876-5432" });
            members.Add(new Member { Number = "9", Character = "J", BgColor = (Brush)converter.ConvertFromString("#1E88E5"), Name = "Frank Underwood", Position = "Manager", Email = "FrankUnderwood@Manager", Phone = "1234-5678" });
            members.Add(new Member { Number = "10", Character = "J", BgColor = (Brush)converter.ConvertFromString("#0CA678"), Name = "Saeed Dasman", Position = "Coach", Email = "SaeedDasman@Coach", Phone = "9876-5432" });

            members.Add(new Member { Number = "1", Character = "A", BgColor = (Brush)converter.ConvertFromString("#1098AD"), Name = "John Doe", Position = "Coach", Email = "JohnDoe@Coach", Phone = "1234-5678" });
            members.Add(new Member { Number = "2", Character = "B", BgColor = (Brush)converter.ConvertFromString("#1E88E5"), Name = "Reza Alavi", Position = "Administrator", Email = "RezaAlavi@Administrator", Phone = "9876-5432" });
            members.Add(new Member { Number = "3", Character = "F", BgColor = (Brush)converter.ConvertFromString("#FF8F00"), Name = "Dennis Castillo", Position = "Coach", Email = "DennisCastillo@Coach", Phone = "1234-5678" });
            members.Add(new Member { Number = "4", Character = "G", BgColor = (Brush)converter.ConvertFromString("#FF5252"), Name = "Gabriel Cox", Position = "Coach", Email = "GabrielCox@Coach", Phone = "9876-5432" });
            members.Add(new Member { Number = "5", Character = "R", BgColor = (Brush)converter.ConvertFromString("#0CA678"), Name = "Lena Jones", Position = "Manager", Email = "LenaJones@Manager", Phone = "1234-5678" });
            members.Add(new Member { Number = "6", Character = "H", BgColor = (Brush)converter.ConvertFromString("#6741D9"), Name = "Benjamin Caliword", Position = "Administrator", Email = "BenjaminCaliword@Administrator", Phone = "9876-5432" });
            members.Add(new Member { Number = "7", Character = "D", BgColor = (Brush)converter.ConvertFromString("#FF6D00"), Name = "Shophia Muris", Position = "Coach", Email = "ShophiaMuris@Coach", Phone = "1234-5678" });
            members.Add(new Member { Number = "8", Character = "F", BgColor = (Brush)converter.ConvertFromString("#FF5252"), Name = "Ali Pormand", Position = "Manager", Email = "AliPormand@Manager", Phone = "9876-5432" });
            members.Add(new Member { Number = "9", Character = "J", BgColor = (Brush)converter.ConvertFromString("#1E88E5"), Name = "Frank Underwood", Position = "Manager", Email = "FrankUnderwood@Manager", Phone = "1234-5678" });
            members.Add(new Member { Number = "10", Character = "J", BgColor = (Brush)converter.ConvertFromString("#0CA678"), Name = "Saeed Dasman", Position = "Coach", Email = "SaeedDasman@Coach", Phone = "9876-5432" });

            members.Add(new Member { Number = "1", Character = "A", BgColor = (Brush)converter.ConvertFromString("#1098AD"), Name = "John Doe", Position = "Coach", Email = "JohnDoe@Coach", Phone = "1234-5678" });
            members.Add(new Member { Number = "2", Character = "B", BgColor = (Brush)converter.ConvertFromString("#1E88E5"), Name = "Reza Alavi", Position = "Administrator", Email = "RezaAlavi@Administrator", Phone = "9876-5432" });
            members.Add(new Member { Number = "3", Character = "F", BgColor = (Brush)converter.ConvertFromString("#FF8F00"), Name = "Dennis Castillo", Position = "Coach", Email = "DennisCastillo@Coach", Phone = "1234-5678" });
            members.Add(new Member { Number = "4", Character = "G", BgColor = (Brush)converter.ConvertFromString("#FF5252"), Name = "Gabriel Cox", Position = "Coach", Email = "GabrielCox@Coach", Phone = "9876-5432" });
            members.Add(new Member { Number = "5", Character = "R", BgColor = (Brush)converter.ConvertFromString("#0CA678"), Name = "Lena Jones", Position = "Manager", Email = "LenaJones@Manager", Phone = "1234-5678" });
            members.Add(new Member { Number = "6", Character = "H", BgColor = (Brush)converter.ConvertFromString("#6741D9"), Name = "Benjamin Caliword", Position = "Administrator", Email = "BenjaminCaliword@Administrator", Phone = "9876-5432" });
            members.Add(new Member { Number = "7", Character = "D", BgColor = (Brush)converter.ConvertFromString("#FF6D00"), Name = "Shophia Muris", Position = "Coach", Email = "ShophiaMuris@Coach", Phone = "1234-5678" });
            members.Add(new Member { Number = "8", Character = "F", BgColor = (Brush)converter.ConvertFromString("#FF5252"), Name = "Ali Pormand", Position = "Manager", Email = "AliPormand@Manager", Phone = "9876-5432" });
            members.Add(new Member { Number = "9", Character = "J", BgColor = (Brush)converter.ConvertFromString("#1E88E5"), Name = "Frank Underwood", Position = "Manager", Email = "FrankUnderwood@Manager", Phone = "1234-5678" });
            members.Add(new Member { Number = "10", Character = "J", BgColor = (Brush)converter.ConvertFromString("#0CA678"), Name = "Saeed Dasman", Position = "Coach", Email = "SaeedDasman@Coach", Phone = "9876-5432" });

            members.Add(new Member { Number = "1", Character = "A", BgColor = (Brush)converter.ConvertFromString("#1098AD"), Name = "John Doe", Position = "Coach", Email = "JohnDoe@Coach", Phone = "1234-5678" });
            members.Add(new Member { Number = "2", Character = "B", BgColor = (Brush)converter.ConvertFromString("#1E88E5"), Name = "Reza Alavi", Position = "Administrator", Email = "RezaAlavi@Administrator", Phone = "9876-5432" });
            members.Add(new Member { Number = "3", Character = "F", BgColor = (Brush)converter.ConvertFromString("#FF8F00"), Name = "Dennis Castillo", Position = "Coach", Email = "DennisCastillo@Coach", Phone = "1234-5678" });
            members.Add(new Member { Number = "4", Character = "G", BgColor = (Brush)converter.ConvertFromString("#FF5252"), Name = "Gabriel Cox", Position = "Coach", Email = "GabrielCox@Coach", Phone = "9876-5432" });
            members.Add(new Member { Number = "5", Character = "R", BgColor = (Brush)converter.ConvertFromString("#0CA678"), Name = "Lena Jones", Position = "Manager", Email = "LenaJones@Manager", Phone = "1234-5678" });
            members.Add(new Member { Number = "6", Character = "H", BgColor = (Brush)converter.ConvertFromString("#6741D9"), Name = "Benjamin Caliword", Position = "Administrator", Email = "BenjaminCaliword@Administrator", Phone = "9876-5432" });
            members.Add(new Member { Number = "7", Character = "D", BgColor = (Brush)converter.ConvertFromString("#FF6D00"), Name = "Shophia Muris", Position = "Coach", Email = "ShophiaMuris@Coach", Phone = "1234-5678" });
            members.Add(new Member { Number = "8", Character = "F", BgColor = (Brush)converter.ConvertFromString("#FF5252"), Name = "Ali Pormand", Position = "Manager", Email = "AliPormand@Manager", Phone = "9876-5432" });
            members.Add(new Member { Number = "9", Character = "J", BgColor = (Brush)converter.ConvertFromString("#1E88E5"), Name = "Frank Underwood", Position = "Manager", Email = "FrankUnderwood@Manager", Phone = "1234-5678" });
            members.Add(new Member { Number = "10", Character = "J", BgColor = (Brush)converter.ConvertFromString("#0CA678"), Name = "Saeed Dasman", Position = "Coach", Email = "SaeedDasman@Coach", Phone = "9876-5432" });

            membersDataGrid.ItemsSource = members;
        
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private bool IsMaximixed = false;
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (IsMaximixed)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1080;
                    this.Height = 720;

                    IsMaximixed = !IsMaximixed;
                }
                else
                {
                    this.WindowState = WindowState.Maximized;

                    IsMaximixed = !IsMaximixed;
                }
            }
        }
    }

    public class Member
    {
        public string Character { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Brush BgColor { get; set; }
    }
}
