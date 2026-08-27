
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetDeploymentResponseVariant2ServiceVariant2HeaderMissingItemVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        Host,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant2ServiceVariant2HeaderMissingItemVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2ServiceVariant2HeaderMissingItemVariant1Type value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2ServiceVariant2HeaderMissingItemVariant1Type.Host => "host",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2ServiceVariant2HeaderMissingItemVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "host" => GetDeploymentResponseVariant2ServiceVariant2HeaderMissingItemVariant1Type.Host,
                _ => null,
            };
        }
    }
}