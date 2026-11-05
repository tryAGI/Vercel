
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedab64e9622c80dc17MitigateErlAlgo
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
    public static class AutoSDKSharedab64e9622c80dc17MitigateErlAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedab64e9622c80dc17MitigateErlAlgo value)
        {
            return value switch
            {
                AutoSDKSharedab64e9622c80dc17MitigateErlAlgo.FixedWindow => "fixed_window",
                AutoSDKSharedab64e9622c80dc17MitigateErlAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedab64e9622c80dc17MitigateErlAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => AutoSDKSharedab64e9622c80dc17MitigateErlAlgo.FixedWindow,
                "token_bucket" => AutoSDKSharedab64e9622c80dc17MitigateErlAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}