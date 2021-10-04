using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Structuri_De_Date_Generice
{
    class Persoana : IComparable<Persoana>
    {
        private String nume;
        private int varsta;
        private String functie;

        public String Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        public int Varsta
        {
            get { return varsta; }
            set { varsta = value; }
        }

        public String Functie
        {
            get { return functie; }
            set { this.functie = value; }
        }

        public Persoana(String nume, int varsta, String functie)
        {
            this.nume = nume;
            this.varsta = varsta;
            this.functie = functie;
        }

        public override bool Equals(object obj)
        {
            Persoana p = obj as Persoana;

            if (p.nume.Equals(this.nume) && p.varsta == this.varsta)
                return true;
            return false;
        }

        public override string ToString()
        {
            String text = "";
            text += "Nume:" + this.nume;
            text += Environment.NewLine + "Varsta:" + this.varsta + Environment.NewLine;
            return text;
        }

        public int CompareTo([AllowNull] Persoana other)
        {
            if (this.Equals(other))
                return 0;
            if (this.varsta < other.varsta)
                return -1;
            if (this.varsta > other.varsta)
                return 1;
            return 0;
        }

        public override int GetHashCode()
        {
            return this.nume.Length;
        }
    }
}
