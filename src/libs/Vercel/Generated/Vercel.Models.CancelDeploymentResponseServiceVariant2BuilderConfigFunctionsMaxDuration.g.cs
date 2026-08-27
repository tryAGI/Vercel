
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CancelDeploymentResponseServiceVariant2BuilderConfigFunctionsMaxDuration
    {
        /// <summary>
        ///
        /// </summary>
        Max,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CancelDeploymentResponseServiceVariant2BuilderConfigFunctionsMaxDurationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseServiceVariant2BuilderConfigFunctionsMaxDuration value)
        {
            return value switch
            {
                CancelDeploymentResponseServiceVariant2BuilderConfigFunctionsMaxDuration.Max => "max",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseServiceVariant2BuilderConfigFunctionsMaxDuration? ToEnum(string value)
        {
            return value switch
            {
                "max" => CancelDeploymentResponseServiceVariant2BuilderConfigFunctionsMaxDuration.Max,
                _ => null,
            };
        }
    }
}