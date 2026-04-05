
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseFunctionsArchitecture
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
    public static class CancelDeploymentResponseFunctionsArchitectureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseFunctionsArchitecture value)
        {
            return value switch
            {
                CancelDeploymentResponseFunctionsArchitecture.Arm64 => "arm64",
                CancelDeploymentResponseFunctionsArchitecture.X8664 => "x86_64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseFunctionsArchitecture? ToEnum(string value)
        {
            return value switch
            {
                "arm64" => CancelDeploymentResponseFunctionsArchitecture.Arm64,
                "x86_64" => CancelDeploymentResponseFunctionsArchitecture.X8664,
                _ => null,
            };
        }
    }
}