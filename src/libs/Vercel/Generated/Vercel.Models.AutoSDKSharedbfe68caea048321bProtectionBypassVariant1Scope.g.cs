
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedbfe68caea048321bProtectionBypassVariant1Scope
    {
        /// <summary>
        ///
        /// </summary>
        IntegrationAutomationBypass,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedbfe68caea048321bProtectionBypassVariant1ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbfe68caea048321bProtectionBypassVariant1Scope value)
        {
            return value switch
            {
                AutoSDKSharedbfe68caea048321bProtectionBypassVariant1Scope.IntegrationAutomationBypass => "integration-automation-bypass",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbfe68caea048321bProtectionBypassVariant1Scope? ToEnum(string value)
        {
            return value switch
            {
                "integration-automation-bypass" => AutoSDKSharedbfe68caea048321bProtectionBypassVariant1Scope.IntegrationAutomationBypass,
                _ => null,
            };
        }
    }
}