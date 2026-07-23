
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of environment (production, preview, or development)
    /// </summary>
    public enum CreateDeploymentResponseVariant2CustomEnvironmentVariant1Type
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
    public static class CreateDeploymentResponseVariant2CustomEnvironmentVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2CustomEnvironmentVariant1Type value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2CustomEnvironmentVariant1Type.Development => "development",
                CreateDeploymentResponseVariant2CustomEnvironmentVariant1Type.Preview => "preview",
                CreateDeploymentResponseVariant2CustomEnvironmentVariant1Type.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2CustomEnvironmentVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "development" => CreateDeploymentResponseVariant2CustomEnvironmentVariant1Type.Development,
                "preview" => CreateDeploymentResponseVariant2CustomEnvironmentVariant1Type.Preview,
                "production" => CreateDeploymentResponseVariant2CustomEnvironmentVariant1Type.Production,
                _ => null,
            };
        }
    }
}