
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared92580a598ccc210fSamplingItemEnv
    {
        /// <summary>
        ///
        /// </summary>
        Preview,
        /// <summary>
        ///
        /// </summary>
        Production,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared92580a598ccc210fSamplingItemEnvExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared92580a598ccc210fSamplingItemEnv value)
        {
            return value switch
            {
                AutoSDKShared92580a598ccc210fSamplingItemEnv.Preview => "preview",
                AutoSDKShared92580a598ccc210fSamplingItemEnv.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared92580a598ccc210fSamplingItemEnv? ToEnum(string value)
        {
            return value switch
            {
                "preview" => AutoSDKShared92580a598ccc210fSamplingItemEnv.Preview,
                "production" => AutoSDKShared92580a598ccc210fSamplingItemEnv.Production,
                _ => null,
            };
        }
    }
}