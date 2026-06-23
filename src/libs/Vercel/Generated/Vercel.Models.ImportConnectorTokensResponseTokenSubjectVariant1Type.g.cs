
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImportConnectorTokensResponseTokenSubjectVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        App,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImportConnectorTokensResponseTokenSubjectVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImportConnectorTokensResponseTokenSubjectVariant1Type value)
        {
            return value switch
            {
                ImportConnectorTokensResponseTokenSubjectVariant1Type.App => "app",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImportConnectorTokensResponseTokenSubjectVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "app" => ImportConnectorTokensResponseTokenSubjectVariant1Type.App,
                _ => null,
            };
        }
    }
}