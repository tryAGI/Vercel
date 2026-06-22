
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Event type - must be "queue/v1beta" (REQUIRED)
    /// </summary>
    public enum CancelDeploymentResponseServiceVariant1BuilderConfigFunctionsExperimentalTriggerVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        QueueV1beta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CancelDeploymentResponseServiceVariant1BuilderConfigFunctionsExperimentalTriggerVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseServiceVariant1BuilderConfigFunctionsExperimentalTriggerVariant1Type value)
        {
            return value switch
            {
                CancelDeploymentResponseServiceVariant1BuilderConfigFunctionsExperimentalTriggerVariant1Type.QueueV1beta => "queue/v1beta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseServiceVariant1BuilderConfigFunctionsExperimentalTriggerVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "queue/v1beta" => CancelDeploymentResponseServiceVariant1BuilderConfigFunctionsExperimentalTriggerVariant1Type.QueueV1beta,
                _ => null,
            };
        }
    }
}