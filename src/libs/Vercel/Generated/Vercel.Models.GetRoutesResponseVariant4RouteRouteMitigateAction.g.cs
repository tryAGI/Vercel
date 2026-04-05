
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetRoutesResponseVariant4RouteRouteMitigateAction
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
    public static class GetRoutesResponseVariant4RouteRouteMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRoutesResponseVariant4RouteRouteMitigateAction value)
        {
            return value switch
            {
                GetRoutesResponseVariant4RouteRouteMitigateAction.Challenge => "challenge",
                GetRoutesResponseVariant4RouteRouteMitigateAction.Deny => "deny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRoutesResponseVariant4RouteRouteMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetRoutesResponseVariant4RouteRouteMitigateAction.Challenge,
                "deny" => GetRoutesResponseVariant4RouteRouteMitigateAction.Deny,
                _ => null,
            };
        }
    }
}