
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListAliasesResponseAliaseProtectionBypassVariant2Access
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
    public static class ListAliasesResponseAliaseProtectionBypassVariant2AccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAliasesResponseAliaseProtectionBypassVariant2Access value)
        {
            return value switch
            {
                ListAliasesResponseAliaseProtectionBypassVariant2Access.Granted => "granted",
                ListAliasesResponseAliaseProtectionBypassVariant2Access.Requested => "requested",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAliasesResponseAliaseProtectionBypassVariant2Access? ToEnum(string value)
        {
            return value switch
            {
                "granted" => ListAliasesResponseAliaseProtectionBypassVariant2Access.Granted,
                "requested" => ListAliasesResponseAliaseProtectionBypassVariant2Access.Requested,
                _ => null,
            };
        }
    }
}