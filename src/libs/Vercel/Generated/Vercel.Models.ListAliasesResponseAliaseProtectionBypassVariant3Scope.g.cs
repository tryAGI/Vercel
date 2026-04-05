
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListAliasesResponseAliaseProtectionBypassVariant3Scope
    {
        /// <summary>
        /// 
        /// </summary>
        AliasProtectionOverride,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListAliasesResponseAliaseProtectionBypassVariant3ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAliasesResponseAliaseProtectionBypassVariant3Scope value)
        {
            return value switch
            {
                ListAliasesResponseAliaseProtectionBypassVariant3Scope.AliasProtectionOverride => "alias-protection-override",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAliasesResponseAliaseProtectionBypassVariant3Scope? ToEnum(string value)
        {
            return value switch
            {
                "alias-protection-override" => ListAliasesResponseAliaseProtectionBypassVariant3Scope.AliasProtectionOverride,
                _ => null,
            };
        }
    }
}