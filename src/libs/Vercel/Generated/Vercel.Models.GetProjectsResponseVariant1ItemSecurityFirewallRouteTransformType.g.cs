
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectsResponseVariant1ItemSecurityFirewallRouteTransformType
    {
        /// <summary>
        ///
        /// </summary>
        RequestHeaders,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant1ItemSecurityFirewallRouteTransformTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemSecurityFirewallRouteTransformType value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemSecurityFirewallRouteTransformType.RequestHeaders => "request.headers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemSecurityFirewallRouteTransformType? ToEnum(string value)
        {
            return value switch
            {
                "request.headers" => GetProjectsResponseVariant1ItemSecurityFirewallRouteTransformType.RequestHeaders,
                _ => null,
            };
        }
    }
}