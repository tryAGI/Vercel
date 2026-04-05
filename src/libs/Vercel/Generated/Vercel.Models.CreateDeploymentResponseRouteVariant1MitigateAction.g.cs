
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseRouteVariant1MitigateAction
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
    public static class CreateDeploymentResponseRouteVariant1MitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseRouteVariant1MitigateAction value)
        {
            return value switch
            {
                CreateDeploymentResponseRouteVariant1MitigateAction.Challenge => "challenge",
                CreateDeploymentResponseRouteVariant1MitigateAction.Deny => "deny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseRouteVariant1MitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => CreateDeploymentResponseRouteVariant1MitigateAction.Challenge,
                "deny" => CreateDeploymentResponseRouteVariant1MitigateAction.Deny,
                _ => null,
            };
        }
    }
}