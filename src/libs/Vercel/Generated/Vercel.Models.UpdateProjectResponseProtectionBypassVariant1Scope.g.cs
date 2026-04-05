
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseProtectionBypassVariant1Scope
    {
        /// <summary>
        /// 
        /// </summary>
        IntegrationAutomationBypass,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectResponseProtectionBypassVariant1ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseProtectionBypassVariant1Scope value)
        {
            return value switch
            {
                UpdateProjectResponseProtectionBypassVariant1Scope.IntegrationAutomationBypass => "integration-automation-bypass",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseProtectionBypassVariant1Scope? ToEnum(string value)
        {
            return value switch
            {
                "integration-automation-bypass" => UpdateProjectResponseProtectionBypassVariant1Scope.IntegrationAutomationBypass,
                _ => null,
            };
        }
    }
}