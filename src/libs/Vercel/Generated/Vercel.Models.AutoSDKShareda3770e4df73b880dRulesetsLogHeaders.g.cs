
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda3770e4df73b880dRulesetsLogHeaders
    {
        /// <summary>
        ///
        /// </summary>
        Multiply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShareda3770e4df73b880dRulesetsLogHeadersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda3770e4df73b880dRulesetsLogHeaders value)
        {
            return value switch
            {
                AutoSDKShareda3770e4df73b880dRulesetsLogHeaders.Multiply => "*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda3770e4df73b880dRulesetsLogHeaders? ToEnum(string value)
        {
            return value switch
            {
                "*" => AutoSDKShareda3770e4df73b880dRulesetsLogHeaders.Multiply,
                _ => null,
            };
        }
    }
}