
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetRoutesResponseVariant3RouteRouteMitigateAction
    {
        /// <summary>
        /// 
        /// </summary>
        Challenge,
        /// <summary>
        /// 
        /// </summary>
        Deny,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetRoutesResponseVariant3RouteRouteMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRoutesResponseVariant3RouteRouteMitigateAction value)
        {
            return value switch
            {
                GetRoutesResponseVariant3RouteRouteMitigateAction.Challenge => "challenge",
                GetRoutesResponseVariant3RouteRouteMitigateAction.Deny => "deny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRoutesResponseVariant3RouteRouteMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetRoutesResponseVariant3RouteRouteMitigateAction.Challenge,
                "deny" => GetRoutesResponseVariant3RouteRouteMitigateAction.Deny,
                _ => null,
            };
        }
    }
}