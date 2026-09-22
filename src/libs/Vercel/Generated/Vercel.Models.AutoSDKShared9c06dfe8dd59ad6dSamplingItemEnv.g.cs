
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9c06dfe8dd59ad6dSamplingItemEnv
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
    public static class AutoSDKShared9c06dfe8dd59ad6dSamplingItemEnvExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9c06dfe8dd59ad6dSamplingItemEnv value)
        {
            return value switch
            {
                AutoSDKShared9c06dfe8dd59ad6dSamplingItemEnv.Preview => "preview",
                AutoSDKShared9c06dfe8dd59ad6dSamplingItemEnv.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9c06dfe8dd59ad6dSamplingItemEnv? ToEnum(string value)
        {
            return value switch
            {
                "preview" => AutoSDKShared9c06dfe8dd59ad6dSamplingItemEnv.Preview,
                "production" => AutoSDKShared9c06dfe8dd59ad6dSamplingItemEnv.Production,
                _ => null,
            };
        }
    }
}