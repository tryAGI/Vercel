
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedb4706d78b2b82e72LivenessProbeHttpGetScheme
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
    public static class AutoSDKSharedb4706d78b2b82e72LivenessProbeHttpGetSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedb4706d78b2b82e72LivenessProbeHttpGetScheme value)
        {
            return value switch
            {
                AutoSDKSharedb4706d78b2b82e72LivenessProbeHttpGetScheme.Http => "HTTP",
                AutoSDKSharedb4706d78b2b82e72LivenessProbeHttpGetScheme.Https => "HTTPS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedb4706d78b2b82e72LivenessProbeHttpGetScheme? ToEnum(string value)
        {
            return value switch
            {
                "HTTP" => AutoSDKSharedb4706d78b2b82e72LivenessProbeHttpGetScheme.Http,
                "HTTPS" => AutoSDKSharedb4706d78b2b82e72LivenessProbeHttpGetScheme.Https,
                _ => null,
            };
        }
    }
}