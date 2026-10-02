
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfe1f84289679c6c4Tier
    {
        /// <summary>
        ///
        /// </summary>
        Priority,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedfe1f84289679c6c4TierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfe1f84289679c6c4Tier value)
        {
            return value switch
            {
                AutoSDKSharedfe1f84289679c6c4Tier.Priority => "priority",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfe1f84289679c6c4Tier? ToEnum(string value)
        {
            return value switch
            {
                "priority" => AutoSDKSharedfe1f84289679c6c4Tier.Priority,
                _ => null,
            };
        }
    }
}