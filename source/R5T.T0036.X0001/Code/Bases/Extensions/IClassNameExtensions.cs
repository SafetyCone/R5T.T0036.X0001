using System;

using R5T.T0036;
using R5T.T0036.X0001;


namespace System
{
    public static class IClassNameExtensions
    {
        public static string Documentation(this IClassName _)
        {
            return ClassNames.Documentation;
        }

        public static string HostStartup(this IClassName _)
        {
            return ClassNames.HostStartup;
        }

        public static string Instances(this IClassName _)
        {
            return ClassNames.Instances;
        }

        public static string ServiceAggregation(this IClassName _)
        {
            return ClassNames.ServiceAggregation;
        }
    }
}
