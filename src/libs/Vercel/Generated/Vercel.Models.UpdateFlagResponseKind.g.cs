
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFlagResponseKind
    {
        /// <summary>
        /// 
        /// </summary>
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        Number,
        /// <summary>
        /// 
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFlagResponseKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagResponseKind value)
        {
            return value switch
            {
                UpdateFlagResponseKind.Boolean => "boolean",
                UpdateFlagResponseKind.Json => "json",
                UpdateFlagResponseKind.Number => "number",
                UpdateFlagResponseKind.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagResponseKind? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => UpdateFlagResponseKind.Boolean,
                "json" => UpdateFlagResponseKind.Json,
                "number" => UpdateFlagResponseKind.Number,
                "string" => UpdateFlagResponseKind.String,
                _ => null,
            };
        }
    }
}