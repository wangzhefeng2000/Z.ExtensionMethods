// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_ExtractInt64
    {
        [TestMethod]
        public void ExtractInt64()
        {
            // Type

            // Exemples
            long result1 = "Fizz 123 Buzz".ExtractInt64(); // return 123;
            long result2 = "Fizz -123 Buzz".ExtractInt64(); // return -123;
            long result3 = "-Fizz 123 Buzz".ExtractInt64(); // return 123;
            long result4 = "Fizz 123.456 Buzz".ExtractInt64(); // return 123456;
            long result5 = "Fizz -123Fizz.Buzz456 Buzz".ExtractInt64(); // return -123456;

            // Unit Test
            Assert.AreEqual(123, result1);
            Assert.AreEqual(-123, result2);
            Assert.AreEqual(123, result3);
            Assert.AreEqual(123456, result4);
            Assert.AreEqual(-123456, result5);
        }
    }
}