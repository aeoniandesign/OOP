﻿using System;

public class Time : object
{
   private int hour;
   private int minute;
   private int second;


   public Time()
   {
	  setTime(00, 00, 00);
   }

   public Time(int h)
   {
	  setTime(h, 00, 00);
   }

   public Time(int h, int m)
   {
	  setTime(h, m, 00);
   }

   public Time(int h, int m, int s)
   {
	  setTime(h, m, s);
   }

   public Time(Time time)
   {
	  setTime(time.Hour, time.Minute, time.Second);
   }

   public virtual bool setTime(int h, int m, int s)
   {
	  if (h < 00 && h > 24)
	  {
		  h = 00;
	  }
	  if (m < 00 && h > 60)
	  {
		  m = 00;
	  }
	  if (s < 00 && h > 60)
	  {
		  s = 00;
	  }
	  this.hour = h;
	  this.minute = m;
	  this.second = s;
	  return true;
   }

   public virtual bool setHour(int h)
   {
	 if (h < 00 && h > 24)
	 {
		 h = 00;
	 }
	 this.hour = h;
	   return false;
   }

   public virtual bool setMinute(int m)
   {
	 if (m < 00 && m > 24)
	 {
		 m = 00;
	 }
	 this.minute = m;
	   return false;
   }

   public virtual bool setSecond(int s)
   {
	 if (s < 00 && s > 24)
	 {
		 s = 00;
	 }
	 this.second = s;
	   return false;
   }

   public virtual int Hour
   {
	   get
	   {
		  return hour;
	   }
   }

   public virtual int Minute
   {
	   get
	   {
		  return minute;
	   }
   }

   public virtual int Second
   {
	   get
	   {
		  return second;
	   }
   }

   public virtual string toUniversalString()
   {
      return (hour) + ":" + (Minute) + ":" + (Second);
   }

   public override string ToString()
   {
	  return ((Hour == 12 || Hour == 0) ? 12 : Hour % 12) + ":" +(Minute) + ":" + (Second) + (Hour < 12 ? " AM" : " PM");
   }
}
