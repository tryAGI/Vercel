
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseServiceVariant1Schema
    {
        /// <summary>
        /// 
        /// </summary>
        ExperimentalServices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CancelDeploymentResponseServiceVariant1SchemaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseServiceVariant1Schema value)
        {
            return value switch
            {
                CancelDeploymentResponseServiceVariant1Schema.ExperimentalServices => "experimentalServices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseServiceVariant1Schema? ToEnum(string value)
        {
            return value switch
            {
                "experimentalServices" => CancelDeploymentResponseServiceVariant1Schema.ExperimentalServices,
                _ => null,
            };
        }
    }
}