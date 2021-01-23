namespace TestInterface.ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    
    public partial class ClientService
    {
       
        public string Date { get
            {
                return StartTime.Day.ToString() + "-"+ StartTime.Month.ToString() + "-"+ StartTime.Year.ToString();
            }  
        }
        public string Time { get
            {
                return StartTime.Hour.ToString() + ":" + StartTime.Minute.ToString();
            }
        }

        public string Remaining { get
            {
                TimeSpan timeSpan = new TimeSpan();
                TimeSpan timeDuration = TimeSpan.FromSeconds(Service.DurationInSeconds);
                timeSpan = StartTime - DateTime.Now;
                return timeSpan.Days.ToString() + "д. " + timeSpan.Hours.ToString() + "ч. " + timeSpan.Minutes.ToString() + "мин.";
             }
        }
    }
}
