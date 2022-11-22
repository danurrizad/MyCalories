using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalories
{
    public class MaleUser : User
    {
        public override double CalculateBMR()
        {
            double BMR = 0;

            BMR = 88.362 + (13.397 * Weight) + (4.799 * Height) - (5.677 * Age);

            return BMR;
        }

        public override double GetRDA()
        {
            double RDA = 0;
            double BMR = CalculateBMR();

            //Based on sehatq.com
            if (this.Activities == 0)
                RDA = 1.2 * BMR;
            else if (this.Activities > 0 || this.Activities <= 3)
                RDA = 1.375 * BMR;
            else if (this.Activities > 3 || this.Activities <= 5)
                RDA = 1.55 * BMR;
            else if (this.Activities > 5 || this.Activities <= 7)
                RDA = 1.725 * BMR;
            else
                RDA = 1.9 * BMR;

            return RDA;
        }
    }
}
