
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseGitRepoVariant2OwnerType
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
    public static class CancelDeploymentResponseGitRepoVariant2OwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseGitRepoVariant2OwnerType value)
        {
            return value switch
            {
                CancelDeploymentResponseGitRepoVariant2OwnerType.Team => "team",
                CancelDeploymentResponseGitRepoVariant2OwnerType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseGitRepoVariant2OwnerType? ToEnum(string value)
        {
            return value switch
            {
                "team" => CancelDeploymentResponseGitRepoVariant2OwnerType.Team,
                "user" => CancelDeploymentResponseGitRepoVariant2OwnerType.User,
                _ => null,
            };
        }
    }
}