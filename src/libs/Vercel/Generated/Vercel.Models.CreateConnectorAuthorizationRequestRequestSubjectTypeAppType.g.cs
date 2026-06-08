
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateConnectorAuthorizationRequestRequestSubjectTypeAppType
    {
        /// <summary>
        /// 
        /// </summary>
        App,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateConnectorAuthorizationRequestRequestSubjectTypeAppTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateConnectorAuthorizationRequestRequestSubjectTypeAppType value)
        {
            return value switch
            {
                CreateConnectorAuthorizationRequestRequestSubjectTypeAppType.App => "app",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateConnectorAuthorizationRequestRequestSubjectTypeAppType? ToEnum(string value)
        {
            return value switch
            {
                "app" => CreateConnectorAuthorizationRequestRequestSubjectTypeAppType.App,
                _ => null,
            };
        }
    }
}