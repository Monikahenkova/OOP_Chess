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

namespace OOP_Chess
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<figure> figures;
        public MainWindow()
        {
            InitializeComponent();
            figures.Add(new figure(FigureType.Rook, "A8", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "H8", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "B8", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "G8", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "C8", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "F8", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "E8", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "D8", FigureColor.Black));

            figures.Add(new figure(FigureType.Rook, "A7", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "H7", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "B7", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "G7", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "C7", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "F7", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "E7", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "D7", FigureColor.Black));

            figures.Add(new figure(FigureType.Rook, "A6", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "H6", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "B6", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "G6", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "C6", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "F6", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "E6", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "D6", FigureColor.Black));

            figures.Add(new figure(FigureType.Rook, "A5", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "H5", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "B5", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "G5", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "C5", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "F5", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "E5", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "D5", FigureColor.Black));

            figures.Add(new figure(FigureType.Rook, "A4", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "H4", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "B4", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "G4", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "C4", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "F4", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "E4", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "D4", FigureColor.Black));

            figures.Add(new figure(FigureType.Rook, "A3", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "H3", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "B3", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "G3", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "C3", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "F3", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "E3", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "D3", FigureColor.Black));

            figures.Add(new figure(FigureType.Rook, "A2", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "H2", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "B2", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "G2", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "C2", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "F2", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "E2", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "D2", FigureColor.Black));

            figures.Add(new figure(FigureType.Rook, "A1", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "H1", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "B1", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "G1", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "C1", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "F1", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "E1", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "D1", FigureColor.Black));











        }
    }
}
