
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListDeploymentAliasesResponseAliaseProtectionBypassVariant4Scope
    {
        /// <summary>
        /// 
        /// </summary>
        EmailInvite,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListDeploymentAliasesResponseAliaseProtectionBypassVariant4ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDeploymentAliasesResponseAliaseProtectionBypassVariant4Scope value)
        {
            return value switch
            {
                ListDeploymentAliasesResponseAliaseProtectionBypassVariant4Scope.EmailInvite => "email_invite",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDeploymentAliasesResponseAliaseProtectionBypassVariant4Scope? ToEnum(string value)
        {
            return value switch
            {
                "email_invite" => ListDeploymentAliasesResponseAliaseProtectionBypassVariant4Scope.EmailInvite,
                _ => null,
            };
        }
    }
}