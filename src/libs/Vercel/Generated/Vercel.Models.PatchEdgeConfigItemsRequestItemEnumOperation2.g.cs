
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchEdgeConfigItemsRequestItemEnumOperation2
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
    public static class PatchEdgeConfigItemsRequestItemEnumOperation2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchEdgeConfigItemsRequestItemEnumOperation2 value)
        {
            return value switch
            {
                PatchEdgeConfigItemsRequestItemEnumOperation2.Update => "update",
                PatchEdgeConfigItemsRequestItemEnumOperation2.Upsert => "upsert",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchEdgeConfigItemsRequestItemEnumOperation2? ToEnum(string value)
        {
            return value switch
            {
                "update" => PatchEdgeConfigItemsRequestItemEnumOperation2.Update,
                "upsert" => PatchEdgeConfigItemsRequestItemEnumOperation2.Upsert,
                _ => null,
            };
        }
    }
}