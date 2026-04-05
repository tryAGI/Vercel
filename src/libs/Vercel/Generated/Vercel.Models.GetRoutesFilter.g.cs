
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetRoutesFilter
    {
        /// <summary>
        /// 
        /// </summary>
        Redirect,
        /// <summary>
        /// 
        /// </summary>
        Rewrite,
        /// <summary>
        /// 
        /// </summary>
        SetStatus,
        /// <summary>
        /// 
        /// </summary>
        Transform,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetRoutesFilterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRoutesFilter value)
        {
            return value switch
            {
                GetRoutesFilter.Redirect => "redirect",
                GetRoutesFilter.Rewrite => "rewrite",
                GetRoutesFilter.SetStatus => "set_status",
                GetRoutesFilter.Transform => "transform",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRoutesFilter? ToEnum(string value)
        {
            return value switch
            {
                "redirect" => GetRoutesFilter.Redirect,
                "rewrite" => GetRoutesFilter.Rewrite,
                "set_status" => GetRoutesFilter.SetStatus,
                "transform" => GetRoutesFilter.Transform,
                _ => null,
            };
        }
    }
}