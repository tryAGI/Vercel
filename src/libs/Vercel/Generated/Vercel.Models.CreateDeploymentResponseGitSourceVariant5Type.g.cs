
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseGitSourceVariant5Type
    {
        /// <summary>
        /// 
        /// </summary>
        GithubLimited,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseGitSourceVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseGitSourceVariant5Type value)
        {
            return value switch
            {
                CreateDeploymentResponseGitSourceVariant5Type.GithubLimited => "github-limited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseGitSourceVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "github-limited" => CreateDeploymentResponseGitSourceVariant5Type.GithubLimited,
                _ => null,
            };
        }
    }
}