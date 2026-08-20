
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Event type - must be "schedule/v1beta" (REQUIRED)
    /// </summary>
    public enum GetDeploymentResponseVariant2ServiceVariant1BuilderConfigFunctionsExperimentalTriggerVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        ScheduleV1beta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant2ServiceVariant1BuilderConfigFunctionsExperimentalTriggerVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2ServiceVariant1BuilderConfigFunctionsExperimentalTriggerVariant3Type value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2ServiceVariant1BuilderConfigFunctionsExperimentalTriggerVariant3Type.ScheduleV1beta => "schedule/v1beta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2ServiceVariant1BuilderConfigFunctionsExperimentalTriggerVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "schedule/v1beta" => GetDeploymentResponseVariant2ServiceVariant1BuilderConfigFunctionsExperimentalTriggerVariant3Type.ScheduleV1beta,
                _ => null,
            };
        }
    }
}