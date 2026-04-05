
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum SegmentTypeName
    {
        /// <summary>
        /// 
        /// </summary>
        Segment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SegmentTypeNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SegmentTypeName value)
        {
            return value switch
            {
                SegmentTypeName.Segment => "segment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SegmentTypeName? ToEnum(string value)
        {
            return value switch
            {
                "segment" => SegmentTypeName.Segment,
                _ => null,
            };
        }
    }
}