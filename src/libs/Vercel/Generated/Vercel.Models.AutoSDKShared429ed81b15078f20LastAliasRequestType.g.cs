
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared429ed81b15078f20LastAliasRequestType
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
    public static class AutoSDKShared429ed81b15078f20LastAliasRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared429ed81b15078f20LastAliasRequestType value)
        {
            return value switch
            {
                AutoSDKShared429ed81b15078f20LastAliasRequestType.Promote => "promote",
                AutoSDKShared429ed81b15078f20LastAliasRequestType.Rollback => "rollback",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared429ed81b15078f20LastAliasRequestType? ToEnum(string value)
        {
            return value switch
            {
                "promote" => AutoSDKShared429ed81b15078f20LastAliasRequestType.Promote,
                "rollback" => AutoSDKShared429ed81b15078f20LastAliasRequestType.Rollback,
                _ => null,
            };
        }
    }
}