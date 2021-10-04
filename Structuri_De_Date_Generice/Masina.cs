using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Structuri_De_Date_Generice
{
    class Masina : IComparable<Masina>
    {
        private String marca;
        private String culoare;

        public String Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public String Culoare
        {
            get { return culoare; }
            set { culoare = value; }
        }

        public Masina(String marca, String culoare)
        {
            this.marca = marca;
            this.culoare = culoare;
        }

        public override bool Equals(object obj)
        {
            Masina m = obj as Masina;

            if (this.marca.Equals(m.marca) && this.culoare == m.culoare)
                return true;
            return false;
        }

        public override string ToString()
        {
            String text = "";
            text += "Marca:" + this.marca;
            text += Environment.NewLine + "Culoare:" + this.culoare + Environment.NewLine;
            return text;
        }

        public int CompareTo(Masina other)
        {
            if (this.Equals(other))
                return 0;
            return this.marca.CompareTo(other.marca);
        }

    }
}
