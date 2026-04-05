
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of environment (production, preview, or development)
    /// </summary>
    public enum GetDeploymentResponseVariant1CustomEnvironmentVariant1Type
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
    public static class GetDeploymentResponseVariant1CustomEnvironmentVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1CustomEnvironmentVariant1Type value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1CustomEnvironmentVariant1Type.Development => "development",
                GetDeploymentResponseVariant1CustomEnvironmentVariant1Type.Preview => "preview",
                GetDeploymentResponseVariant1CustomEnvironmentVariant1Type.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1CustomEnvironmentVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "development" => GetDeploymentResponseVariant1CustomEnvironmentVariant1Type.Development,
                "preview" => GetDeploymentResponseVariant1CustomEnvironmentVariant1Type.Preview,
                "production" => GetDeploymentResponseVariant1CustomEnvironmentVariant1Type.Production,
                _ => null,
            };
        }
    }
}