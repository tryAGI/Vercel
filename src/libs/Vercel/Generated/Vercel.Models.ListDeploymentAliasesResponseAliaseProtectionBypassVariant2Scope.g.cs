
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListDeploymentAliasesResponseAliaseProtectionBypassVariant2Scope
    {
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListDeploymentAliasesResponseAliaseProtectionBypassVariant2ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDeploymentAliasesResponseAliaseProtectionBypassVariant2Scope value)
        {
            return value switch
            {
                ListDeploymentAliasesResponseAliaseProtectionBypassVariant2Scope.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDeploymentAliasesResponseAliaseProtectionBypassVariant2Scope? ToEnum(string value)
        {
            return value switch
            {
                "user" => ListDeploymentAliasesResponseAliaseProtectionBypassVariant2Scope.User,
                _ => null,
            };
        }
    }
}