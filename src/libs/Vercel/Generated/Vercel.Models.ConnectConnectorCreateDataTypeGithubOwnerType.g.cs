
#nullable enable

namespace Vercel
{
    /// <summary>
    /// GitHub App owner type.
    /// </summary>
    public enum ConnectConnectorCreateDataTypeGithubOwnerType
    {
        /// <summary>
        /// 
        /// </summary>
        Organization2,
        /// <summary>
        /// 
        /// </summary>
        User2,
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConnectConnectorCreateDataTypeGithubOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectConnectorCreateDataTypeGithubOwnerType value)
        {
            return value switch
            {
                ConnectConnectorCreateDataTypeGithubOwnerType.Organization2 => "Organization",
                ConnectConnectorCreateDataTypeGithubOwnerType.User2 => "User",
                ConnectConnectorCreateDataTypeGithubOwnerType.Organization => "organization",
                ConnectConnectorCreateDataTypeGithubOwnerType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectConnectorCreateDataTypeGithubOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Organization" => ConnectConnectorCreateDataTypeGithubOwnerType.Organization2,
                "User" => ConnectConnectorCreateDataTypeGithubOwnerType.User2,
                "organization" => ConnectConnectorCreateDataTypeGithubOwnerType.Organization,
                "user" => ConnectConnectorCreateDataTypeGithubOwnerType.User,
                _ => null,
            };
        }
    }
}