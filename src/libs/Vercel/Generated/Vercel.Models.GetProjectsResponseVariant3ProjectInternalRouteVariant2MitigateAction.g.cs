
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectInternalRouteVariant2MitigateAction
    {
        /// <summary>
        /// 
        /// </summary>
        BlockLegalCwc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant3ProjectInternalRouteVariant2MitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectInternalRouteVariant2MitigateAction value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectInternalRouteVariant2MitigateAction.BlockLegalCwc => "block_legal_cwc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectInternalRouteVariant2MitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "block_legal_cwc" => GetProjectsResponseVariant3ProjectInternalRouteVariant2MitigateAction.BlockLegalCwc,
                _ => null,
            };
        }
    }
}