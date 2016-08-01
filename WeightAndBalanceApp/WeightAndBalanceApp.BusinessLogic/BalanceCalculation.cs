using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WeightAndBalanceApp.Data;
using WeightAndBalanceApp.Models;
using WeightAndBalanceApp.Services;

namespace WeightAndBalanceApp.BusinessLogic
{
    public class BalanceCalculation
    {
        //Need to pass in payload items as float[]
        private AircraftEntity _aircraft = new AircraftEntity();
        private PayloadEntity _payload = new PayloadEntity();
        private PayloadItemsEntity _payloadItems = new PayloadItemsEntity();


        //Make separate methods for each part of the total calculation. As per "Clean Code".

        //Maybe try to pass in aircraft, payload, and payloadItems ids and use a foreach loop to iterate over each property to find it's value instead of pass all values in as parameters..

        //Create a method to calculate the payload from the payload items. Then use that method in a different method to find CG's.

        public float DoMath(AircraftViewModel aircraftVM)
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

        public float GetTotalPayloadItemsArms()
        {
            //pass in GetItemsArms method from payload service
        }
        
    }
}
