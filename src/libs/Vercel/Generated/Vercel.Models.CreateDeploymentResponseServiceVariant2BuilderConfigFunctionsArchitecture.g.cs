
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseServiceVariant2BuilderConfigFunctionsArchitecture
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
    public static class CreateDeploymentResponseServiceVariant2BuilderConfigFunctionsArchitectureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseServiceVariant2BuilderConfigFunctionsArchitecture value)
        {
            return value switch
            {
                CreateDeploymentResponseServiceVariant2BuilderConfigFunctionsArchitecture.Arm64 => "arm64",
                CreateDeploymentResponseServiceVariant2BuilderConfigFunctionsArchitecture.X8664 => "x86_64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseServiceVariant2BuilderConfigFunctionsArchitecture? ToEnum(string value)
        {
            return value switch
            {
                "arm64" => CreateDeploymentResponseServiceVariant2BuilderConfigFunctionsArchitecture.Arm64,
                "x86_64" => CreateDeploymentResponseServiceVariant2BuilderConfigFunctionsArchitecture.X8664,
                _ => null,
            };
        }
    }
}