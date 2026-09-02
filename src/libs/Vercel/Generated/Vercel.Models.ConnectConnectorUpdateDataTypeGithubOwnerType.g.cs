
#nullable enable

namespace Vercel
{
    /// <summary>
    /// GitHub App owner type.
    /// </summary>
    public enum ConnectConnectorUpdateDataTypeGithubOwnerType
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
    public static class ConnectConnectorUpdateDataTypeGithubOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectConnectorUpdateDataTypeGithubOwnerType value)
        {
            return value switch
            {
                ConnectConnectorUpdateDataTypeGithubOwnerType.Organization2 => "Organization",
                ConnectConnectorUpdateDataTypeGithubOwnerType.User2 => "User",
                ConnectConnectorUpdateDataTypeGithubOwnerType.Organization => "organization",
                ConnectConnectorUpdateDataTypeGithubOwnerType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectConnectorUpdateDataTypeGithubOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Organization" => ConnectConnectorUpdateDataTypeGithubOwnerType.Organization2,
                "User" => ConnectConnectorUpdateDataTypeGithubOwnerType.User2,
                "organization" => ConnectConnectorUpdateDataTypeGithubOwnerType.Organization,
                "user" => ConnectConnectorUpdateDataTypeGithubOwnerType.User,
                _ => null,
            };
        }
    }
}