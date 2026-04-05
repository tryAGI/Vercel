
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseFunctionsArchitecture
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
    public static class CreateDeploymentResponseFunctionsArchitectureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseFunctionsArchitecture value)
        {
            return value switch
            {
                CreateDeploymentResponseFunctionsArchitecture.Arm64 => "arm64",
                CreateDeploymentResponseFunctionsArchitecture.X8664 => "x86_64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseFunctionsArchitecture? ToEnum(string value)
        {
            return value switch
            {
                "arm64" => CreateDeploymentResponseFunctionsArchitecture.Arm64,
                "x86_64" => CreateDeploymentResponseFunctionsArchitecture.X8664,
                _ => null,
            };
        }
    }
}