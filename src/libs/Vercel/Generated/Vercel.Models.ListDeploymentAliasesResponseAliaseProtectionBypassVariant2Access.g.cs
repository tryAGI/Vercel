
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListDeploymentAliasesResponseAliaseProtectionBypassVariant2Access
    {
        /// <summary>
        /// 
        /// </summary>
        Granted,
        /// <summary>
        /// 
        /// </summary>
        Requested,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListDeploymentAliasesResponseAliaseProtectionBypassVariant2AccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDeploymentAliasesResponseAliaseProtectionBypassVariant2Access value)
        {
            return value switch
            {
                ListDeploymentAliasesResponseAliaseProtectionBypassVariant2Access.Granted => "granted",
                ListDeploymentAliasesResponseAliaseProtectionBypassVariant2Access.Requested => "requested",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDeploymentAliasesResponseAliaseProtectionBypassVariant2Access? ToEnum(string value)
        {
            return value switch
            {
                "granted" => ListDeploymentAliasesResponseAliaseProtectionBypassVariant2Access.Granted,
                "requested" => ListDeploymentAliasesResponseAliaseProtectionBypassVariant2Access.Requested,
                _ => null,
            };
        }
    }
}