
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9bbe6cc4d61f3bf2LastAliasRequestType
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
    public static class AutoSDKShared9bbe6cc4d61f3bf2LastAliasRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9bbe6cc4d61f3bf2LastAliasRequestType value)
        {
            return value switch
            {
                AutoSDKShared9bbe6cc4d61f3bf2LastAliasRequestType.Promote => "promote",
                AutoSDKShared9bbe6cc4d61f3bf2LastAliasRequestType.Rollback => "rollback",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9bbe6cc4d61f3bf2LastAliasRequestType? ToEnum(string value)
        {
            return value switch
            {
                "promote" => AutoSDKShared9bbe6cc4d61f3bf2LastAliasRequestType.Promote,
                "rollback" => AutoSDKShared9bbe6cc4d61f3bf2LastAliasRequestType.Rollback,
                _ => null,
            };
        }
    }
}