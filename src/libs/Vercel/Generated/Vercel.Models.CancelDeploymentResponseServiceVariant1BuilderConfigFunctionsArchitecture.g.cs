
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CancelDeploymentResponseServiceVariant1BuilderConfigFunctionsArchitecture
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
    public static class CancelDeploymentResponseServiceVariant1BuilderConfigFunctionsArchitectureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseServiceVariant1BuilderConfigFunctionsArchitecture value)
        {
            return value switch
            {
                CancelDeploymentResponseServiceVariant1BuilderConfigFunctionsArchitecture.Arm64 => "arm64",
                CancelDeploymentResponseServiceVariant1BuilderConfigFunctionsArchitecture.X8664 => "x86_64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseServiceVariant1BuilderConfigFunctionsArchitecture? ToEnum(string value)
        {
            return value switch
            {
                "arm64" => CancelDeploymentResponseServiceVariant1BuilderConfigFunctionsArchitecture.Arm64,
                "x86_64" => CancelDeploymentResponseServiceVariant1BuilderConfigFunctionsArchitecture.X8664,
                _ => null,
            };
        }
    }
}