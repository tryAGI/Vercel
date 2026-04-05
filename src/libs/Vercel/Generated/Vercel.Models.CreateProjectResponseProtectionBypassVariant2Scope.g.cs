
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseProtectionBypassVariant2Scope
    {
        /// <summary>
        /// 
        /// </summary>
        AutomationBypass,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectResponseProtectionBypassVariant2ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseProtectionBypassVariant2Scope value)
        {
            return value switch
            {
                CreateProjectResponseProtectionBypassVariant2Scope.AutomationBypass => "automation-bypass",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseProtectionBypassVariant2Scope? ToEnum(string value)
        {
            return value switch
            {
                "automation-bypass" => CreateProjectResponseProtectionBypassVariant2Scope.AutomationBypass,
                _ => null,
            };
        }
    }
}