using System;

namespace Data {
    [Serializable]
    public class falloBDException : Exception {
        public string Arbitro { get; }

        public falloBDException () { }

        public falloBDException (string message) : base("Algo ha salido mal, revise su base de datos") { }

        public falloBDException (string message, Exception inner) : base(message, inner) { }

        public falloBDException (string message, string arbitro) : this(message) {
            Arbitro = arbitro;
        }
    }
}
