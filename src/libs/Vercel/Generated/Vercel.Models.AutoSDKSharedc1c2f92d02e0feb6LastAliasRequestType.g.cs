
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc1c2f92d02e0feb6LastAliasRequestType
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
    public static class AutoSDKSharedc1c2f92d02e0feb6LastAliasRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc1c2f92d02e0feb6LastAliasRequestType value)
        {
            return value switch
            {
                AutoSDKSharedc1c2f92d02e0feb6LastAliasRequestType.Promote => "promote",
                AutoSDKSharedc1c2f92d02e0feb6LastAliasRequestType.Rollback => "rollback",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc1c2f92d02e0feb6LastAliasRequestType? ToEnum(string value)
        {
            return value switch
            {
                "promote" => AutoSDKSharedc1c2f92d02e0feb6LastAliasRequestType.Promote,
                "rollback" => AutoSDKSharedc1c2f92d02e0feb6LastAliasRequestType.Rollback,
                _ => null,
            };
        }
    }
}