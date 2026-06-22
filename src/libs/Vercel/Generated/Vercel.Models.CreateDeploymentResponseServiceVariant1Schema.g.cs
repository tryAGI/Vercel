
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseServiceVariant1Schema
    {
        /// <summary>
        /// 
        /// </summary>
        ExperimentalServices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseServiceVariant1SchemaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseServiceVariant1Schema value)
        {
            return value switch
            {
                CreateDeploymentResponseServiceVariant1Schema.ExperimentalServices => "experimentalServices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseServiceVariant1Schema? ToEnum(string value)
        {
            return value switch
            {
                "experimentalServices" => CreateDeploymentResponseServiceVariant1Schema.ExperimentalServices,
                _ => null,
            };
        }
    }
}