// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Data.Test
{
    [TestClass]
    public class System_Data_SqlClient_SqlConnection_ExecuteExpandoObjects
    {
        [TestMethod]
        public void ExecuteExpandoObjects()
        {
            string sql = "SELECT 1 AS IntColumn, 'FizzBuzz' AS StringColumn UNION SELECT 2, 'BuzzBuzz' WHERE @Fizz = 1";
            var dict = new Dictionary<string, object> {{"@Fizz", 1}};

            // Examples
            using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
            {
                conn.Open();
                List<dynamic> list = conn.ExecuteExpandoObjects(sql, dict.ToSqlParameters()).ToList();

                // Unit Test
                Assert.AreEqual(1, list[0].IntColumn);
                Assert.AreEqual("FizzBuzz", list[0].StringColumn);
                Assert.AreEqual(2, list[1].IntColumn);
                Assert.AreEqual("BuzzBuzz", list[1].StringColumn);
            }
        }
    }
}