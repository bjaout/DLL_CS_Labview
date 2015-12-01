using System;

namespace Exemple
{
    /// <summary>
    /// Création d'une classe spécifique pour nos arguments d'événements
    /// </summary>
    public class TestArgs:EventArgs
    {
        /// <summary>
        /// Un message qui pourra être récupéré
        /// </summary>
        private string message;
        public string Message
        {
            get { return message; }
        }

        /// <summary>
        /// Constructeur de la classe on lui passe le message à stocker qui sera ensuite accessible par le gestionnaire d'événement
        /// </summary>
        /// <param name="msg">Le message à stocker</param>
        public TestArgs(string msg)
        {
            this.message = msg;
        }

    }
}