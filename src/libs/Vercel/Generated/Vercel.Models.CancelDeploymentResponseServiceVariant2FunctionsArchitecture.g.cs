
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseServiceVariant2FunctionsArchitecture
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
    public static class CancelDeploymentResponseServiceVariant2FunctionsArchitectureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseServiceVariant2FunctionsArchitecture value)
        {
            return value switch
            {
                CancelDeploymentResponseServiceVariant2FunctionsArchitecture.Arm64 => "arm64",
                CancelDeploymentResponseServiceVariant2FunctionsArchitecture.X8664 => "x86_64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseServiceVariant2FunctionsArchitecture? ToEnum(string value)
        {
            return value switch
            {
                "arm64" => CancelDeploymentResponseServiceVariant2FunctionsArchitecture.Arm64,
                "x86_64" => CancelDeploymentResponseServiceVariant2FunctionsArchitecture.X8664,
                _ => null,
            };
        }
    }
}