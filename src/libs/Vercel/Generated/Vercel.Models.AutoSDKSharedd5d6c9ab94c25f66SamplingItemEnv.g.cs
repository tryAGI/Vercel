
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd5d6c9ab94c25f66SamplingItemEnv
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
    public static class AutoSDKSharedd5d6c9ab94c25f66SamplingItemEnvExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd5d6c9ab94c25f66SamplingItemEnv value)
        {
            return value switch
            {
                AutoSDKSharedd5d6c9ab94c25f66SamplingItemEnv.Preview => "preview",
                AutoSDKSharedd5d6c9ab94c25f66SamplingItemEnv.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd5d6c9ab94c25f66SamplingItemEnv? ToEnum(string value)
        {
            return value switch
            {
                "preview" => AutoSDKSharedd5d6c9ab94c25f66SamplingItemEnv.Preview,
                "production" => AutoSDKSharedd5d6c9ab94c25f66SamplingItemEnv.Production,
                _ => null,
            };
        }
    }
}