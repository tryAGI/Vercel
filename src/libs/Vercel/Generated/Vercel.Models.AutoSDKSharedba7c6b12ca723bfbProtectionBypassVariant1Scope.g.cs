
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedba7c6b12ca723bfbProtectionBypassVariant1Scope
    {
        /// <summary>
        ///
        /// </summary>
        IntegrationAutomationBypass,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedba7c6b12ca723bfbProtectionBypassVariant1ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedba7c6b12ca723bfbProtectionBypassVariant1Scope value)
        {
            return value switch
            {
                AutoSDKSharedba7c6b12ca723bfbProtectionBypassVariant1Scope.IntegrationAutomationBypass => "integration-automation-bypass",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedba7c6b12ca723bfbProtectionBypassVariant1Scope? ToEnum(string value)
        {
            return value switch
            {
                "integration-automation-bypass" => AutoSDKSharedba7c6b12ca723bfbProtectionBypassVariant1Scope.IntegrationAutomationBypass,
                _ => null,
            };
        }
    }
}