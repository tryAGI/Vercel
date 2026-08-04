
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseGitSourceVariant19Type
    {
        /// <summary>
        /// 
        /// </summary>
        CursorOrigin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CancelDeploymentResponseGitSourceVariant19TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseGitSourceVariant19Type value)
        {
            return value switch
            {
                CancelDeploymentResponseGitSourceVariant19Type.CursorOrigin => "cursor-origin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseGitSourceVariant19Type? ToEnum(string value)
        {
            return value switch
            {
                "cursor-origin" => CancelDeploymentResponseGitSourceVariant19Type.CursorOrigin,
                _ => null,
            };
        }
    }
}