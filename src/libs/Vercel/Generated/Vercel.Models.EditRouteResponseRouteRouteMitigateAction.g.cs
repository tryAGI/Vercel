
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditRouteResponseRouteRouteMitigateAction
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
    public static class EditRouteResponseRouteRouteMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditRouteResponseRouteRouteMitigateAction value)
        {
            return value switch
            {
                EditRouteResponseRouteRouteMitigateAction.Challenge => "challenge",
                EditRouteResponseRouteRouteMitigateAction.Deny => "deny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditRouteResponseRouteRouteMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => EditRouteResponseRouteRouteMitigateAction.Challenge,
                "deny" => EditRouteResponseRouteRouteMitigateAction.Deny,
                _ => null,
            };
        }
    }
}