namespace TestInterface.ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Service
    {
        public string ColorFill { get 
            {
                if (Discount > 0)
                {

                   
                    return "LimeGreen";
                }
                else
                {
                    return "AliceBlue";
                }
            } }
        
        public string CostSale { get
            {
                if (Discount >0)
                {
                    
                    decimal costSale = Cost * (1 - (decimal)Discount);
                    return costSale + " рублей за " + (DurationInSeconds / 60).ToString() + " минут";
                }
                else
                {
                    return Cost.ToString() + " рублей за " + (DurationInSeconds / 60).ToString() + " минут";
                }
            }
        }

        public string SizeOfDiscount { get
            {
                return "*cкидка" + (Discount * 100).ToString() +"%" ;
            }
        }
    }
}
