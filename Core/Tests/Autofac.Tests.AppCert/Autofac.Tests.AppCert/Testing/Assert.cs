﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Autofac.Tests.AppCert.Testing
{
    public static class Assert
    {
        public static void AreEqual(object expected, object actual, string message = null)
        {
            if (!ObjectsEqual(expected, actual))
            {
                var exMessage = message == null ? null : message + Environment.NewLine;
                throw new AssertionException(String.Format("Expected: {0}{2}Actual: {1}{2}{3}", expected, actual, Environment.NewLine, exMessage));
            }
        }

        private static bool ObjectsEqual(object x, object y)
        {
            if (x == null && y == null)
            {
                return true;
            }
            if (x == null || y == null)
            {
                return false;
            }
            if (Object.ReferenceEquals(x, y))
            {
                return true;
            }
            return x.Equals(y);
        }
    }
}