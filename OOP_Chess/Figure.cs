using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Chess
{
    public class Figure
    {
        private string position;
        private string[] numbers = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        public FigureType Type { get; set; }
        public string Position
        {
            set
            {
                if (string.IsNullOrEmpty(value)) //hodnota v proměnné value je null nebo ""
                {

                }
                else if (value.Length == 2)
                {
                    if (numbers.Contains(value.Substring(1, 1))) //druhý znak v proměnné value je v listu numbers
                
                            
                }
            }
            get => position;
        }

        public Figure()
        {
            
        }
    }

    //výčtový datový typ- seznam hodnot- interně jsou to hodnoy integer (od 0)
    public enum FigureType
    {
        Pawn, //pěšec
        Rook, //věž 
        Knight, //jezdec
        Bishop, //střelec
        Queen, //královna
        King //král
    }
}
