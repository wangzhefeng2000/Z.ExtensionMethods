// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_ByteArray_ToMemoryStream
    {
        [TestMethod]
        public void ToMemoryStream()
        {
            // Type
            var @this = new Byte[1] {1};

            // Exemples
            MemoryStream result = @this.ToMemoryStream(); // return an iMemoryStream

            // Unit Test
            Assert.AreEqual(1, result.ToArray()[0]);
        }
    }
}