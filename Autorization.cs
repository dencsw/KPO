using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Autorization
{
	public virtual void NewPatient()
	{
		int SNILS  = 167000000;
		string FIO = "Коновалов Д.С.";
		string Password = "qwerty123";
		Patient p = new Patient(SNILS, FIO, Password);
		throw new System.NotImplementedException();
	}

	public virtual void LogIn(int id)
	{
		throw new System.NotImplementedException();
	}

	public virtual List<Patient> AllPatients()
	{
		throw new System.NotImplementedException();
	}

}

