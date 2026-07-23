
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Event type - must be "queue/v2beta" (REQUIRED)
    /// </summary>
    public enum CreateDeploymentResponseVariant2ServiceVariant1BuilderConfigFunctionsExperimentalTriggerVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        QueueV2beta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseVariant2ServiceVariant1BuilderConfigFunctionsExperimentalTriggerVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2ServiceVariant1BuilderConfigFunctionsExperimentalTriggerVariant2Type value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2ServiceVariant1BuilderConfigFunctionsExperimentalTriggerVariant2Type.QueueV2beta => "queue/v2beta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2ServiceVariant1BuilderConfigFunctionsExperimentalTriggerVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "queue/v2beta" => CreateDeploymentResponseVariant2ServiceVariant1BuilderConfigFunctionsExperimentalTriggerVariant2Type.QueueV2beta,
                _ => null,
            };
        }
    }
}