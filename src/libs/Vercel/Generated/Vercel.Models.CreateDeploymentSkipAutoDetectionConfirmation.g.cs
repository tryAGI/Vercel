
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Set to `1` to skip framework auto-detection and proceed without confirmation. By default, if Vercel detects a framework that differs from the project setting, the API returns a `400` asking you to confirm. Use this to suppress that check in automated pipelines.<br/>
    /// Example: 1
    /// </summary>
    public enum CreateDeploymentSkipAutoDetectionConfirmation
    {
        /// <summary>
        ///
        /// </summary>
        x0,
        /// <summary>
        ///
        /// </summary>
        x1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentSkipAutoDetectionConfirmationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentSkipAutoDetectionConfirmation value)
        {
            return value switch
            {
                CreateDeploymentSkipAutoDetectionConfirmation.x0 => "0",
                CreateDeploymentSkipAutoDetectionConfirmation.x1 => "1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentSkipAutoDetectionConfirmation? ToEnum(string value)
        {
            return value switch
            {
                "0" => CreateDeploymentSkipAutoDetectionConfirmation.x0,
                "1" => CreateDeploymentSkipAutoDetectionConfirmation.x1,
                _ => null,
            };
        }
    }
}