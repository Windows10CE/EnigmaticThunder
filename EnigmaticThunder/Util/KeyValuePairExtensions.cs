﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaticThunder.Util
{
    /// <summary>
    /// Extensions for key value pairs
    /// </summary>
    public static class KeyValuePairExtensions
    {
        /// <summary>
        /// Extension to allow tuple style deconstruction of keys and values when enumerating a dictionary.
        /// Example: foreach(var (key, value) in myDictionary)
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="kvp"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void Deconstruct<TKey, TValue>(this KeyValuePair<TKey, TValue> kvp, out TKey key, out TValue value)
        {
            key = kvp.Key;
            value = kvp.Value;
        }
    }
}
