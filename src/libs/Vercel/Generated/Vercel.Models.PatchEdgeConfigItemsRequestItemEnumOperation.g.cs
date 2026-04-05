
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchEdgeConfigItemsRequestItemEnumOperation
    {
        /// <summary>
        /// 
        /// </summary>
        Create,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchEdgeConfigItemsRequestItemEnumOperationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchEdgeConfigItemsRequestItemEnumOperation value)
        {
            return value switch
            {
                PatchEdgeConfigItemsRequestItemEnumOperation.Create => "create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchEdgeConfigItemsRequestItemEnumOperation? ToEnum(string value)
        {
            return value switch
            {
                "create" => PatchEdgeConfigItemsRequestItemEnumOperation.Create,
                _ => null,
            };
        }
    }
}