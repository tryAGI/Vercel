
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseServiceVariant2Schema
    {
        /// <summary>
        /// 
        /// </summary>
        ExperimentalServicesV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseServiceVariant2SchemaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseServiceVariant2Schema value)
        {
            return value switch
            {
                CreateDeploymentResponseServiceVariant2Schema.ExperimentalServicesV2 => "experimentalServicesV2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseServiceVariant2Schema? ToEnum(string value)
        {
            return value switch
            {
                "experimentalServicesV2" => CreateDeploymentResponseServiceVariant2Schema.ExperimentalServicesV2,
                _ => null,
            };
        }
    }
}