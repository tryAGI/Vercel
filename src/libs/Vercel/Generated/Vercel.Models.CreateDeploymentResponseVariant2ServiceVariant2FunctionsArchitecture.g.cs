
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseVariant2ServiceVariant2FunctionsArchitecture
    {
        /// <summary>
        /// 
        /// </summary>
        Arm64,
        /// <summary>
        /// 
        /// </summary>
        X8664,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseVariant2ServiceVariant2FunctionsArchitectureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2ServiceVariant2FunctionsArchitecture value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2ServiceVariant2FunctionsArchitecture.Arm64 => "arm64",
                CreateDeploymentResponseVariant2ServiceVariant2FunctionsArchitecture.X8664 => "x86_64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2ServiceVariant2FunctionsArchitecture? ToEnum(string value)
        {
            return value switch
            {
                "arm64" => CreateDeploymentResponseVariant2ServiceVariant2FunctionsArchitecture.Arm64,
                "x86_64" => CreateDeploymentResponseVariant2ServiceVariant2FunctionsArchitecture.X8664,
                _ => null,
            };
        }
    }
}