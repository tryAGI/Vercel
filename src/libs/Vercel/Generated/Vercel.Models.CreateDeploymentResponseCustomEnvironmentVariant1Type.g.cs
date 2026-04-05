
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of environment (production, preview, or development)
    /// </summary>
    public enum CreateDeploymentResponseCustomEnvironmentVariant1Type
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
    public static class CreateDeploymentResponseCustomEnvironmentVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseCustomEnvironmentVariant1Type value)
        {
            return value switch
            {
                CreateDeploymentResponseCustomEnvironmentVariant1Type.Development => "development",
                CreateDeploymentResponseCustomEnvironmentVariant1Type.Preview => "preview",
                CreateDeploymentResponseCustomEnvironmentVariant1Type.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseCustomEnvironmentVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "development" => CreateDeploymentResponseCustomEnvironmentVariant1Type.Development,
                "preview" => CreateDeploymentResponseCustomEnvironmentVariant1Type.Preview,
                "production" => CreateDeploymentResponseCustomEnvironmentVariant1Type.Production,
                _ => null,
            };
        }
    }
}