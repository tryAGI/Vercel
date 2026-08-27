
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CancelDeploymentResponseGitRepoVariant5OwnerType
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
    public static class CancelDeploymentResponseGitRepoVariant5OwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseGitRepoVariant5OwnerType value)
        {
            return value switch
            {
                CancelDeploymentResponseGitRepoVariant5OwnerType.Team => "team",
                CancelDeploymentResponseGitRepoVariant5OwnerType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseGitRepoVariant5OwnerType? ToEnum(string value)
        {
            return value switch
            {
                "team" => CancelDeploymentResponseGitRepoVariant5OwnerType.Team,
                "user" => CancelDeploymentResponseGitRepoVariant5OwnerType.User,
                _ => null,
            };
        }
    }
}