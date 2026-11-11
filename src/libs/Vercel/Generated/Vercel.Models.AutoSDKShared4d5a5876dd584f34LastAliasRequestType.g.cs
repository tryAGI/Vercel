
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared4d5a5876dd584f34LastAliasRequestType
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
    public static class AutoSDKShared4d5a5876dd584f34LastAliasRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared4d5a5876dd584f34LastAliasRequestType value)
        {
            return value switch
            {
                AutoSDKShared4d5a5876dd584f34LastAliasRequestType.Promote => "promote",
                AutoSDKShared4d5a5876dd584f34LastAliasRequestType.Rollback => "rollback",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared4d5a5876dd584f34LastAliasRequestType? ToEnum(string value)
        {
            return value switch
            {
                "promote" => AutoSDKShared4d5a5876dd584f34LastAliasRequestType.Promote,
                "rollback" => AutoSDKShared4d5a5876dd584f34LastAliasRequestType.Rollback,
                _ => null,
            };
        }
    }
}