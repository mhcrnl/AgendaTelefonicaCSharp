using System;

namespace AgendaNume
{
	public class Nume
	{
		public string nume {get;set;}
		public string prenume { get; set;}
		public string telefon {get; set;}
		
		public Nume (string nume, string prenume, string telefon)
		{
			this.nume = nume;
			this.prenume = prenume;
			this.telefon = telefon;
		}
		
		//public string nume { get; set; }
		
		public override string ToString(){
			return nume + prenume + telefon;
		}
	}
}

