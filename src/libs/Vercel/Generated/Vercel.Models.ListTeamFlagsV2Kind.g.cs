
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The kind of flags to retrieve.
    /// </summary>
    public enum ListTeamFlagsV2Kind
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
    public static class ListTeamFlagsV2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListTeamFlagsV2Kind value)
        {
            return value switch
            {
                ListTeamFlagsV2Kind.Boolean => "boolean",
                ListTeamFlagsV2Kind.Json => "json",
                ListTeamFlagsV2Kind.Number => "number",
                ListTeamFlagsV2Kind.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListTeamFlagsV2Kind? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => ListTeamFlagsV2Kind.Boolean,
                "json" => ListTeamFlagsV2Kind.Json,
                "number" => ListTeamFlagsV2Kind.Number,
                "string" => ListTeamFlagsV2Kind.String,
                _ => null,
            };
        }
    }
}