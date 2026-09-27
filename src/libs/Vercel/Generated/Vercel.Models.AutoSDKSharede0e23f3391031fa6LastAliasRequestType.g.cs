
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede0e23f3391031fa6LastAliasRequestType
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
    public static class AutoSDKSharede0e23f3391031fa6LastAliasRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede0e23f3391031fa6LastAliasRequestType value)
        {
            return value switch
            {
                AutoSDKSharede0e23f3391031fa6LastAliasRequestType.Promote => "promote",
                AutoSDKSharede0e23f3391031fa6LastAliasRequestType.Rollback => "rollback",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede0e23f3391031fa6LastAliasRequestType? ToEnum(string value)
        {
            return value switch
            {
                "promote" => AutoSDKSharede0e23f3391031fa6LastAliasRequestType.Promote,
                "rollback" => AutoSDKSharede0e23f3391031fa6LastAliasRequestType.Rollback,
                _ => null,
            };
        }
    }
}