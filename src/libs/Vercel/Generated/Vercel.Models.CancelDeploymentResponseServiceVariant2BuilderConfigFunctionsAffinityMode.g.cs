
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CancelDeploymentResponseServiceVariant2BuilderConfigFunctionsAffinityMode
    {
        /// <summary>
        ///
        /// </summary>
        Strict,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CancelDeploymentResponseServiceVariant2BuilderConfigFunctionsAffinityModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseServiceVariant2BuilderConfigFunctionsAffinityMode value)
        {
            return value switch
            {
                CancelDeploymentResponseServiceVariant2BuilderConfigFunctionsAffinityMode.Strict => "strict",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseServiceVariant2BuilderConfigFunctionsAffinityMode? ToEnum(string value)
        {
            return value switch
            {
                "strict" => CancelDeploymentResponseServiceVariant2BuilderConfigFunctionsAffinityMode.Strict,
                _ => null,
            };
        }
    }
}