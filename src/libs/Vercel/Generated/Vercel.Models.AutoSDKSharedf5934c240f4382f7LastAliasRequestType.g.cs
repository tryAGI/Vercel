
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedf5934c240f4382f7LastAliasRequestType
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
    public static class AutoSDKSharedf5934c240f4382f7LastAliasRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedf5934c240f4382f7LastAliasRequestType value)
        {
            return value switch
            {
                AutoSDKSharedf5934c240f4382f7LastAliasRequestType.Promote => "promote",
                AutoSDKSharedf5934c240f4382f7LastAliasRequestType.Rollback => "rollback",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedf5934c240f4382f7LastAliasRequestType? ToEnum(string value)
        {
            return value switch
            {
                "promote" => AutoSDKSharedf5934c240f4382f7LastAliasRequestType.Promote,
                "rollback" => AutoSDKSharedf5934c240f4382f7LastAliasRequestType.Rollback,
                _ => null,
            };
        }
    }
}