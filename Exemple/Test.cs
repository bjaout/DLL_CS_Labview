using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple
{
    public class Test
    {
        /// <summary>
        /// Déclaration d'un compteur pour avoir quelque chose de visuel
        /// </summary>
        private int counter = 0;
        public int Counter
        {
            get { return counter; }
        }

        public delegate void TestHandler(object myObj, TestArgs myArgs); // On déclare un délégé de fonction (un type de fonction)
        public event TestHandler TestEvent; // On déclare un événement personalisé dont la fonction de gestion doit respecter le délégué utilisé dans la définition

        /// <summary>
        /// Déclaration d'un constructeur initialisant le compteur à 0
        /// </summary>
        public Test()
        {
            counter = 0;
        }

        /// <summary>
        /// Incrémente le compteur de 1 puis déclenche l'événement TestEvent qui peut ou non être géré
        /// </summary>
        public void IncrementCounter()
        {
            counter++;
            TestArgs myArgs = new TestArgs(counter.ToString());
            TestEvent(this, myArgs);
        }
    }
}
