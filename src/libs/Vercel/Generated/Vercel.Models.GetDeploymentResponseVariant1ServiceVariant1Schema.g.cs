
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant1ServiceVariant1Schema
    {
        /// <summary>
        /// 
        /// </summary>
        ExperimentalServices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant1ServiceVariant1SchemaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1ServiceVariant1Schema value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1ServiceVariant1Schema.ExperimentalServices => "experimentalServices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1ServiceVariant1Schema? ToEnum(string value)
        {
            return value switch
            {
                "experimentalServices" => GetDeploymentResponseVariant1ServiceVariant1Schema.ExperimentalServices,
                _ => null,
            };
        }
    }
}