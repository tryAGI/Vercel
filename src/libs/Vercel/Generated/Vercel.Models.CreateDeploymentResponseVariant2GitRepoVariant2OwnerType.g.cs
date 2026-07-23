
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseVariant2GitRepoVariant2OwnerType
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
    public static class CreateDeploymentResponseVariant2GitRepoVariant2OwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2GitRepoVariant2OwnerType value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2GitRepoVariant2OwnerType.Team => "team",
                CreateDeploymentResponseVariant2GitRepoVariant2OwnerType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2GitRepoVariant2OwnerType? ToEnum(string value)
        {
            return value switch
            {
                "team" => CreateDeploymentResponseVariant2GitRepoVariant2OwnerType.Team,
                "user" => CreateDeploymentResponseVariant2GitRepoVariant2OwnerType.User,
                _ => null,
            };
        }
    }
}