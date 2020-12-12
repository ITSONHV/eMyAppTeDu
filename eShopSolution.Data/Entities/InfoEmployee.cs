using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class InfoEmployee
    {
        public Int64 Id { get; set; }

        public string DVCS_ID { get; set; }

        public string MA_NV { get; set; }

        public string HO_TEN { get; set; }

        public string MA_PB { get; set; }

        public DateTime NGAY_SINH { get; set; }

        public string GIOI_TINH { get; set; }

        public string TON_GIAO { get; set; }

        public string DAN_TOC { get; set; }

        public string HON_NHAN { get; set; }

        public string QUOC_TICH { get; set; }

        public string CMND { get; set; }

        public DateTime NGAY_CAP { get; set; }
        public string NOI_CAP { get; set; }
        public string QUE_QUAN { get; set; }
        public string NOI_SINH { get; set; }

        public string DTDD { get; set; }

        public string EMAIL { get; set; }

        public string DIA_CHI { get; set; }

        public decimal LUONG_CB { get; set; }

        public decimal LUONG_BH { get; set; }
    }
}