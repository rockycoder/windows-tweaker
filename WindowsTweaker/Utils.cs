﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace WindowsTweaker
{
    static class Utils
    {
        public static Func<int?, bool> IntToBool = (int? val) => !(val == 0 || val == null);

        public static Func<bool?, int> BoolToInt = (bool? val) => val == true ? 1 : 0;

        public static Func<string, bool> StringToBool = (String val) => val != null && val.Equals("1");

        public static Func<bool?, String> BoolToString = (bool? val) => val == true ? "1" : "0";

        public static void SafeDeleteRegistryValue(RegistryKey regKey, String keyName) {
            // Can't extend Microsoft.Win32.RegistryKey since its sealed, hence has to put this in Utils.cs
            try {
                regKey.DeleteValue(keyName);
            } catch (ArgumentException) {

            }
        }
    }
}
