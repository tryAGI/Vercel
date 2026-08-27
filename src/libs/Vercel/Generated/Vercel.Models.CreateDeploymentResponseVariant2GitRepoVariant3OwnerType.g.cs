
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateDeploymentResponseVariant2GitRepoVariant3OwnerType
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
    public static class CreateDeploymentResponseVariant2GitRepoVariant3OwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2GitRepoVariant3OwnerType value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2GitRepoVariant3OwnerType.Team => "team",
                CreateDeploymentResponseVariant2GitRepoVariant3OwnerType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2GitRepoVariant3OwnerType? ToEnum(string value)
        {
            return value switch
            {
                "team" => CreateDeploymentResponseVariant2GitRepoVariant3OwnerType.Team,
                "user" => CreateDeploymentResponseVariant2GitRepoVariant3OwnerType.User,
                _ => null,
            };
        }
    }
}