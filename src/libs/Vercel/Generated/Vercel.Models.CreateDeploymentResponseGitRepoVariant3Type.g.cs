
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseGitRepoVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        Bitbucket,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseGitRepoVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseGitRepoVariant3Type value)
        {
            return value switch
            {
                CreateDeploymentResponseGitRepoVariant3Type.Bitbucket => "bitbucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseGitRepoVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => CreateDeploymentResponseGitRepoVariant3Type.Bitbucket,
                _ => null,
            };
        }
    }
}