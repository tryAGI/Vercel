
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseGitRepoVariant3OwnerType
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
    public static class CancelDeploymentResponseGitRepoVariant3OwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseGitRepoVariant3OwnerType value)
        {
            return value switch
            {
                CancelDeploymentResponseGitRepoVariant3OwnerType.Team => "team",
                CancelDeploymentResponseGitRepoVariant3OwnerType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseGitRepoVariant3OwnerType? ToEnum(string value)
        {
            return value switch
            {
                "team" => CancelDeploymentResponseGitRepoVariant3OwnerType.Team,
                "user" => CancelDeploymentResponseGitRepoVariant3OwnerType.User,
                _ => null,
            };
        }
    }
}