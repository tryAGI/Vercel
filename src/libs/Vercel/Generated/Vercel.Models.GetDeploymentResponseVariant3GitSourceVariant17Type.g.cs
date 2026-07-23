
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant3GitSourceVariant17Type
    {
        /// <summary>
        /// 
        /// </summary>
        Vercel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant3GitSourceVariant17TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant3GitSourceVariant17Type value)
        {
            return value switch
            {
                GetDeploymentResponseVariant3GitSourceVariant17Type.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant3GitSourceVariant17Type? ToEnum(string value)
        {
            return value switch
            {
                "vercel" => GetDeploymentResponseVariant3GitSourceVariant17Type.Vercel,
                _ => null,
            };
        }
    }
}