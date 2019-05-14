

namespace Exercicio_Employees2.Entities
{
   public class OutSourcedEmployee : Employees
    {
        public double AdditionalCharge { get; set; }

        public OutSourcedEmployee() { }

        public OutSourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) 
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double payment()
        {
            return base.payment() +  1.1  * AdditionalCharge;
             
        }

    }
}
