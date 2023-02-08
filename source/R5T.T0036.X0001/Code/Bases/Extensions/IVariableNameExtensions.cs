using System;

using R5T.T0036;
using R5T.T0036.X0001;


namespace System
{
    [Obsolete("See R5T.Z0028.IVariableNames")]
    public static class IVariableNameExtensions
    {
        [Obsolete("See R5T.Z0028.IVariableNames.ServiceAction")]
        public static string ServiceAction(this IVariableName _)
        {
            return VariableNames.ServiceAction;
        }
    }
}
