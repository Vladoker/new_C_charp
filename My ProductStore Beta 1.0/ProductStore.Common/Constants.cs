﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Common
{
    public static class Constants
    {
        public static class ProductDays
        {
            public const int ValidPeriod = 3;
        }

        public const string ProductStorePath = @"D:\ProductStore\ProductStore\DATA\Products.txt";
        public const string OwnerStorePath = @"D:\ProductStore\ProductStore\DATA\Owners.txt";

        public const string ProductStorePathXml = @"D:\ProductStore\ProductStore\DATA\Products.xml";

        public const string TempProductStorePathXml = @"D:\ProductStore\ProductStore\DATA\";
    }
}