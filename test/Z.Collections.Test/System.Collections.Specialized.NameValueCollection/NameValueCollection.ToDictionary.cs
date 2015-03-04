// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System.Collections.Generic;
using System.Collections.Specialized;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Collections.Test
{
    [TestClass]
    public class System_Collections_Specialized_NameValueCollection_ToDictionary
    {
        [TestMethod]
        public void ToDictionary()
        {
            // Type
            var @this = new NameValueCollection {{"Fizz", "Buzz"}};

            // Exemples
            IDictionary<string, object> result = @this.ToDictionary(); // return a Dictionary;

            // Unit Test
            Assert.AreEqual("Buzz", result["Fizz"]);
        }
    }
}