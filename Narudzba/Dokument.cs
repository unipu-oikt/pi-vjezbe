﻿using System;
namespace Narucivanje
{
	public class Dokument
	{
		public Dokument()
		{
			this.BrojDokumenta = 1;
			this.Datum = DateTime.Today;
		}

		public Dokument(long brojDokumenta, DateTime datum)
		{
			this.BrojDokumenta = brojDokumenta;
			this.Datum = datum;
			this.Zakljucen = false;
		}

		public long BrojDokumenta { get; set; }

		public DateTime Datum { get; set; }

		public bool Zakljucen { get; set; }

		public void Zakljuci()
		{
			this.Zakljucen = true;

		}
	}
}