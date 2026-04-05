
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of environment (production, preview, or development)
    /// </summary>
    public enum CancelDeploymentResponseCustomEnvironmentVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Development,
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
    public static class CancelDeploymentResponseCustomEnvironmentVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseCustomEnvironmentVariant1Type value)
        {
            return value switch
            {
                CancelDeploymentResponseCustomEnvironmentVariant1Type.Development => "development",
                CancelDeploymentResponseCustomEnvironmentVariant1Type.Preview => "preview",
                CancelDeploymentResponseCustomEnvironmentVariant1Type.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseCustomEnvironmentVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "development" => CancelDeploymentResponseCustomEnvironmentVariant1Type.Development,
                "preview" => CancelDeploymentResponseCustomEnvironmentVariant1Type.Preview,
                "production" => CancelDeploymentResponseCustomEnvironmentVariant1Type.Production,
                _ => null,
            };
        }
    }
}