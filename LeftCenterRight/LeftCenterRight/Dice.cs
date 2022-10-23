using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftCenterRight
{
    internal class Dice
    {
        private const int MAX_NUMMBER = 6;
        private Random _random = new Random();
        private int _lastValue;

        public int LastValue
        {
            get { return _lastValue; }  
        }
        /// <summary>
        /// In deiser Funktion wird der Würfel gewürfelt. Es wird eine Zufallszahl zwischen 1 und 6 generiert, 
        /// die den spielverlauf kontrolliere.
        /// </summary>
        /// <param name="MAX-NUMBER">Ist die Höchste Zahl auf dem Würfel. Die Nummer 6</param>
        /// <param name="_random">Speichert eine Zufallszahl zwischen 1 und 6, die mit der Random Klasse generiert wird.</param>
        /// <param name="_lastValue">In ihr wird die von _random generierte Zahl gespeichert.</param>
        public void Roll()
        {
            _lastValue = _random.Next(1, MAX_NUMMBER);
        }
    }
}
