
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateConnectorRequestDataTypeApiKeySubjectType
    {
        /// <summary>
        /// 
        /// </summary>
        App,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateConnectorRequestDataTypeApiKeySubjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateConnectorRequestDataTypeApiKeySubjectType value)
        {
            return value switch
            {
                CreateConnectorRequestDataTypeApiKeySubjectType.App => "app",
                CreateConnectorRequestDataTypeApiKeySubjectType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateConnectorRequestDataTypeApiKeySubjectType? ToEnum(string value)
        {
            return value switch
            {
                "app" => CreateConnectorRequestDataTypeApiKeySubjectType.App,
                "user" => CreateConnectorRequestDataTypeApiKeySubjectType.User,
                _ => null,
            };
        }
    }
}