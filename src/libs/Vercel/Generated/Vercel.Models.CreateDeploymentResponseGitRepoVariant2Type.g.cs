
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseGitRepoVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Github,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseGitRepoVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseGitRepoVariant2Type value)
        {
            return value switch
            {
                CreateDeploymentResponseGitRepoVariant2Type.Github => "github",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseGitRepoVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "github" => CreateDeploymentResponseGitRepoVariant2Type.Github,
                _ => null,
            };
        }
    }
}