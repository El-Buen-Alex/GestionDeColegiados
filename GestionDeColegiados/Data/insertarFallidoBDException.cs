using System;

namespace Data {
    [Serializable]
    public class insertarFallidoBDException : Exception {
        public string Arbitro { get; }

        public insertarFallidoBDException () { }

        public insertarFallidoBDException (string message) : base("Algo ha salido mal, revise su base de datos") { }

        public insertarFallidoBDException (string message, Exception inner) : base(message, inner) { }

        public insertarFallidoBDException (string message, string arbitro) : this(message) {
            Arbitro = arbitro;
        }
    }
}
