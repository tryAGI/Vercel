
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetDeploymentResponseVariant3GitSourceVariant19Type
    {
        /// <summary>
        ///
        /// </summary>
        CursorOrigin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant3GitSourceVariant19TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant3GitSourceVariant19Type value)
        {
            return value switch
            {
                GetDeploymentResponseVariant3GitSourceVariant19Type.CursorOrigin => "cursor-origin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant3GitSourceVariant19Type? ToEnum(string value)
        {
            return value switch
            {
                "cursor-origin" => GetDeploymentResponseVariant3GitSourceVariant19Type.CursorOrigin,
                _ => null,
            };
        }
    }
}