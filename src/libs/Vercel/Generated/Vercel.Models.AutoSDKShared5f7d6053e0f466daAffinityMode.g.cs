
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared5f7d6053e0f466daAffinityMode
    {
        /// <summary>
        ///
        /// </summary>
        Strict,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared5f7d6053e0f466daAffinityModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared5f7d6053e0f466daAffinityMode value)
        {
            return value switch
            {
                AutoSDKShared5f7d6053e0f466daAffinityMode.Strict => "strict",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared5f7d6053e0f466daAffinityMode? ToEnum(string value)
        {
            return value switch
            {
                "strict" => AutoSDKShared5f7d6053e0f466daAffinityMode.Strict,
                _ => null,
            };
        }
    }
}