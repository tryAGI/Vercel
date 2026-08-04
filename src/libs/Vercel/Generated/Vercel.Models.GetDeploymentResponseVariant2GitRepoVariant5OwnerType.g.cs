
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant2GitRepoVariant5OwnerType
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
    public static class GetDeploymentResponseVariant2GitRepoVariant5OwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2GitRepoVariant5OwnerType value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2GitRepoVariant5OwnerType.Team => "team",
                GetDeploymentResponseVariant2GitRepoVariant5OwnerType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2GitRepoVariant5OwnerType? ToEnum(string value)
        {
            return value switch
            {
                "team" => GetDeploymentResponseVariant2GitRepoVariant5OwnerType.Team,
                "user" => GetDeploymentResponseVariant2GitRepoVariant5OwnerType.User,
                _ => null,
            };
        }
    }
}