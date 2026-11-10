
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared37c775f169729655LivenessProbeHttpGetScheme
    {
        /// <summary>
        ///
        /// </summary>
        Http,
        /// <summary>
        ///
        /// </summary>
        Https,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared37c775f169729655LivenessProbeHttpGetSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared37c775f169729655LivenessProbeHttpGetScheme value)
        {
            return value switch
            {
                AutoSDKShared37c775f169729655LivenessProbeHttpGetScheme.Http => "HTTP",
                AutoSDKShared37c775f169729655LivenessProbeHttpGetScheme.Https => "HTTPS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared37c775f169729655LivenessProbeHttpGetScheme? ToEnum(string value)
        {
            return value switch
            {
                "HTTP" => AutoSDKShared37c775f169729655LivenessProbeHttpGetScheme.Http,
                "HTTPS" => AutoSDKShared37c775f169729655LivenessProbeHttpGetScheme.Https,
                _ => null,
            };
        }
    }
}