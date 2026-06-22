
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseServiceVariant2Schema
    {
        /// <summary>
        /// 
        /// </summary>
        ExperimentalServicesV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CancelDeploymentResponseServiceVariant2SchemaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseServiceVariant2Schema value)
        {
            return value switch
            {
                CancelDeploymentResponseServiceVariant2Schema.ExperimentalServicesV2 => "experimentalServicesV2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseServiceVariant2Schema? ToEnum(string value)
        {
            return value switch
            {
                "experimentalServicesV2" => CancelDeploymentResponseServiceVariant2Schema.ExperimentalServicesV2,
                _ => null,
            };
        }
    }
}