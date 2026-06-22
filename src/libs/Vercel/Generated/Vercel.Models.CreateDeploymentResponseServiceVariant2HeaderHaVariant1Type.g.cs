
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseServiceVariant2HeaderHaVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Host,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseServiceVariant2HeaderHaVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseServiceVariant2HeaderHaVariant1Type value)
        {
            return value switch
            {
                CreateDeploymentResponseServiceVariant2HeaderHaVariant1Type.Host => "host",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseServiceVariant2HeaderHaVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "host" => CreateDeploymentResponseServiceVariant2HeaderHaVariant1Type.Host,
                _ => null,
            };
        }
    }
}