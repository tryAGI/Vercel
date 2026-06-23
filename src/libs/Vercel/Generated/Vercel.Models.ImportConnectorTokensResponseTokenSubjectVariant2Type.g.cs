
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImportConnectorTokensResponseTokenSubjectVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImportConnectorTokensResponseTokenSubjectVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImportConnectorTokensResponseTokenSubjectVariant2Type value)
        {
            return value switch
            {
                ImportConnectorTokensResponseTokenSubjectVariant2Type.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImportConnectorTokensResponseTokenSubjectVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "user" => ImportConnectorTokensResponseTokenSubjectVariant2Type.User,
                _ => null,
            };
        }
    }
}