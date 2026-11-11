
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc1c2f92d02e0feb6ProtectionBypassVariant2Scope
    {
        /// <summary>
        ///
        /// </summary>
        AutomationBypass,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedc1c2f92d02e0feb6ProtectionBypassVariant2ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc1c2f92d02e0feb6ProtectionBypassVariant2Scope value)
        {
            return value switch
            {
                AutoSDKSharedc1c2f92d02e0feb6ProtectionBypassVariant2Scope.AutomationBypass => "automation-bypass",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc1c2f92d02e0feb6ProtectionBypassVariant2Scope? ToEnum(string value)
        {
            return value switch
            {
                "automation-bypass" => AutoSDKSharedc1c2f92d02e0feb6ProtectionBypassVariant2Scope.AutomationBypass,
                _ => null,
            };
        }
    }
}