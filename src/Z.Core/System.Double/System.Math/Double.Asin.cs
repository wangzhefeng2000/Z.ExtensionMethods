// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;

public static partial class Extensions
{
    /// <summary>
    ///     Returns the angle whose sine is the specified number.
    /// </summary>
    /// <param name="d">
    ///     A number representing a sine, where  must be greater than or equal to -1, but less than or equal
    ///     to 1.
    /// </param>
    /// <returns>
    ///     An angle, ?, measured in radians, such that -?/2 ????/2 -or-  if  &lt; -1 or  &gt; 1 or  equals .
    /// </returns>
    public static Double Asin(this Double d)
    {
        return Math.Asin(d);
    }
}