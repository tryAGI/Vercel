
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAliasResponseProtectionBypassVariant2Scope
    {
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAliasResponseProtectionBypassVariant2ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAliasResponseProtectionBypassVariant2Scope value)
        {
            return value switch
            {
                GetAliasResponseProtectionBypassVariant2Scope.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAliasResponseProtectionBypassVariant2Scope? ToEnum(string value)
        {
            return value switch
            {
                "user" => GetAliasResponseProtectionBypassVariant2Scope.User,
                _ => null,
            };
        }
    }
}