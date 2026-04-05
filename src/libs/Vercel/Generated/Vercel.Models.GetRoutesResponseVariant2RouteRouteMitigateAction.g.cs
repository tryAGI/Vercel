
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetRoutesResponseVariant2RouteRouteMitigateAction
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
    public static class GetRoutesResponseVariant2RouteRouteMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRoutesResponseVariant2RouteRouteMitigateAction value)
        {
            return value switch
            {
                GetRoutesResponseVariant2RouteRouteMitigateAction.Challenge => "challenge",
                GetRoutesResponseVariant2RouteRouteMitigateAction.Deny => "deny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRoutesResponseVariant2RouteRouteMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetRoutesResponseVariant2RouteRouteMitigateAction.Challenge,
                "deny" => GetRoutesResponseVariant2RouteRouteMitigateAction.Deny,
                _ => null,
            };
        }
    }
}