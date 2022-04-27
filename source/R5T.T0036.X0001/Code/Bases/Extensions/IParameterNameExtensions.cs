using System;

using R5T.T0036;
using R5T.T0036.X0001;


namespace System
{
    public static class IParameterNameExtensions
    {
        public static string _(this IParameterName _)
        {
            return ParameterNames._;
        }

        public static string Services(this IParameterName _)
        {
            return ParameterNames.Services;
        }

        public static string Underscore(this IParameterName _)
        {
            return ParameterNames.Underscore;
        }
    }
}
