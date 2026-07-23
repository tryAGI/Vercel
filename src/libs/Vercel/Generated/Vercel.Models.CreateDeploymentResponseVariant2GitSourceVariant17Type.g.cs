
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseVariant2GitSourceVariant17Type
    {
        /// <summary>
        /// 
        /// </summary>
        Vercel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseVariant2GitSourceVariant17TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2GitSourceVariant17Type value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2GitSourceVariant17Type.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2GitSourceVariant17Type? ToEnum(string value)
        {
            return value switch
            {
                "vercel" => CreateDeploymentResponseVariant2GitSourceVariant17Type.Vercel,
                _ => null,
            };
        }
    }
}