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
            figures.Add(new figure(FigureType.Knight, "B8", FigureColor.Black));
            figures.Add(new figure(FigureType.Knight, "G8", FigureColor.Black));
            figures.Add(new figure(FigureType.Bishop, "C8", FigureColor.Black));
            figures.Add(new figure(FigureType.Bishop, "F8", FigureColor.Black));
            figures.Add(new figure(FigureType.King, "E8", FigureColor.Black));
            figures.Add(new figure(FigureType.Queen, "D8", FigureColor.Black));

            figures.Add(new figure(FigureType.Pawn, "A7", FigureColor.Black));
            figures.Add(new figure(FigureType.Pawn, "H7", FigureColor.Black));
            figures.Add(new figure(FigureType.Pawn, "B7", FigureColor.Black));
            figures.Add(new figure(FigureType.Pawn, "G7", FigureColor.Black));
            figures.Add(new figure(FigureType.Pawn, "C7", FigureColor.Black));
            figures.Add(new figure(FigureType.Pawn, "F7", FigureColor.Black));
            figures.Add(new figure(FigureType.Pawn, "E7", FigureColor.Black));
            figures.Add(new figure(FigureType.Pawn, "D7", FigureColor.Black));

            figures.Add(new figure(FigureType.Pawn, "A2", FigureColor.Black));
            figures.Add(new figure(FigureType.Pawn, "H2", FigureColor.Black));
            figures.Add(new figure(FigureType.Pawn, "B2", FigureColor.Black));
            figures.Add(new figure(FigureType.Pawn, "G2", FigureColor.Black));
            figures.Add(new figure(FigureType.Pawn, "C2", FigureColor.Black));
            figures.Add(new figure(FigureType.Pawn, "F2", FigureColor.Black));
            figures.Add(new figure(FigureType.Pawn, "E2", FigureColor.Black));
            figures.Add(new figure(FigureType.Pawn, "D2", FigureColor.Black));

            figures.Add(new figure(FigureType.Rook, "A1", FigureColor.Black));
            figures.Add(new figure(FigureType.Rook, "H1", FigureColor.Black));
            figures.Add(new figure(FigureType.Knight, "B1", FigureColor.Black));
            figures.Add(new figure(FigureType.Knight, "G1", FigureColor.Black));
            figures.Add(new figure(FigureType.Bishop, "C1", FigureColor.Black));
            figures.Add(new figure(FigureType.Bishop, "F1", FigureColor.Black));
            figures.Add(new figure(FigureType.King, "E1", FigureColor.Black));
            figures.Add(new figure(FigureType.Queen, "D1", FigureColor.Black));

            lblboard.Text = "";
            foreach(Figure figure in figures)
            {
                lblboard.Text += figure.ToString() + "\n";
            }  
        }
        public void DrawBoard(Canvas canvas)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Width = canvas.Width / 8;
            rectangle.Height = canvas.Height / 8;
        }


    }
}
