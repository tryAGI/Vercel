
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListAliasesResponseAliaseProtectionBypassVariant4Scope
    {
        /// <summary>
        /// 
        /// </summary>
        EmailInvite,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListAliasesResponseAliaseProtectionBypassVariant4ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAliasesResponseAliaseProtectionBypassVariant4Scope value)
        {
            return value switch
            {
                ListAliasesResponseAliaseProtectionBypassVariant4Scope.EmailInvite => "email_invite",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAliasesResponseAliaseProtectionBypassVariant4Scope? ToEnum(string value)
        {
            return value switch
            {
                "email_invite" => ListAliasesResponseAliaseProtectionBypassVariant4Scope.EmailInvite,
                _ => null,
            };
        }
    }
}