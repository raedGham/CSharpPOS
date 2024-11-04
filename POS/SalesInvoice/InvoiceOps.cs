using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace POS.SalesInvoice
{
    internal class InvoiceOps
    {
        public int MainID { get; set; }
        public int DetailID { get; set; }

        public int Total { get; set; }
        public int Status { get; set; }

 
        public static void AddInvoice(double pTotal, int pType, int pDeliveryID, DateTime pDeliveryTime,  int pClientID,
                               double pCashIn, double pCashOut, bool pSlipWI  )
        {
            
            string qry1 = @"Insert into [sales invoice] values (@aRef , @aDate, @aTime, @Total, @Paid,@Attach, @Discount,@Type, @DeliveryID, @DeliveryTime, @ClientID,
                   @Call, @Printed, @cashIn, @CashOut,@SlipWI, @Delivered);                          
                   Select SCOPE_IDENTITY()";

            Hashtable ht = new Hashtable();
            SqlCommand cmd = new SqlCommand(qry1, MainClass.con);

            ht.Add("@aRef", "-");
            ht.Add("@aDate", Convert.ToDateTime(DateTime.Now.Date));
            ht.Add("@aTime", DateTime.Now.ToShortTimeString());
            ht.Add("@Total", pTotal);
            ht.Add("@Paid", false);
            ht.Add("@Attach", "-");
            ht.Add("@Discount", Convert.ToDouble(0));
            ht.Add("@Type", pType);
            ht.Add("@DeliveryID", pDeliveryID);
            ht.Add("@DeliveryTime", pDeliveryTime);
            ht.Add("@ClientID", pClientID);
            ht.Add("@Call", "-");
            ht.Add("@Printed", false);
            ht.Add("@CashIn", pCashIn);
            ht.Add("@CashOut", pCashOut);
            ht.Add("@SlipWI", pSlipWI);
            ht.Add("@Delivered", false);


            MainClass.SQ1(qry1, ht);                     
            MessageBox.Show("Saved Sucessfully");
        }

        public void AddInvoiceItems(string qry)
        {

        }

        public void DeleteInvoice(string qry) 
        {
        
        }

        public void UpdateInvoice(string qry)
        {

        }

    }
}
