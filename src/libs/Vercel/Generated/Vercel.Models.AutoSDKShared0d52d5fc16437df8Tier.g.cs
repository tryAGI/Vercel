
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0d52d5fc16437df8Tier
    {
        /// <summary>
        ///
        /// </summary>
        Priority,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared0d52d5fc16437df8TierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0d52d5fc16437df8Tier value)
        {
            return value switch
            {
                AutoSDKShared0d52d5fc16437df8Tier.Priority => "priority",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0d52d5fc16437df8Tier? ToEnum(string value)
        {
            return value switch
            {
                "priority" => AutoSDKShared0d52d5fc16437df8Tier.Priority,
                _ => null,
            };
        }
    }
}