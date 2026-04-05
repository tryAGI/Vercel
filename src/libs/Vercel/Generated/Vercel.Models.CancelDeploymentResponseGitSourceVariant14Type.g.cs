
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseGitSourceVariant14Type
    {
        /// <summary>
        /// 
        /// </summary>
        GithubLimited,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CancelDeploymentResponseGitSourceVariant14TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseGitSourceVariant14Type value)
        {
            return value switch
            {
                CancelDeploymentResponseGitSourceVariant14Type.GithubLimited => "github-limited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseGitSourceVariant14Type? ToEnum(string value)
        {
            return value switch
            {
                "github-limited" => CancelDeploymentResponseGitSourceVariant14Type.GithubLimited,
                _ => null,
            };
        }
    }
}