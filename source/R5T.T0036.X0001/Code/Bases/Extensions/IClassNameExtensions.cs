using System;

using R5T.T0036;
using R5T.T0036.X0001;


namespace System
{
    [Obsolete("See R5T.Z0028.IClassNames")]
    public static class IClassNameExtensions
    {
        [Obsolete("See R5T.Z0028.IClassNames.Documentation")]
        public static string Documentation(this IClassName _)
        {
            return ClassNames.Documentation;
        }

        [Obsolete("See R5T.Z0028.IClassNames.HostStartup")]
        public static string HostStartup(this IClassName _)
        {
            return ClassNames.HostStartup;
        }

        [Obsolete("See R5T.Z0028.IClassNames.ServiceAggregation")]
        public static string ServiceAggregation(this IClassName _)
        {
            return ClassNames.ServiceAggregation;
        }
    }
}
