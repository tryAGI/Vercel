
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseRouteVariant1MitigateAction
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
    public static class CancelDeploymentResponseRouteVariant1MitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseRouteVariant1MitigateAction value)
        {
            return value switch
            {
                CancelDeploymentResponseRouteVariant1MitigateAction.Challenge => "challenge",
                CancelDeploymentResponseRouteVariant1MitigateAction.Deny => "deny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseRouteVariant1MitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => CancelDeploymentResponseRouteVariant1MitigateAction.Challenge,
                "deny" => CancelDeploymentResponseRouteVariant1MitigateAction.Deny,
                _ => null,
            };
        }
    }
}