using System;

using R5T.T0036;
using R5T.T0036.X0001;


namespace System
{
    public static class IInterfaceNameExtensions
    {
        public static string IServiceAggregation(this IInterfaceName _)
        {
            return InterfaceNames.IServiceAggregation;
        }

        public static string IServiceAggregationIncrement(this IInterfaceName _)
        {
            return InterfaceNames.IServiceAggregationIncrement;
        }
    }
}
