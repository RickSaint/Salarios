namespace NewProject.Entities
{
    class outsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public outsourcedEmployee()
        {

        }

        public outsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) 
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;

        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}
