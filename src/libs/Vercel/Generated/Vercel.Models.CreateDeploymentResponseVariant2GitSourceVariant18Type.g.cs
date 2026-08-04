
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseVariant2GitSourceVariant18Type
    {
        /// <summary>
        /// 
        /// </summary>
        Vercel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseVariant2GitSourceVariant18TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2GitSourceVariant18Type value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2GitSourceVariant18Type.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2GitSourceVariant18Type? ToEnum(string value)
        {
            return value switch
            {
                "vercel" => CreateDeploymentResponseVariant2GitSourceVariant18Type.Vercel,
                _ => null,
            };
        }
    }
}