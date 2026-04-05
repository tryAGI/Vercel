
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListDeploymentAliasesResponseAliaseProtectionBypassVariant1Scope
    {
        /// <summary>
        /// 
        /// </summary>
        ShareableLink,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListDeploymentAliasesResponseAliaseProtectionBypassVariant1ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDeploymentAliasesResponseAliaseProtectionBypassVariant1Scope value)
        {
            return value switch
            {
                ListDeploymentAliasesResponseAliaseProtectionBypassVariant1Scope.ShareableLink => "shareable-link",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDeploymentAliasesResponseAliaseProtectionBypassVariant1Scope? ToEnum(string value)
        {
            return value switch
            {
                "shareable-link" => ListDeploymentAliasesResponseAliaseProtectionBypassVariant1Scope.ShareableLink,
                _ => null,
            };
        }
    }
}