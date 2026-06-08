
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConnectorTokenRequestSubjectTypeUserType
    {
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectorTokenRequestSubjectTypeUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectorTokenRequestSubjectTypeUserType value)
        {
            return value switch
            {
                GetConnectorTokenRequestSubjectTypeUserType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectorTokenRequestSubjectTypeUserType? ToEnum(string value)
        {
            return value switch
            {
                "user" => GetConnectorTokenRequestSubjectTypeUserType.User,
                _ => null,
            };
        }
    }
}