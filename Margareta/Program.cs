using System;
using System.Collections.Generic;

class Program
{
	static void Main ()
	{
		List<Produkt> produkter = new List <Produkt>();

		produkter.Add (new Produkt ("Grönsakstårtan",456));

		bool kör = true;

		while (kör)
		{
			try
			{
				Console.Write ("Ange en tårta, eller skriv 'stopp'");
				string namn = Console.ReadLine();

				if(namn.ToLower () =="stopp")
				{
					kör = false;
					continue;
				}

				Console.Write ("Kostnad för tårtan:");
				double pris = Convert.ToDouble(Console.ReadLine());

				produkter.Add (new Produkt (namn,pris));
			}

			catch
			{
				Console.WriteLine ("Du har inte skrivit ett tal");
			}
		}

		Console.WriteLine ("\nTårtlistan");
		foreach (Produkt p in produkter)
		{
			p.VisaInfo();
		}
	}
}