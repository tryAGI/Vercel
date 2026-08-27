
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Event type - must be "schedule/v1beta" (REQUIRED)
    /// </summary>
    public enum CreateDeploymentResponseVariant2FunctionsExperimentalTriggerVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        ScheduleV1beta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseVariant2FunctionsExperimentalTriggerVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2FunctionsExperimentalTriggerVariant3Type value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2FunctionsExperimentalTriggerVariant3Type.ScheduleV1beta => "schedule/v1beta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2FunctionsExperimentalTriggerVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "schedule/v1beta" => CreateDeploymentResponseVariant2FunctionsExperimentalTriggerVariant3Type.ScheduleV1beta,
                _ => null,
            };
        }
    }
}