using LKS_Hospital.lib;
using LKS_Hospital.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS_Hospital.dataAccess
{
    public class PaymentDataAccess : Database
    {
        public PaymentModel GetPayment(int meetingId)
        {
            return Read<PaymentModel>(
                $"select top 1 * from payment where meeting_id = {meetingId}",
                selector: PaymentModel.Map
                ).FirstOrDefault();
        }

        public List<PaymentDetailModel> GetPaymentDetails(int paymentId)
        {
            return Read<PaymentDetailModel>(
                $"select * from payment_detail where payment_id = {paymentId}",
                selector: PaymentDetailModel.Map
                ).ToList();
        }

        public void DeletePayment(int paymentId)
        {
            Execute($"delete payment_detail where payment_id = {paymentId};");
            
            Execute($"delete payment where id = {paymentId}");
        }

        public void UpdatePayment(int paymentId, string cardHolderName, string primaryAccountNumber, DateTime expDate, int serviceCode)
        {
            Execute($@"
                update payment set
	                card_holder_name = '{cardHolderName}',
	                primary_account_number = '{primaryAccountNumber}',
	                expiration_date = '{expDate.ToString("yyyy-MM-dd")}',
	                service_code = {serviceCode}
                where 
	                id = {paymentId}
            ");
        }

        public void AddPayment(int paymentId, string item, decimal nominal, string notes)
        {
            Execute($@"
                insert into payment_detail
                (
                    payment_id,
                    item,
                    nominal,
                    notes
                )
                values
                (
                    {paymentId},
                    '{item}',
                    {nominal},
                    '{notes}'
                )
            ");
        }
    }
}
