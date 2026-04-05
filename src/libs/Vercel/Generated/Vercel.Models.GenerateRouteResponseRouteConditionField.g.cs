
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GenerateRouteResponseRouteConditionField
    {
        /// <summary>
        /// 
        /// </summary>
        Cookie,
        /// <summary>
        /// 
        /// </summary>
        Header,
        /// <summary>
        /// 
        /// </summary>
        Host,
        /// <summary>
        /// 
        /// </summary>
        Query,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerateRouteResponseRouteConditionFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateRouteResponseRouteConditionField value)
        {
            return value switch
            {
                GenerateRouteResponseRouteConditionField.Cookie => "cookie",
                GenerateRouteResponseRouteConditionField.Header => "header",
                GenerateRouteResponseRouteConditionField.Host => "host",
                GenerateRouteResponseRouteConditionField.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateRouteResponseRouteConditionField? ToEnum(string value)
        {
            return value switch
            {
                "cookie" => GenerateRouteResponseRouteConditionField.Cookie,
                "header" => GenerateRouteResponseRouteConditionField.Header,
                "host" => GenerateRouteResponseRouteConditionField.Host,
                "query" => GenerateRouteResponseRouteConditionField.Query,
                _ => null,
            };
        }
    }
}