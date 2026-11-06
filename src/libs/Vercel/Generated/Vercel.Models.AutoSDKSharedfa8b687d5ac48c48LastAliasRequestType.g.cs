
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfa8b687d5ac48c48LastAliasRequestType
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
    public static class AutoSDKSharedfa8b687d5ac48c48LastAliasRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfa8b687d5ac48c48LastAliasRequestType value)
        {
            return value switch
            {
                AutoSDKSharedfa8b687d5ac48c48LastAliasRequestType.Promote => "promote",
                AutoSDKSharedfa8b687d5ac48c48LastAliasRequestType.Rollback => "rollback",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfa8b687d5ac48c48LastAliasRequestType? ToEnum(string value)
        {
            return value switch
            {
                "promote" => AutoSDKSharedfa8b687d5ac48c48LastAliasRequestType.Promote,
                "rollback" => AutoSDKSharedfa8b687d5ac48c48LastAliasRequestType.Rollback,
                _ => null,
            };
        }
    }
}