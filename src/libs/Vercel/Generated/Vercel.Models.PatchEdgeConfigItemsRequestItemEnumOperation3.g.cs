
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchEdgeConfigItemsRequestItemEnumOperation3
    {
        /// <summary>
        /// 
        /// </summary>
        Update,
        /// <summary>
        /// 
        /// </summary>
        Upsert,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchEdgeConfigItemsRequestItemEnumOperation3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchEdgeConfigItemsRequestItemEnumOperation3 value)
        {
            return value switch
            {
                PatchEdgeConfigItemsRequestItemEnumOperation3.Update => "update",
                PatchEdgeConfigItemsRequestItemEnumOperation3.Upsert => "upsert",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchEdgeConfigItemsRequestItemEnumOperation3? ToEnum(string value)
        {
            return value switch
            {
                "update" => PatchEdgeConfigItemsRequestItemEnumOperation3.Update,
                "upsert" => PatchEdgeConfigItemsRequestItemEnumOperation3.Upsert,
                _ => null,
            };
        }
    }
}