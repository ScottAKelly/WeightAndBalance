using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WeightAndBalanceApp.Data;
using WeightAndBalanceApp.Models;
using static WeightAndBalanceApp.Data.IdentityModel;

namespace WeightAndBalanceApp.Services
{
    public class PayloadService
    {
        public PayloadService svc = new PayloadService();

        public IEnumerable<PayloadEntity> GetPayloads(int aircraftId)
        {
            using (var ctx = new WeightAndBalanceDbContext())
            {
                var payloads = ctx.Payload;
                return
                    payloads
                    .Where(e => e.PayloadId == aircraftId)
                    .Select(
                        e =>
                        new PayloadEntity
                        {
                            PayloadId = e.PayloadId,
                            PayloadArm = e.PayloadArm,
                            PayloadMoment = e.PayloadMoment,
                            PayloadWeight = e.PayloadWeight
                        })
                .ToArray();
            }
        }

        public PayloadViewModel GetPayloadById(int aircraftId)
        {
            PayloadEntity entity;
            using (var ctx = new WeightAndBalanceDbContext())
            {
                entity =
                    ctx
                    .Payload
                    .SingleOrDefault(e => e.PayloadId == aircraftId);
            }
            return new PayloadViewModel
            {
                PayloadId = entity.PayloadId,
                PayloadArm = entity.PayloadArm,
                PayloadMoment = entity.PayloadMoment,
                PayloadWeight = entity.PayloadWeight
            };
        }

        public IEnumerable<float> GetItemsArms(int aircraftId)
        {
            using (var ctx = new WeightAndBalanceDbContext())
            {
                var itemArms = ctx.PayloadItems;
                return itemArms
                .Where(e => e.PayloadItemId == aircraftId)
                .Select(
                    e =>
                    e.PayloadItemArm)
                    .ToArray();
            }
        }

        //Retrieve all arms for each payload item and add it to a list
        //var totalItemsValues = new List<PayloadItemsEntity>();
        //foreach(var item in totalItemsValues)
        //{
        //  totalItemsValues.PayloadArm
        //}
        //return item.Add();


    }
}