using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WeightAndBalanceApp.Data;

namespace WeightAndBalanceApp.BusinessLogic
{
    public class BalanceCalculation
    {
        //Need to pass in payload items as float[]
        private AircraftEntity _aircraft = new AircraftEntity();
        private PayloadEntity _payload = new PayloadEntity();
        private PayloadItemsEntity _payloadItems = new PayloadItemsEntity();

        public float DoMath(float basicEmptyWeight, float basicEmptyWeightMoment, float basicEmptyWeightArm, int zeroFuelWeight, float zeroFuelWeightArm, float zeroFuelWeightMoment, int fuelLoad, float fuelLoadMoment, float fuelLoadArm, float rampWeight, float rampWeightArm, float rampWeightMoment, int lessFuelForTaxiWeight, float lessFuelForTaxiArm, float lessFuelForTaxiMoment, float takeOffWeight, float takeOffWeightMoment, float takeOffWeightArm, int lessFuelToDestination, int landingWeight, float landingWeightArm, float landingWeightMoment, float maxZeroFuelWeight, float maxRampWeight, float maxTakeOffWeight, PayloadEntity payload, PayloadItemsEntity payloadItems)
        {
            float ZeroFuelWeightForwardCG = 0;
            float ZeroFuelWeightAftCG = 0;
            float TakeoffWeightForwardCG = 0;
            float TakeoffWeightAftCG = 0;
            float LandingWeightForwardCG = 0;
            float LandingWeightAftCG = 0;



            return ZeroFuelWeightAftCG;
            return ZeroFuelWeightForwardCG;
            return TakeoffWeightAftCG;
            return TakeoffWeightForwardCG;
            return LandingWeightAftCG;
            return LandingWeightForwardCG;

        }
        
    }
}
