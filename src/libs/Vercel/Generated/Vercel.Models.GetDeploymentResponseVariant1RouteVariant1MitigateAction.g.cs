
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant1RouteVariant1MitigateAction
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
    public static class GetDeploymentResponseVariant1RouteVariant1MitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1RouteVariant1MitigateAction value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1RouteVariant1MitigateAction.Challenge => "challenge",
                GetDeploymentResponseVariant1RouteVariant1MitigateAction.Deny => "deny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1RouteVariant1MitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetDeploymentResponseVariant1RouteVariant1MitigateAction.Challenge,
                "deny" => GetDeploymentResponseVariant1RouteVariant1MitigateAction.Deny,
                _ => null,
            };
        }
    }
}