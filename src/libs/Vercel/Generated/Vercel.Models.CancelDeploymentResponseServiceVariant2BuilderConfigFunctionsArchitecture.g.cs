
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseServiceVariant2BuilderConfigFunctionsArchitecture
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
    public static class CancelDeploymentResponseServiceVariant2BuilderConfigFunctionsArchitectureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseServiceVariant2BuilderConfigFunctionsArchitecture value)
        {
            return value switch
            {
                CancelDeploymentResponseServiceVariant2BuilderConfigFunctionsArchitecture.Arm64 => "arm64",
                CancelDeploymentResponseServiceVariant2BuilderConfigFunctionsArchitecture.X8664 => "x86_64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseServiceVariant2BuilderConfigFunctionsArchitecture? ToEnum(string value)
        {
            return value switch
            {
                "arm64" => CancelDeploymentResponseServiceVariant2BuilderConfigFunctionsArchitecture.Arm64,
                "x86_64" => CancelDeploymentResponseServiceVariant2BuilderConfigFunctionsArchitecture.X8664,
                _ => null,
            };
        }
    }
}