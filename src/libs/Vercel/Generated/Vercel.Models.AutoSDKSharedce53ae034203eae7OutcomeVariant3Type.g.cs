
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedce53ae034203eae7OutcomeVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        Rollout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedce53ae034203eae7OutcomeVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedce53ae034203eae7OutcomeVariant3Type value)
        {
            return value switch
            {
                AutoSDKSharedce53ae034203eae7OutcomeVariant3Type.Rollout => "rollout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedce53ae034203eae7OutcomeVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "rollout" => AutoSDKSharedce53ae034203eae7OutcomeVariant3Type.Rollout,
                _ => null,
            };
        }
    }
}