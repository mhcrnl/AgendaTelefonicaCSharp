using System;
using System.Windows.Forms;
using AgendaNume;

namespace AgendaNume
{
	public class MainClass
	{
		//string nume;
		
		public static void Main ()
		{
			Nume nume = new Nume("Mihai","Cornel","0722270796");
			Console.Write(nume.ToString());
			
			Application.Run(new GUIClass());
		}
	}
}

