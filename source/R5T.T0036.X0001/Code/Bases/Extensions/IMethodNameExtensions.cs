using System;

using R5T.T0036;
using R5T.T0036.X001;


namespace System
{
    [Obsolete("See R5T.Z0028.IMethodNames")]
    public static class IMethodNameExtensions
    {
        [Obsolete("See R5T.Z0028.IMethodNames.FillFrom")]
        public static string FillFrom(this IMethodName _)
        {
            return MethodNames.FillFrom;
        }

        [Obsolete("See R5T.Z0028.IMethodNames.New")]
        public static string New(this IMethodName _)
        {
            return MethodNames.New;
        }

        [Obsolete("See R5T.Z0028.IMethodNames.Run")]
        public static string Run(this IMethodName _)
        {
            return MethodNames.Run;
        }
    }
}