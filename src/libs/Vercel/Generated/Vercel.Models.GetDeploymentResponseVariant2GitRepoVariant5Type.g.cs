
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant2GitRepoVariant5Type
    {
        /// <summary>
        /// 
        /// </summary>
        CursorOrigin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant2GitRepoVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2GitRepoVariant5Type value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2GitRepoVariant5Type.CursorOrigin => "cursor-origin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2GitRepoVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "cursor-origin" => GetDeploymentResponseVariant2GitRepoVariant5Type.CursorOrigin,
                _ => null,
            };
        }
    }
}