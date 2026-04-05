
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectAbuseBlockHistoryItemVariant3RouteVariant2MitigateAction
    {
        /// <summary>
        /// 
        /// </summary>
        BlockLegalCwc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMicrofrontendsInGroupResponseProjectAbuseBlockHistoryItemVariant3RouteVariant2MitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectAbuseBlockHistoryItemVariant3RouteVariant2MitigateAction value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectAbuseBlockHistoryItemVariant3RouteVariant2MitigateAction.BlockLegalCwc => "block_legal_cwc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectAbuseBlockHistoryItemVariant3RouteVariant2MitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "block_legal_cwc" => GetMicrofrontendsInGroupResponseProjectAbuseBlockHistoryItemVariant3RouteVariant2MitigateAction.BlockLegalCwc,
                _ => null,
            };
        }
    }
}