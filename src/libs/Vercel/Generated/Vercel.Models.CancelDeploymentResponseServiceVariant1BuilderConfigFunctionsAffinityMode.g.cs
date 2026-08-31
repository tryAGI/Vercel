
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CancelDeploymentResponseServiceVariant1BuilderConfigFunctionsAffinityMode
    {
        /// <summary>
        ///
        /// </summary>
        Strict,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CancelDeploymentResponseServiceVariant1BuilderConfigFunctionsAffinityModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseServiceVariant1BuilderConfigFunctionsAffinityMode value)
        {
            return value switch
            {
                CancelDeploymentResponseServiceVariant1BuilderConfigFunctionsAffinityMode.Strict => "strict",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseServiceVariant1BuilderConfigFunctionsAffinityMode? ToEnum(string value)
        {
            return value switch
            {
                "strict" => CancelDeploymentResponseServiceVariant1BuilderConfigFunctionsAffinityMode.Strict,
                _ => null,
            };
        }
    }
}