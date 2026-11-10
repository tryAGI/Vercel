
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8df5bff0bb4332b8SamplingItemEnv
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
    public static class AutoSDKShared8df5bff0bb4332b8SamplingItemEnvExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8df5bff0bb4332b8SamplingItemEnv value)
        {
            return value switch
            {
                AutoSDKShared8df5bff0bb4332b8SamplingItemEnv.Preview => "preview",
                AutoSDKShared8df5bff0bb4332b8SamplingItemEnv.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8df5bff0bb4332b8SamplingItemEnv? ToEnum(string value)
        {
            return value switch
            {
                "preview" => AutoSDKShared8df5bff0bb4332b8SamplingItemEnv.Preview,
                "production" => AutoSDKShared8df5bff0bb4332b8SamplingItemEnv.Production,
                _ => null,
            };
        }
    }
}