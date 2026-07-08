
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectSecurityFirewallRouteTransformOp
    {
        /// <summary>
        /// 
        /// </summary>
        Append,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant2ProjectSecurityFirewallRouteTransformOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectSecurityFirewallRouteTransformOp value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectSecurityFirewallRouteTransformOp.Append => "append",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectSecurityFirewallRouteTransformOp? ToEnum(string value)
        {
            return value switch
            {
                "append" => GetProjectsResponseVariant2ProjectSecurityFirewallRouteTransformOp.Append,
                _ => null,
            };
        }
    }
}