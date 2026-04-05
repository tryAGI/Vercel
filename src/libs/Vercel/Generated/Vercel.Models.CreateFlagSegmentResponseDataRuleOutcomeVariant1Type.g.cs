
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFlagSegmentResponseDataRuleOutcomeVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateFlagSegmentResponseDataRuleOutcomeVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFlagSegmentResponseDataRuleOutcomeVariant1Type value)
        {
            return value switch
            {
                CreateFlagSegmentResponseDataRuleOutcomeVariant1Type.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFlagSegmentResponseDataRuleOutcomeVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "all" => CreateFlagSegmentResponseDataRuleOutcomeVariant1Type.All,
                _ => null,
            };
        }
    }
}