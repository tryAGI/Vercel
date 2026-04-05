
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Event type - must be "queue/v2beta" (REQUIRED)
    /// </summary>
    public enum CreateDeploymentResponseFunctionsExperimentalTriggerVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        QueueV2beta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseFunctionsExperimentalTriggerVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseFunctionsExperimentalTriggerVariant2Type value)
        {
            return value switch
            {
                CreateDeploymentResponseFunctionsExperimentalTriggerVariant2Type.QueueV2beta => "queue/v2beta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseFunctionsExperimentalTriggerVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "queue/v2beta" => CreateDeploymentResponseFunctionsExperimentalTriggerVariant2Type.QueueV2beta,
                _ => null,
            };
        }
    }
}