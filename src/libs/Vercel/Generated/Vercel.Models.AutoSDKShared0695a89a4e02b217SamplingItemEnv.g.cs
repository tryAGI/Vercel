
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0695a89a4e02b217SamplingItemEnv
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
    public static class AutoSDKShared0695a89a4e02b217SamplingItemEnvExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0695a89a4e02b217SamplingItemEnv value)
        {
            return value switch
            {
                AutoSDKShared0695a89a4e02b217SamplingItemEnv.Preview => "preview",
                AutoSDKShared0695a89a4e02b217SamplingItemEnv.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0695a89a4e02b217SamplingItemEnv? ToEnum(string value)
        {
            return value switch
            {
                "preview" => AutoSDKShared0695a89a4e02b217SamplingItemEnv.Preview,
                "production" => AutoSDKShared0695a89a4e02b217SamplingItemEnv.Production,
                _ => null,
            };
        }
    }
}