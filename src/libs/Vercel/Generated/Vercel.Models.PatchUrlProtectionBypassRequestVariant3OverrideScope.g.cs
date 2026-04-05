
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchUrlProtectionBypassRequestVariant3OverrideScope
    {
        /// <summary>
        /// 
        /// </summary>
        AliasProtectionOverride,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchUrlProtectionBypassRequestVariant3OverrideScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchUrlProtectionBypassRequestVariant3OverrideScope value)
        {
            return value switch
            {
                PatchUrlProtectionBypassRequestVariant3OverrideScope.AliasProtectionOverride => "alias-protection-override",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchUrlProtectionBypassRequestVariant3OverrideScope? ToEnum(string value)
        {
            return value switch
            {
                "alias-protection-override" => PatchUrlProtectionBypassRequestVariant3OverrideScope.AliasProtectionOverride,
                _ => null,
            };
        }
    }
}