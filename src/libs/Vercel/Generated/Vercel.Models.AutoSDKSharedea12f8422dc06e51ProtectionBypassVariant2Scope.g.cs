
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedea12f8422dc06e51ProtectionBypassVariant2Scope
    {
        /// <summary>
        ///
        /// </summary>
        AutomationBypass,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedea12f8422dc06e51ProtectionBypassVariant2ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedea12f8422dc06e51ProtectionBypassVariant2Scope value)
        {
            return value switch
            {
                AutoSDKSharedea12f8422dc06e51ProtectionBypassVariant2Scope.AutomationBypass => "automation-bypass",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedea12f8422dc06e51ProtectionBypassVariant2Scope? ToEnum(string value)
        {
            return value switch
            {
                "automation-bypass" => AutoSDKSharedea12f8422dc06e51ProtectionBypassVariant2Scope.AutomationBypass,
                _ => null,
            };
        }
    }
}