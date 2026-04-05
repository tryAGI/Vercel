
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListAliasesResponseAliaseProtectionBypassVariant2Scope
    {
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListAliasesResponseAliaseProtectionBypassVariant2ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAliasesResponseAliaseProtectionBypassVariant2Scope value)
        {
            return value switch
            {
                ListAliasesResponseAliaseProtectionBypassVariant2Scope.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAliasesResponseAliaseProtectionBypassVariant2Scope? ToEnum(string value)
        {
            return value switch
            {
                "user" => ListAliasesResponseAliaseProtectionBypassVariant2Scope.User,
                _ => null,
            };
        }
    }
}