
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFlagResponseKind
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
    public static class CreateFlagResponseKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFlagResponseKind value)
        {
            return value switch
            {
                CreateFlagResponseKind.Boolean => "boolean",
                CreateFlagResponseKind.Json => "json",
                CreateFlagResponseKind.Number => "number",
                CreateFlagResponseKind.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFlagResponseKind? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => CreateFlagResponseKind.Boolean,
                "json" => CreateFlagResponseKind.Json,
                "number" => CreateFlagResponseKind.Number,
                "string" => CreateFlagResponseKind.String,
                _ => null,
            };
        }
    }
}