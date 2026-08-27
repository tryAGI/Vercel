
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateDeploymentResponseVariant2GitRepoVariant5OwnerType
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
    public static class CreateDeploymentResponseVariant2GitRepoVariant5OwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2GitRepoVariant5OwnerType value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2GitRepoVariant5OwnerType.Team => "team",
                CreateDeploymentResponseVariant2GitRepoVariant5OwnerType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2GitRepoVariant5OwnerType? ToEnum(string value)
        {
            return value switch
            {
                "team" => CreateDeploymentResponseVariant2GitRepoVariant5OwnerType.Team,
                "user" => CreateDeploymentResponseVariant2GitRepoVariant5OwnerType.User,
                _ => null,
            };
        }
    }
}