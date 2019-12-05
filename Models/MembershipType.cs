using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace PVO.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }


        //Added these static value to make the code more readable within the Min18YearsIfAMember Call
        public static readonly byte Unknown = 0;
        public static readonly byte PayAsYouGo = 1;
//        public static readonly byte Monthly = 2;
//        public static readonly byte Quarterly = 3;
//        public static readonly byte Annual = 4;
    



    }
}