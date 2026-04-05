
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectProtectionBypassResponseProtectionBypassVariant2Scope
    {
        /// <summary>
        /// 
        /// </summary>
        AutomationBypass,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectProtectionBypassResponseProtectionBypassVariant2ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectProtectionBypassResponseProtectionBypassVariant2Scope value)
        {
            return value switch
            {
                UpdateProjectProtectionBypassResponseProtectionBypassVariant2Scope.AutomationBypass => "automation-bypass",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectProtectionBypassResponseProtectionBypassVariant2Scope? ToEnum(string value)
        {
            return value switch
            {
                "automation-bypass" => UpdateProjectProtectionBypassResponseProtectionBypassVariant2Scope.AutomationBypass,
                _ => null,
            };
        }
    }
}