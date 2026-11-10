
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda861c3cb40ec56dcSamplingItemEnv
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
    public static class AutoSDKShareda861c3cb40ec56dcSamplingItemEnvExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda861c3cb40ec56dcSamplingItemEnv value)
        {
            return value switch
            {
                AutoSDKShareda861c3cb40ec56dcSamplingItemEnv.Preview => "preview",
                AutoSDKShareda861c3cb40ec56dcSamplingItemEnv.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda861c3cb40ec56dcSamplingItemEnv? ToEnum(string value)
        {
            return value switch
            {
                "preview" => AutoSDKShareda861c3cb40ec56dcSamplingItemEnv.Preview,
                "production" => AutoSDKShareda861c3cb40ec56dcSamplingItemEnv.Production,
                _ => null,
            };
        }
    }
}