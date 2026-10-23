
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda8d456fca5d8a771Tier
    {
        /// <summary>
        ///
        /// </summary>
        Priority,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShareda8d456fca5d8a771TierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda8d456fca5d8a771Tier value)
        {
            return value switch
            {
                AutoSDKShareda8d456fca5d8a771Tier.Priority => "priority",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda8d456fca5d8a771Tier? ToEnum(string value)
        {
            return value switch
            {
                "priority" => AutoSDKShareda8d456fca5d8a771Tier.Priority,
                _ => null,
            };
        }
    }
}