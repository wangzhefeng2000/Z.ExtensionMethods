// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Data.Test
{
    [TestClass]
    public class System_Data_IDataReader_IsDBNull
    {
        [TestMethod]
        public void IsDBNull()
        {
            const string sql = @"
SELECT 1, NULL
";

            // Examples
            using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
            {
                using (SqlCommand @this = conn.CreateCommand())
                {
                    conn.Open();
                    @this.CommandText = sql;
                    using (SqlDataReader reader = @this.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            bool result1 = reader.IsDBNull(0); // return false;
                            bool result2 = reader.IsDBNull(1); // return true;

                            // UnitTest
                            Assert.IsFalse(result1);
                            Assert.IsTrue(result2);
                        }
                    }
                }
            }
        }
    }
}