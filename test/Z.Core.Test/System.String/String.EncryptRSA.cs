// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_EncryptRSA
    {
        [TestMethod]
        public void EncryptRSA()
        {
            // Type
            string @this = "Fizz";

            // Examples
            string value = @this.EncryptRSA("Buzz"); // return Encrypted string;

            // Unit Test
            Assert.AreEqual("Fizz", value.DecryptRSA("Buzz"));
        }
    }
}