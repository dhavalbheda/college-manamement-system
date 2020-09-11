using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AD_CMS_Entity
{
    public class FinanceEntity
    {
        public int Grno;
        public string name;
        public string courseName;

        public DateTime paymentDate;
        public int paymentYear;
        public int paidFee;
        public int totalPaid;
        public int due;
        public int discountPercent;
        public int payableFees;
        public int TotalFees;
        public int PaymentModeId;
    }
}
