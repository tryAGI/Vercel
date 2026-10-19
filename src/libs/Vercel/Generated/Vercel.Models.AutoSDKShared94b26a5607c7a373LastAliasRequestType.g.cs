
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared94b26a5607c7a373LastAliasRequestType
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
    public static class AutoSDKShared94b26a5607c7a373LastAliasRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared94b26a5607c7a373LastAliasRequestType value)
        {
            return value switch
            {
                AutoSDKShared94b26a5607c7a373LastAliasRequestType.Promote => "promote",
                AutoSDKShared94b26a5607c7a373LastAliasRequestType.Rollback => "rollback",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared94b26a5607c7a373LastAliasRequestType? ToEnum(string value)
        {
            return value switch
            {
                "promote" => AutoSDKShared94b26a5607c7a373LastAliasRequestType.Promote,
                "rollback" => AutoSDKShared94b26a5607c7a373LastAliasRequestType.Rollback,
                _ => null,
            };
        }
    }
}