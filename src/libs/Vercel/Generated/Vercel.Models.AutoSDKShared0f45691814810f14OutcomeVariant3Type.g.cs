
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0f45691814810f14OutcomeVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        Rollout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared0f45691814810f14OutcomeVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0f45691814810f14OutcomeVariant3Type value)
        {
            return value switch
            {
                AutoSDKShared0f45691814810f14OutcomeVariant3Type.Rollout => "rollout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0f45691814810f14OutcomeVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "rollout" => AutoSDKShared0f45691814810f14OutcomeVariant3Type.Rollout,
                _ => null,
            };
        }
    }
}