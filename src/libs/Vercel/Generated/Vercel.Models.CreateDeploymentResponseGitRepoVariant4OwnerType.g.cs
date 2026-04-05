
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseGitRepoVariant4OwnerType
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
    public static class CreateDeploymentResponseGitRepoVariant4OwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseGitRepoVariant4OwnerType value)
        {
            return value switch
            {
                CreateDeploymentResponseGitRepoVariant4OwnerType.Team => "team",
                CreateDeploymentResponseGitRepoVariant4OwnerType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseGitRepoVariant4OwnerType? ToEnum(string value)
        {
            return value switch
            {
                "team" => CreateDeploymentResponseGitRepoVariant4OwnerType.Team,
                "user" => CreateDeploymentResponseGitRepoVariant4OwnerType.User,
                _ => null,
            };
        }
    }
}