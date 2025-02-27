﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Microsoft.Bot.Expressions.Memory
{
    public interface IMemory
    {
        /// <summary>
        /// Set value to a given path.
        /// </summary>
        /// <param name="path">memory path.</param>
        /// <param name="value">value to set.</param>
        void SetValue(string path, object value);

        /// <summary>
        /// Try get value from a given path, it can be a simple indenfiter like "a", or
        /// a combined path like "a.b", "a.b[2]", "a.b[2].c", inside [] is guranteed to be a int number or a string.
        /// </summary>
        /// <param name="path">memory path.</param>
        /// <param name="value">resovled value.</param>
        /// <returns> true if thememory contains an element with the specified key; otherwise, false.  </returns>
        bool TryGetValue(string path, out object value);

        /// <summary>
        /// Version is used to identify whether the a particular memory instance has been updated or not.
        /// If version is not changed, the caller may choose to use the cached result instead of recomputing everything.
        /// </summary>
        /// <returns>A string indicates the version.</returns>
        string Version();
    }
}
