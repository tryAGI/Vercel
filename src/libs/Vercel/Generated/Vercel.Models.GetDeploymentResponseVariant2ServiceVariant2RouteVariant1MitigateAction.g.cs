
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant2ServiceVariant2RouteVariant1MitigateAction
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
    public static class GetDeploymentResponseVariant2ServiceVariant2RouteVariant1MitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2ServiceVariant2RouteVariant1MitigateAction value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2ServiceVariant2RouteVariant1MitigateAction.Challenge => "challenge",
                GetDeploymentResponseVariant2ServiceVariant2RouteVariant1MitigateAction.Deny => "deny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2ServiceVariant2RouteVariant1MitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetDeploymentResponseVariant2ServiceVariant2RouteVariant1MitigateAction.Challenge,
                "deny" => GetDeploymentResponseVariant2ServiceVariant2RouteVariant1MitigateAction.Deny,
                _ => null,
            };
        }
    }
}