
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedba7c6b12ca723bfbLastAliasRequestType
    {
        /// <summary>
        ///
        /// </summary>
        Promote,
        /// <summary>
        ///
        /// </summary>
        Rollback,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedba7c6b12ca723bfbLastAliasRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedba7c6b12ca723bfbLastAliasRequestType value)
        {
            return value switch
            {
                AutoSDKSharedba7c6b12ca723bfbLastAliasRequestType.Promote => "promote",
                AutoSDKSharedba7c6b12ca723bfbLastAliasRequestType.Rollback => "rollback",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedba7c6b12ca723bfbLastAliasRequestType? ToEnum(string value)
        {
            return value switch
            {
                "promote" => AutoSDKSharedba7c6b12ca723bfbLastAliasRequestType.Promote,
                "rollback" => AutoSDKSharedba7c6b12ca723bfbLastAliasRequestType.Rollback,
                _ => null,
            };
        }
    }
}