
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchEdgeConfigItemsRequestItemEnumOperation4
    {
        /// <summary>
        ///
        /// </summary>
        Delete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchEdgeConfigItemsRequestItemEnumOperation4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchEdgeConfigItemsRequestItemEnumOperation4 value)
        {
            return value switch
            {
                PatchEdgeConfigItemsRequestItemEnumOperation4.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchEdgeConfigItemsRequestItemEnumOperation4? ToEnum(string value)
        {
            return value switch
            {
                "delete" => PatchEdgeConfigItemsRequestItemEnumOperation4.Delete,
                _ => null,
            };
        }
    }
}