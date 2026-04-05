
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Event type - must be "queue/v2beta" (REQUIRED)
    /// </summary>
    public enum CancelDeploymentResponseFunctionsExperimentalTriggerVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        QueueV2beta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CancelDeploymentResponseFunctionsExperimentalTriggerVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseFunctionsExperimentalTriggerVariant2Type value)
        {
            return value switch
            {
                CancelDeploymentResponseFunctionsExperimentalTriggerVariant2Type.QueueV2beta => "queue/v2beta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseFunctionsExperimentalTriggerVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "queue/v2beta" => CancelDeploymentResponseFunctionsExperimentalTriggerVariant2Type.QueueV2beta,
                _ => null,
            };
        }
    }
}