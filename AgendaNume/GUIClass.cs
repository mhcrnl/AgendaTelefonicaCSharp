using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using AgendaNume;

namespace AgendaNume
{
	public class GUIClass : Form
	{
		//Variabile de instanta
		public TextBox tbnume;
		public TextBox tbprenume;
		public TextBox tbtel;
		public TextBox tbtext;
		
		public List<Nume> listaNume = new List<Nume>();
		
		public GUIClass ()
		{
			Text = "Agenda Telefonica";
			Size = new Size(450, 450);
			
			//Adaugarea unui panel
			Panel pan = new Panel();
			pan.Location = new Point(5, 5);
			pan.Size = new Size(430, 100);
			pan.BorderStyle = BorderStyle.Fixed3D;
			Controls.Add(pan);
			
			//Adaugarea Label lbnume
			Label lbnume = new Label();
			lbnume.Text = "Nume";
			lbnume.Location = new Point(10,10);
			lbnume.Parent = pan;
			pan.Controls.Add(lbnume);
			
			//Adaugare TextBox tbnume
			tbnume = new TextBox();
			tbnume.Parent = pan;
			tbnume.Location = new Point(110, 10);
			tbnume.Anchor = AnchorStyles.Top;
			pan.Controls.Add(tbnume);
			
			//Adaugarea Label lbnume
			Label lbprenume = new Label();
			lbprenume.Text = "Prenume";
			lbprenume.Location = new Point(10,40);
			lbprenume.Parent = pan;
			pan.Controls.Add(lbprenume);
			
			//Adaugare TextBox tbnume
			tbprenume = new TextBox();
			tbprenume.Parent = pan;
			tbprenume.Location = new Point(110, 40);
			tbprenume.Anchor = AnchorStyles.Top;
			pan.Controls.Add(tbprenume);
			
			//Adaugarea Label lbnume
			Label lbtel = new Label();
			lbtel.Text = "Telefon";
			lbtel.Location = new Point(10,70);
			lbtel.Parent = pan;
			pan.Controls.Add(lbtel);
			
			//Adaugare TextBox tbnume
			tbtel = new TextBox();
			tbtel.Parent = pan;
			tbtel.Location = new Point(110, 70);
			tbtel.Anchor = AnchorStyles.Top;
			pan.Controls.Add(tbtel);
			
			//Adaugare Button btadd
			Button btadd = new Button();
			btadd.Text = "Adauga";
			btadd.Location = new Point(250, 10);
			//btadd.Anchor = AnchorStyles.Right;
			btadd.Parent = pan;
			btadd.Click += new EventHandler (addNume);
			pan.Controls.Add(btadd);
			
			Button cauta = new Button();
			cauta.Text = "Cauta";
			cauta.Location = new Point(330, 10);
			//btadd.Anchor = AnchorStyles.Right;
			cauta.Parent = pan;
			cauta.Click += new EventHandler (addNume);
			pan.Controls.Add(cauta);
			
			Button salveaza = new Button();
			salveaza.Text = "Salveaza";
			salveaza.Location = new Point(250, 40);
			//btadd.Anchor = AnchorStyles.Right;
			salveaza.Parent = pan;
			salveaza.Click += new EventHandler (addNume);
			pan.Controls.Add(salveaza);
			
			Button inchide = new Button();
			inchide.Text = "Inchide";
			inchide.Location = new Point(330, 40);
			//btadd.Anchor = AnchorStyles.Right;
			inchide.Parent = pan;
			inchide.Click += new EventHandler (OnClose);
			pan.Controls.Add(inchide);
			
			//Adaugarea unui panel
			Panel pan1 = new Panel();
			pan1.Location = new Point(5, 110);
			pan1.Size = new Size(430, 300);
			pan1.BorderStyle = BorderStyle.Fixed3D;
			Controls.Add(pan1);
			
			tbtext = new TextBox();
			tbtext.Multiline = true;
			tbtext.ScrollBars = ScrollBars.Vertical;
			tbtext.AcceptsReturn = true;
			tbtext.AcceptsTab =true;
			tbtext.Dock = DockStyle.Fill;
			pan1.Controls.Add(tbtext);
			
			CenterToScreen();
		}
		
		public void OnClose(object sender, EventArgs e){
			Close();	
		}
		
		public void addNume(object sender, EventArgs e)
		{
			//string nume = tbnume.Text;
			listaNume.Add(new Nume(tbnume.Text, tbprenume.Text, tbtel.Text));
			
			//Afisarea listei in consola
			foreach(var num in listaNume){
				Console.Write(num + " ");
				tbtext.Text= num.ToString();
			}
			
			tbnume.Text = "";
			tbprenume.Text = "";
			tbtel.Text = "";
		}
	}
}

