﻿
#region License, Terms and Conditions
//
// ICredit.cs
//
// Authors: Kori Francis <twitter.com/djbyter>, David Ball
// Copyright (C) 2010 Clinical Support Systems, Inc. All rights reserved.
// 
//  THIS FILE IS LICENSED UNDER THE MIT LICENSE AS OUTLINED IMMEDIATELY BELOW:
//
//  Permission is hereby granted, free of charge, to any person obtaining a
//  copy of this software and associated documentation files (the "Software"),
//  to deal in the Software without restriction, including without limitation
//  the rights to use, copy, modify, merge, publish, distribute, sublicense,
//  and/or sell copies of the Software, and to permit persons to whom the
//  Software is furnished to do so, subject to the following conditions:
//
//  The above copyright notice and this permission notice shall be included in
//  all copies or substantial portions of the Software.
//
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
//  FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//  DEALINGS IN THE SOFTWARE.
//
#endregion

// ReSharper disable once CheckNamespace
namespace ChargifyNET
{
    #region Imports
    using System;
    #endregion

    /// <summary>
    /// One-time (or one-off) credit for arbitrary amount
    /// </summary>
    public interface ICredit : IComparable<ICredit>
    {
        /// <summary>
        /// Either true or false, depending on the success of the credit
        /// </summary>
        bool Success { get; }

        /// <summary>
        /// Get the amount, in cents
        /// </summary>
        int AmountInCents { get; }

        /// <summary>
        /// Get the amount, in dollars and cents
        /// </summary>
        decimal Amount { get; }

        /// <summary>
        /// The memo for the created credit
        /// </summary>
        string Memo { get; }
    }
}
