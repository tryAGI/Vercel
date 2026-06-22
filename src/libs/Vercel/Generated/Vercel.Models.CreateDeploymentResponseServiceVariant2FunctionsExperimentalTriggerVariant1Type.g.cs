
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Event type - must be "queue/v1beta" (REQUIRED)
    /// </summary>
    public enum CreateDeploymentResponseServiceVariant2FunctionsExperimentalTriggerVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        QueueV1beta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseServiceVariant2FunctionsExperimentalTriggerVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseServiceVariant2FunctionsExperimentalTriggerVariant1Type value)
        {
            return value switch
            {
                CreateDeploymentResponseServiceVariant2FunctionsExperimentalTriggerVariant1Type.QueueV1beta => "queue/v1beta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseServiceVariant2FunctionsExperimentalTriggerVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "queue/v1beta" => CreateDeploymentResponseServiceVariant2FunctionsExperimentalTriggerVariant1Type.QueueV1beta,
                _ => null,
            };
        }
    }
}