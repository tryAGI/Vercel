
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchEdgeConfigItemsRequestItemOperation
    {
        /// <summary>
        /// 
        /// </summary>
        Create,
        /// <summary>
        /// 
        /// </summary>
        Delete,
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
    public static class PatchEdgeConfigItemsRequestItemOperationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchEdgeConfigItemsRequestItemOperation value)
        {
            return value switch
            {
                PatchEdgeConfigItemsRequestItemOperation.Create => "create",
                PatchEdgeConfigItemsRequestItemOperation.Delete => "delete",
                PatchEdgeConfigItemsRequestItemOperation.Update => "update",
                PatchEdgeConfigItemsRequestItemOperation.Upsert => "upsert",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchEdgeConfigItemsRequestItemOperation? ToEnum(string value)
        {
            return value switch
            {
                "create" => PatchEdgeConfigItemsRequestItemOperation.Create,
                "delete" => PatchEdgeConfigItemsRequestItemOperation.Delete,
                "update" => PatchEdgeConfigItemsRequestItemOperation.Update,
                "upsert" => PatchEdgeConfigItemsRequestItemOperation.Upsert,
                _ => null,
            };
        }
    }
}