using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_oop_member
{
    using InheritanceExampleCliApp;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;





    public abstract class CompetitiveMember : Member
    {

        public double Discount {  get; set; }

        public DateTime UpgradeDate { get; set; }

        public string PersonalCoach {  get; set; }



        public CompetitiveMember(double Discount, DateTime UpgradeDate, string PersonalCoach)
        
        { 
        
            this.Discount = Discount;
            this.UpgradeDate = UpgradeDate;
            this.PersonalCoach = PersonalCoach;
            
        
        }


       public CompetitiveMember()
        
        {
           Discount = 0;
           UpgradeDate = DateTime.MinValue;
           PersonalCoach = "";
        
        
        }


        public abstract class EliteMember : CompetitiveMember
        {



        }

        public abstract class ProMember : CompetitiveMember

        { 
                  List<string> MultipleSponsers { get; set; }  




        
        
        }


    }
}
