
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFlagSegmentResponseDataRuleConditionRhsVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        Regex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateFlagSegmentResponseDataRuleConditionRhsVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFlagSegmentResponseDataRuleConditionRhsVariant4Type value)
        {
            return value switch
            {
                CreateFlagSegmentResponseDataRuleConditionRhsVariant4Type.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFlagSegmentResponseDataRuleConditionRhsVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "regex" => CreateFlagSegmentResponseDataRuleConditionRhsVariant4Type.Regex,
                _ => null,
            };
        }
    }
}