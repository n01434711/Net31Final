using System;
using System.Collections.Generic;
using System.Text;

namespace Net31.Wynnie.FinalExam.BusinessLogic
{
    public class Constants
    {
        public const int CUSTOMER_NAME_LENGTH_MIN = 10;
        public const int CUSTOMER_AGE_MIN = 18;
        public const int CUSTOMER_AGE_MAX = 100;
        public static readonly DateTime ORDER_DATE_MIN = new DateTime(2000, 1, 1);
        public static readonly DateTime ORDER_DATE_MAX = new DateTime(2020, 12, 31);
        public const int PRODUCT_NAME_LENGTH_MIN = 5;

        public const int CUSTOMER_NAME_ERROR= 101;
        public const int CUSTOMER_AGE_ERROR = 102;
        public const int ORDER_DATE_ERROR = 201;
        public const int PRODUCT_NAME_ERROR = 301;
    }
}
