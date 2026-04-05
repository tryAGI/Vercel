
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListAliasesResponseAliaseProtectionBypassVariant1Scope
    {
        /// <summary>
        /// 
        /// </summary>
        ShareableLink,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListAliasesResponseAliaseProtectionBypassVariant1ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAliasesResponseAliaseProtectionBypassVariant1Scope value)
        {
            return value switch
            {
                ListAliasesResponseAliaseProtectionBypassVariant1Scope.ShareableLink => "shareable-link",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAliasesResponseAliaseProtectionBypassVariant1Scope? ToEnum(string value)
        {
            return value switch
            {
                "shareable-link" => ListAliasesResponseAliaseProtectionBypassVariant1Scope.ShareableLink,
                _ => null,
            };
        }
    }
}