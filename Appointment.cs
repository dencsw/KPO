using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Appointment
{
	public virtual DateTime Date
	{
		get;
		set;
	}

	public virtual DateTime Time
	{
		get;
		set;
	}

	public virtual int AppID
	{
		get;
		set;
	}

	public virtual Bool Emergency
	{
		get;
		set;
	}

	public virtual void SetNewTime(object Date)
	{
		throw new System.NotImplementedException();
	}

	public virtual void CanselApp()
	{
		throw new System.NotImplementedException();
	}

	public virtual void Create()
	{
		throw new System.NotImplementedException();
	}

}

