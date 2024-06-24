using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Doctor
{
	public virtual int ID
	{
		get;
		set;
	}

	public virtual List<String> Days
	{
		get;
		set;
	}

	public virtual string specialization
	{
		get;
		set;
	}

	public virtual List <Appointment> GetAllApps()
	{
		throw new System.NotImplementedException();
	}

	public virtual void ModifyApp(object AppID)
	{
		throw new System.NotImplementedException();
	}

}

