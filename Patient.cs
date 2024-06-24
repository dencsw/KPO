
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Patient
{
	public virtual int SNILS
	{
		get;
		set;
	}

	public virtual string Password
	{
		get;
		set;
	}

	public virtual string FIO
	{
		get;
		set;
	}

	public virtual string GetNewPassword()
	{
		string pass = "NewPassword";
		Random rnd = new Random();
		pass = pass + rnd;
		throw new System.NotImplementedException();
	}

	public virtual List<Appointment> CurrentApps()
	{
		throw new System.NotImplementedException();
	}

}

