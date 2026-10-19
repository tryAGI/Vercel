
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectBoxesResponseDaemonConfigLivenessProbeHttpGetScheme
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
    public static class GetProjectBoxesResponseDaemonConfigLivenessProbeHttpGetSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectBoxesResponseDaemonConfigLivenessProbeHttpGetScheme value)
        {
            return value switch
            {
                GetProjectBoxesResponseDaemonConfigLivenessProbeHttpGetScheme.Http => "HTTP",
                GetProjectBoxesResponseDaemonConfigLivenessProbeHttpGetScheme.Https => "HTTPS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectBoxesResponseDaemonConfigLivenessProbeHttpGetScheme? ToEnum(string value)
        {
            return value switch
            {
                "HTTP" => GetProjectBoxesResponseDaemonConfigLivenessProbeHttpGetScheme.Http,
                "HTTPS" => GetProjectBoxesResponseDaemonConfigLivenessProbeHttpGetScheme.Https,
                _ => null,
            };
        }
    }
}