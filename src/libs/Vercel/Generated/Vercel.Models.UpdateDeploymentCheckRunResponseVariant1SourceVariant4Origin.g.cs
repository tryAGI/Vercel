
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateDeploymentCheckRunResponseVariant1SourceVariant4Origin
    {
        /// <summary>
        ///
        /// </summary>
        Api,
        /// <summary>
        ///
        /// </summary>
        Platform,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateDeploymentCheckRunResponseVariant1SourceVariant4OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDeploymentCheckRunResponseVariant1SourceVariant4Origin value)
        {
            return value switch
            {
                UpdateDeploymentCheckRunResponseVariant1SourceVariant4Origin.Api => "api",
                UpdateDeploymentCheckRunResponseVariant1SourceVariant4Origin.Platform => "platform",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDeploymentCheckRunResponseVariant1SourceVariant4Origin? ToEnum(string value)
        {
            return value switch
            {
                "api" => UpdateDeploymentCheckRunResponseVariant1SourceVariant4Origin.Api,
                "platform" => UpdateDeploymentCheckRunResponseVariant1SourceVariant4Origin.Platform,
                _ => null,
            };
        }
    }
}