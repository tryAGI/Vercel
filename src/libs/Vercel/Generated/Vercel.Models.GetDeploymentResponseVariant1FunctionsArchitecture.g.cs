
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant1FunctionsArchitecture
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
    public static class GetDeploymentResponseVariant1FunctionsArchitectureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1FunctionsArchitecture value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1FunctionsArchitecture.Arm64 => "arm64",
                GetDeploymentResponseVariant1FunctionsArchitecture.X8664 => "x86_64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1FunctionsArchitecture? ToEnum(string value)
        {
            return value switch
            {
                "arm64" => GetDeploymentResponseVariant1FunctionsArchitecture.Arm64,
                "x86_64" => GetDeploymentResponseVariant1FunctionsArchitecture.X8664,
                _ => null,
            };
        }
    }
}