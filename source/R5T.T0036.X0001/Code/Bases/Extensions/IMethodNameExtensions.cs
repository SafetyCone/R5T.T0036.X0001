using System;

using R5T.T0036;
using R5T.T0036.X001;


namespace System
{
    public static class IMethodNameExtensions
    {
        public static string FillFrom(this IMethodName _)
        {
            return R5TMethodNames.FillFrom;
        }

        public static string New(this IMethodName _)
        {
            return R5TMethodNames.New;
        }

        public static string Run(this IMethodName _)
        {
            return R5TMethodNames.Run;
        }
    }
}