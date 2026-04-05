
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseGitSourceVariant11Type
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CancelDeploymentResponseGitSourceVariant11TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseGitSourceVariant11Type value)
        {
            return value switch
            {
                CancelDeploymentResponseGitSourceVariant11Type.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseGitSourceVariant11Type? ToEnum(string value)
        {
            return value switch
            {
                "custom" => CancelDeploymentResponseGitSourceVariant11Type.Custom,
                _ => null,
            };
        }
    }
}