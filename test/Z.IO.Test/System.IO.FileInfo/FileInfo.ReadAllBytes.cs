// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.IO.Test
{
    [TestClass]
    public class System_IO_FileInfo_ReadAllBytes
    {
        [TestMethod]
        public void ReadAllBytes()
        {
            // Type
            var @this = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Examples_System_IO_FileInfo_ReadAllBytes.txt"));

            // Intialization
            using (FileStream stream = @this.Create())
            {
                stream.WriteByte(0);
            }

            // Examples
            byte[] value = @this.ReadAllBytes(); // return byte[] { 0 };

            // Unit Test
            Assert.AreEqual(0, value[0]);
        }
    }
}