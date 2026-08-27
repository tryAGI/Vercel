
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectsResponseVariant1ItemSecurityFirewallRouteTransformOp
    {
        /// <summary>
        ///
        /// </summary>
        Append,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant1ItemSecurityFirewallRouteTransformOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemSecurityFirewallRouteTransformOp value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemSecurityFirewallRouteTransformOp.Append => "append",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemSecurityFirewallRouteTransformOp? ToEnum(string value)
        {
            return value switch
            {
                "append" => GetProjectsResponseVariant1ItemSecurityFirewallRouteTransformOp.Append,
                _ => null,
            };
        }
    }
}