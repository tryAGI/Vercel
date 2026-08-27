
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Event type - must be "schedule/v1beta" (REQUIRED)
    /// </summary>
    public enum CancelDeploymentResponseServiceVariant2BuilderConfigFunctionsExperimentalTriggerVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        ScheduleV1beta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CancelDeploymentResponseServiceVariant2BuilderConfigFunctionsExperimentalTriggerVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseServiceVariant2BuilderConfigFunctionsExperimentalTriggerVariant3Type value)
        {
            return value switch
            {
                CancelDeploymentResponseServiceVariant2BuilderConfigFunctionsExperimentalTriggerVariant3Type.ScheduleV1beta => "schedule/v1beta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseServiceVariant2BuilderConfigFunctionsExperimentalTriggerVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "schedule/v1beta" => CancelDeploymentResponseServiceVariant2BuilderConfigFunctionsExperimentalTriggerVariant3Type.ScheduleV1beta,
                _ => null,
            };
        }
    }
}