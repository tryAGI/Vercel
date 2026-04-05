
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseAbuseBlockHistoryItemVariant4RouteVariant2MitigateAction
    {
        /// <summary>
        /// 
        /// </summary>
        BlockLegalCwc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateMicrofrontendsResponseAbuseBlockHistoryItemVariant4RouteVariant2MitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseAbuseBlockHistoryItemVariant4RouteVariant2MitigateAction value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseAbuseBlockHistoryItemVariant4RouteVariant2MitigateAction.BlockLegalCwc => "block_legal_cwc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseAbuseBlockHistoryItemVariant4RouteVariant2MitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "block_legal_cwc" => UpdateMicrofrontendsResponseAbuseBlockHistoryItemVariant4RouteVariant2MitigateAction.BlockLegalCwc,
                _ => null,
            };
        }
    }
}