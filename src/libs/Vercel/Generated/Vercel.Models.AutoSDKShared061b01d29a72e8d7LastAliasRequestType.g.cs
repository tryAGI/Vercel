
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared061b01d29a72e8d7LastAliasRequestType
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
    public static class AutoSDKShared061b01d29a72e8d7LastAliasRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared061b01d29a72e8d7LastAliasRequestType value)
        {
            return value switch
            {
                AutoSDKShared061b01d29a72e8d7LastAliasRequestType.Promote => "promote",
                AutoSDKShared061b01d29a72e8d7LastAliasRequestType.Rollback => "rollback",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared061b01d29a72e8d7LastAliasRequestType? ToEnum(string value)
        {
            return value switch
            {
                "promote" => AutoSDKShared061b01d29a72e8d7LastAliasRequestType.Promote,
                "rollback" => AutoSDKShared061b01d29a72e8d7LastAliasRequestType.Rollback,
                _ => null,
            };
        }
    }
}