
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum InvalidateByTagsRequestTarget
    {
        /// <summary>
        /// 
        /// </summary>
        Preview,
        /// <summary>
        /// 
        /// </summary>
        Production,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InvalidateByTagsRequestTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InvalidateByTagsRequestTarget value)
        {
            return value switch
            {
                InvalidateByTagsRequestTarget.Preview => "preview",
                InvalidateByTagsRequestTarget.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InvalidateByTagsRequestTarget? ToEnum(string value)
        {
            return value switch
            {
                "preview" => InvalidateByTagsRequestTarget.Preview,
                "production" => InvalidateByTagsRequestTarget.Production,
                _ => null,
            };
        }
    }
}