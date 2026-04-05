
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseProtectionBypassVariant1Scope
    {
        /// <summary>
        /// 
        /// </summary>
        IntegrationAutomationBypass,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateMicrofrontendsResponseProtectionBypassVariant1ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseProtectionBypassVariant1Scope value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseProtectionBypassVariant1Scope.IntegrationAutomationBypass => "integration-automation-bypass",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseProtectionBypassVariant1Scope? ToEnum(string value)
        {
            return value switch
            {
                "integration-automation-bypass" => UpdateMicrofrontendsResponseProtectionBypassVariant1Scope.IntegrationAutomationBypass,
                _ => null,
            };
        }
    }
}