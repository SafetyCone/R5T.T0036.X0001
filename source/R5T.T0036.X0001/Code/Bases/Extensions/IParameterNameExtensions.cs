using System;

using R5T.T0036;
using R5T.T0036.X0001;


namespace System
{
    [Obsolete("See R5T.Z0028.IParameterNames")]
    public static class IParameterNameExtensions
    {
        [Obsolete("See R5T.Z0028.IParameterNames._")]
        public static string _(this IParameterName _)
        {
            return ParameterNames._;
        }

        [Obsolete("See R5T.Z0028.IParameterNames.Services")]
        public static string Services(this IParameterName _)
        {
            return ParameterNames.Services;
        }

        [Obsolete("See R5T.Z0028.IParameterNames.Underscore")]
        public static string Underscore(this IParameterName _)
        {
            return ParameterNames.Underscore;
        }
    }
}
