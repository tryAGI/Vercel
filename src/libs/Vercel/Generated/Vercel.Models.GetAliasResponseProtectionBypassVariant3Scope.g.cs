
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAliasResponseProtectionBypassVariant3Scope
    {
        /// <summary>
        /// 
        /// </summary>
        AliasProtectionOverride,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAliasResponseProtectionBypassVariant3ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAliasResponseProtectionBypassVariant3Scope value)
        {
            return value switch
            {
                GetAliasResponseProtectionBypassVariant3Scope.AliasProtectionOverride => "alias-protection-override",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAliasResponseProtectionBypassVariant3Scope? ToEnum(string value)
        {
            return value switch
            {
                "alias-protection-override" => GetAliasResponseProtectionBypassVariant3Scope.AliasProtectionOverride,
                _ => null,
            };
        }
    }
}