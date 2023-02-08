using System;

using R5T.T0036;
using R5T.T0036.X0001;


namespace System
{
    public static class IInterfaceNameExtensions
    {
        [Obsolete("See R5T.Z0028.IInterfaceNames.IServiceAggregation")]
        public static string IServiceAggregation(this IInterfaceName _)
        {
            return InterfaceNames.IServiceAggregation;
        }

        [Obsolete("See R5T.Z0028.IInterfaceNames.IServiceAggregationIncrement")]
        public static string IServiceAggregationIncrement(this IInterfaceName _)
        {
            return InterfaceNames.IServiceAggregationIncrement;
        }
    }
}
