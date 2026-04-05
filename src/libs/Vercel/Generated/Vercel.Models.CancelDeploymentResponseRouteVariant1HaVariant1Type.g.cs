
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseRouteVariant1HaVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Host,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CancelDeploymentResponseRouteVariant1HaVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseRouteVariant1HaVariant1Type value)
        {
            return value switch
            {
                CancelDeploymentResponseRouteVariant1HaVariant1Type.Host => "host",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseRouteVariant1HaVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "host" => CancelDeploymentResponseRouteVariant1HaVariant1Type.Host,
                _ => null,
            };
        }
    }
}