﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryProduction.Service.Constant
{
    public static class ApiEndPointConstant
    {
        static ApiEndPointConstant()
        {
        }

        public static class User
        {
            public const string GET_USER = "api/v1/user";
            public const string GET_USER_BY_ID = "api/v1/user/";
            public const string CREATE_USER = "api/v1/user/create";
            public const string UPDATE_USER = "api/v1/user/update";
            public const string CHANGE_STATUS_USER = "api/v1/user/change-status";
        }

        public static class Customer
        {
            public const string GET_CUSTOMER = "api/v1/customer";
            public const string GET_CUSTOMER_BY_ID = "api/v1/customer/";
            public const string CREATE_CUSTOMER = "api/v1/customer/create";
            public const string UPDATE_CUSTOMER = "api/v1/customer/update";
            public const string CHANGE_STATUS_CUSTOMER = "api/v1/customer/change-status";
        }


        public static class Order
        {
            public const string GET_ORDER = "api/v1/order";
            public const string GET_ORDER_BY_ID = "api/v1/order/";
            public const string CREATE_ORDER = "api/v1/order/create";
            public const string UPDATE_ORDER = "api/v1/order/update";
            public const string DELETE_ORDER = "api/v1/order/delete";
        }

        public static class OrderItem
        {
            public const string GET_ORDERITEM = "api/v1/orderitem";
            public const string GET_ORDERITEM_BY_ID = "api/v1/orderitem/";
            public const string CREATE_ORDERITEM = "api/v1/orderitem/create";
            public const string UPDATE_ORDERITEM = "api/v1/orderitem/update";
            public const string CHANGE_STATUS_ORDERITEM = "api/v1/orderitem/change-status";
        }

        public static class Counter
        {
            public const string GET_COUNTER = "api/v1/counter";
            public const string GET_COUNTER_BY_ID = "api/v1/counter/";
            public const string CREATE_COUNTER = "api/v1/counter/create";
            public const string UPDATE_COUNTER = "api/v1/counter/update";
            public const string CHANGE_STATUS_COUNTER = "api/v1/counter/change-status";

        }
        
        
        public static class UserCounter
        {
            public const string GET_USER_COUNTER = "api/v1/user-counter";
            public const string GET_USER_COUNTER_BY_ID = "api/v1/user-counter/"; 
            public const string CREATE_USER_COUNTER = "api/v1/user-counter/create";
            public const string UPDATE_USER_COUNTER = "api/v1/user-counter/update";
            public const string CHANGE_STATUS_USER_COUNTER = "api/v1/user-counter/change-status";
        }

        public static class Warranty
        {
            public const string GET_WARRANTY = "api/v1/warranty";
            public const string GET_WARRANTY_BY_ID = "api/v1/warranty/";
            public const string CREATE_WARRANTY = "api/v1/warranty/create";
            public const string UPDATE_WARRANTY = "api/v1/warranty/update";
            public const string CHANGE_STATUS_WARRANTY = "api/v1/warranty/change-status";
        }

        public static class Promotion
        {
            public const string GET_PROMOTION = "api/v1/promotion";
            public const string GET_PROMOTION_BY_ID = "api/v1/promotion/";
            public const string CREATE_PROMOTION = "api/v1/promotion/create";
            public const string UPDATE_PROMOTION = "api/v1/promotion/update";
            public const string CHANGE_STATUS_PROMOTION = "api/v1/promotion/change-status";
        }
    }
}
