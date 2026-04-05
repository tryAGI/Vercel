
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseGitRepoVariant1OwnerType
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
    public static class CreateDeploymentResponseGitRepoVariant1OwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseGitRepoVariant1OwnerType value)
        {
            return value switch
            {
                CreateDeploymentResponseGitRepoVariant1OwnerType.Team => "team",
                CreateDeploymentResponseGitRepoVariant1OwnerType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseGitRepoVariant1OwnerType? ToEnum(string value)
        {
            return value switch
            {
                "team" => CreateDeploymentResponseGitRepoVariant1OwnerType.Team,
                "user" => CreateDeploymentResponseGitRepoVariant1OwnerType.User,
                _ => null,
            };
        }
    }
}