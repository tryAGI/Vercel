
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant1GitSourceVariant10Type
    {
        /// <summary>
        /// 
        /// </summary>
        Vercel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant1GitSourceVariant10TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1GitSourceVariant10Type value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1GitSourceVariant10Type.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1GitSourceVariant10Type? ToEnum(string value)
        {
            return value switch
            {
                "vercel" => GetDeploymentResponseVariant1GitSourceVariant10Type.Vercel,
                _ => null,
            };
        }
    }
}