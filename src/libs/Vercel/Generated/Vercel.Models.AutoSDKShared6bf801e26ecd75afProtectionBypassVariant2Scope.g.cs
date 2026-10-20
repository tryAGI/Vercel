
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6bf801e26ecd75afProtectionBypassVariant2Scope
    {
        /// <summary>
        ///
        /// </summary>
        AutomationBypass,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared6bf801e26ecd75afProtectionBypassVariant2ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6bf801e26ecd75afProtectionBypassVariant2Scope value)
        {
            return value switch
            {
                AutoSDKShared6bf801e26ecd75afProtectionBypassVariant2Scope.AutomationBypass => "automation-bypass",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6bf801e26ecd75afProtectionBypassVariant2Scope? ToEnum(string value)
        {
            return value switch
            {
                "automation-bypass" => AutoSDKShared6bf801e26ecd75afProtectionBypassVariant2Scope.AutomationBypass,
                _ => null,
            };
        }
    }
}