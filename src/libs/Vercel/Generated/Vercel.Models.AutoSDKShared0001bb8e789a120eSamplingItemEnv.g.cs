
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0001bb8e789a120eSamplingItemEnv
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
    public static class AutoSDKShared0001bb8e789a120eSamplingItemEnvExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0001bb8e789a120eSamplingItemEnv value)
        {
            return value switch
            {
                AutoSDKShared0001bb8e789a120eSamplingItemEnv.Preview => "preview",
                AutoSDKShared0001bb8e789a120eSamplingItemEnv.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0001bb8e789a120eSamplingItemEnv? ToEnum(string value)
        {
            return value switch
            {
                "preview" => AutoSDKShared0001bb8e789a120eSamplingItemEnv.Preview,
                "production" => AutoSDKShared0001bb8e789a120eSamplingItemEnv.Production,
                _ => null,
            };
        }
    }
}