
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum DangerouslyDeleteByTagsRequestTarget
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
    public static class DangerouslyDeleteByTagsRequestTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DangerouslyDeleteByTagsRequestTarget value)
        {
            return value switch
            {
                DangerouslyDeleteByTagsRequestTarget.Preview => "preview",
                DangerouslyDeleteByTagsRequestTarget.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DangerouslyDeleteByTagsRequestTarget? ToEnum(string value)
        {
            return value switch
            {
                "preview" => DangerouslyDeleteByTagsRequestTarget.Preview,
                "production" => DangerouslyDeleteByTagsRequestTarget.Production,
                _ => null,
            };
        }
    }
}