
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListRepositoryTagsResponseTagStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Preparing,
        /// <summary>
        /// 
        /// </summary>
        Ready,
        /// <summary>
        /// 
        /// </summary>
        Unoptimized,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListRepositoryTagsResponseTagStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRepositoryTagsResponseTagStatus value)
        {
            return value switch
            {
                ListRepositoryTagsResponseTagStatus.Preparing => "preparing",
                ListRepositoryTagsResponseTagStatus.Ready => "ready",
                ListRepositoryTagsResponseTagStatus.Unoptimized => "unoptimized",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRepositoryTagsResponseTagStatus? ToEnum(string value)
        {
            return value switch
            {
                "preparing" => ListRepositoryTagsResponseTagStatus.Preparing,
                "ready" => ListRepositoryTagsResponseTagStatus.Ready,
                "unoptimized" => ListRepositoryTagsResponseTagStatus.Unoptimized,
                _ => null,
            };
        }
    }
}