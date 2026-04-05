
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseGitRepoVariant2OwnerType
    {
        /// <summary>
        /// 
        /// </summary>
        Team,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseGitRepoVariant2OwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseGitRepoVariant2OwnerType value)
        {
            return value switch
            {
                CreateDeploymentResponseGitRepoVariant2OwnerType.Team => "team",
                CreateDeploymentResponseGitRepoVariant2OwnerType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseGitRepoVariant2OwnerType? ToEnum(string value)
        {
            return value switch
            {
                "team" => CreateDeploymentResponseGitRepoVariant2OwnerType.Team,
                "user" => CreateDeploymentResponseGitRepoVariant2OwnerType.User,
                _ => null,
            };
        }
    }
}