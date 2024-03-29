﻿using SAPbobsCOM;
using SAPWS.VIEWMODEL.Document;
using SAPWS.XMLMODEL.Document;
using SAPWS.XMLMODEL.Payment;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SAPWS.VIEWMODEL.Payment
{
    public class PaymentViewModel
    {
        public PaymentViewModel()
        {
            this.PaymentInvoices = new List<PaymentInvoiceViewModel>();
        }
        public Int32 DocEntry { get; set; }
        public BoRcptTypes DocType { get; set; }
        public DateTime DocDate { get; set; }
        public DateTime TaxDate { get; set; }
        public DateTime DueDate { get; set; }
        public String CardCode { get; set; }
        public String DocCurrency { get; set; }
        public Double DocRate { get; set; }
        public String CounterReference { get; set; }
        public String Remarks { get; set; }
        public Double CashSum { get; set; }
        public String CashAccount { get; set; }
        public Double BankChargeAmount { get; set; } 

        #region UserFields

        public String U_BPP_MPPG { get; set; }
        public String U_MSS_MPSA { get; set; }

        #endregion

        public List<PaymentInvoiceViewModel> PaymentInvoices { get; set; }

        #region SAPProperties

        public Int32 Series { get; set; }
        #endregion

        #region ApplicationProperties

        public Boolean IsUpdate { get; set; }

        #endregion

    }




}
