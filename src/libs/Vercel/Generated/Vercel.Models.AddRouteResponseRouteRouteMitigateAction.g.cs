
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum AddRouteResponseRouteRouteMitigateAction
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
    public static class AddRouteResponseRouteRouteMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddRouteResponseRouteRouteMitigateAction value)
        {
            return value switch
            {
                AddRouteResponseRouteRouteMitigateAction.Challenge => "challenge",
                AddRouteResponseRouteRouteMitigateAction.Deny => "deny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddRouteResponseRouteRouteMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AddRouteResponseRouteRouteMitigateAction.Challenge,
                "deny" => AddRouteResponseRouteRouteMitigateAction.Deny,
                _ => null,
            };
        }
    }
}