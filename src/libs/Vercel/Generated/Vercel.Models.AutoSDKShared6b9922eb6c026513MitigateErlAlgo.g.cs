
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6b9922eb6c026513MitigateErlAlgo
    {
        /// <summary>
        ///
        /// </summary>
        FixedWindow,
        /// <summary>
        ///
        /// </summary>
        TokenBucket,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared6b9922eb6c026513MitigateErlAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6b9922eb6c026513MitigateErlAlgo value)
        {
            return value switch
            {
                AutoSDKShared6b9922eb6c026513MitigateErlAlgo.FixedWindow => "fixed_window",
                AutoSDKShared6b9922eb6c026513MitigateErlAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6b9922eb6c026513MitigateErlAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => AutoSDKShared6b9922eb6c026513MitigateErlAlgo.FixedWindow,
                "token_bucket" => AutoSDKShared6b9922eb6c026513MitigateErlAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}