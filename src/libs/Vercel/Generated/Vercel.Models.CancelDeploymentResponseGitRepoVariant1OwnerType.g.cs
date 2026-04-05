
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseGitRepoVariant1OwnerType
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
    public static class CancelDeploymentResponseGitRepoVariant1OwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseGitRepoVariant1OwnerType value)
        {
            return value switch
            {
                CancelDeploymentResponseGitRepoVariant1OwnerType.Team => "team",
                CancelDeploymentResponseGitRepoVariant1OwnerType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseGitRepoVariant1OwnerType? ToEnum(string value)
        {
            return value switch
            {
                "team" => CancelDeploymentResponseGitRepoVariant1OwnerType.Team,
                "user" => CancelDeploymentResponseGitRepoVariant1OwnerType.User,
                _ => null,
            };
        }
    }
}