using System;

using R5T.T0036;
using R5T.T0036.X0001;


namespace System
{
    [Obsolete("See R5T.Z0028.IRegionNames")]
    public static class IRegionNameExtensions
    {
        [Obsolete("See R5T.Z0028.IRegionNames")]
        public static string Static(this IRegionName _)
        {
            return RegionNames.Static;
        }
    }
}
