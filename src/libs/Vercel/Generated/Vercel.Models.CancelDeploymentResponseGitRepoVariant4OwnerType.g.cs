
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseGitRepoVariant4OwnerType
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
    public static class CancelDeploymentResponseGitRepoVariant4OwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseGitRepoVariant4OwnerType value)
        {
            return value switch
            {
                CancelDeploymentResponseGitRepoVariant4OwnerType.Team => "team",
                CancelDeploymentResponseGitRepoVariant4OwnerType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseGitRepoVariant4OwnerType? ToEnum(string value)
        {
            return value switch
            {
                "team" => CancelDeploymentResponseGitRepoVariant4OwnerType.Team,
                "user" => CancelDeploymentResponseGitRepoVariant4OwnerType.User,
                _ => null,
            };
        }
    }
}