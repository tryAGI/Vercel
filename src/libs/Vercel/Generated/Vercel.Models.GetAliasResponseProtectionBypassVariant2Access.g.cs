
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAliasResponseProtectionBypassVariant2Access
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
    public static class GetAliasResponseProtectionBypassVariant2AccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAliasResponseProtectionBypassVariant2Access value)
        {
            return value switch
            {
                GetAliasResponseProtectionBypassVariant2Access.Granted => "granted",
                GetAliasResponseProtectionBypassVariant2Access.Requested => "requested",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAliasResponseProtectionBypassVariant2Access? ToEnum(string value)
        {
            return value switch
            {
                "granted" => GetAliasResponseProtectionBypassVariant2Access.Granted,
                "requested" => GetAliasResponseProtectionBypassVariant2Access.Requested,
                _ => null,
            };
        }
    }
}