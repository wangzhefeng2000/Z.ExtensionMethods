// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_DateTime_EndOfWeek
    {
        [TestMethod]
        public void EndOfWeek()
        {
            // Type
            var @this = new DateTime(2014, 04, 16);

            // Examples
            DateTime value = @this.EndOfWeek(); // value = "2013/04/13 23:59:59:999";

            // Unit Test
            Assert.AreEqual(new DateTime(2014, 04, 19, 23, 59, 59, 999), value);
        }
    }
}