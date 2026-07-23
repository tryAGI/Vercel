
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseVariant2ServiceVariant2BuilderConfigFunctionsArchitecture
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
    public static class CreateDeploymentResponseVariant2ServiceVariant2BuilderConfigFunctionsArchitectureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2ServiceVariant2BuilderConfigFunctionsArchitecture value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2ServiceVariant2BuilderConfigFunctionsArchitecture.Arm64 => "arm64",
                CreateDeploymentResponseVariant2ServiceVariant2BuilderConfigFunctionsArchitecture.X8664 => "x86_64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2ServiceVariant2BuilderConfigFunctionsArchitecture? ToEnum(string value)
        {
            return value switch
            {
                "arm64" => CreateDeploymentResponseVariant2ServiceVariant2BuilderConfigFunctionsArchitecture.Arm64,
                "x86_64" => CreateDeploymentResponseVariant2ServiceVariant2BuilderConfigFunctionsArchitecture.X8664,
                _ => null,
            };
        }
    }
}