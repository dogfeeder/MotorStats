namespace MotorStats
{
    public class HorsepowerKilowattConvertService : IHorsepowerKilowattConvertService
    {
        private const double KILOWATTS_IN_HP = 0.745699872;
        private const double HP_IN_KILOWATTS = 1.3596216173039;

        public double ConvertToKilowatts(double horsepower) 
        {
            return horsepower * KILOWATTS_IN_HP;
        }

        public double ConvertToHorsepower(double kilowatts) 
        {
            return kilowatts * HP_IN_KILOWATTS;
        }
    }
}