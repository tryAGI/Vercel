
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6df91f8a45eab833SamplingItemEnv
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
    public static class AutoSDKShared6df91f8a45eab833SamplingItemEnvExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6df91f8a45eab833SamplingItemEnv value)
        {
            return value switch
            {
                AutoSDKShared6df91f8a45eab833SamplingItemEnv.Preview => "preview",
                AutoSDKShared6df91f8a45eab833SamplingItemEnv.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6df91f8a45eab833SamplingItemEnv? ToEnum(string value)
        {
            return value switch
            {
                "preview" => AutoSDKShared6df91f8a45eab833SamplingItemEnv.Preview,
                "production" => AutoSDKShared6df91f8a45eab833SamplingItemEnv.Production,
                _ => null,
            };
        }
    }
}