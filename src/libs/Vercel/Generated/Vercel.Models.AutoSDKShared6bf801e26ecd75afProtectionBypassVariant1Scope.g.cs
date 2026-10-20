
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6bf801e26ecd75afProtectionBypassVariant1Scope
    {
        /// <summary>
        ///
        /// </summary>
        IntegrationAutomationBypass,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared6bf801e26ecd75afProtectionBypassVariant1ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6bf801e26ecd75afProtectionBypassVariant1Scope value)
        {
            return value switch
            {
                AutoSDKShared6bf801e26ecd75afProtectionBypassVariant1Scope.IntegrationAutomationBypass => "integration-automation-bypass",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6bf801e26ecd75afProtectionBypassVariant1Scope? ToEnum(string value)
        {
            return value switch
            {
                "integration-automation-bypass" => AutoSDKShared6bf801e26ecd75afProtectionBypassVariant1Scope.IntegrationAutomationBypass,
                _ => null,
            };
        }
    }
}