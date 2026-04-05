
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAliasResponseProtectionBypassVariant1Scope
    {
        /// <summary>
        /// 
        /// </summary>
        ShareableLink,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAliasResponseProtectionBypassVariant1ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAliasResponseProtectionBypassVariant1Scope value)
        {
            return value switch
            {
                GetAliasResponseProtectionBypassVariant1Scope.ShareableLink => "shareable-link",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAliasResponseProtectionBypassVariant1Scope? ToEnum(string value)
        {
            return value switch
            {
                "shareable-link" => GetAliasResponseProtectionBypassVariant1Scope.ShareableLink,
                _ => null,
            };
        }
    }
}