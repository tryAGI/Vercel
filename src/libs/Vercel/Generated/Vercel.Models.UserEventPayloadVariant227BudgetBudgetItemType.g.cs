
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The budget type
    /// </summary>
    public enum UserEventPayloadVariant227BudgetBudgetItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Fixed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant227BudgetBudgetItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant227BudgetBudgetItemType value)
        {
            return value switch
            {
                UserEventPayloadVariant227BudgetBudgetItemType.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant227BudgetBudgetItemType? ToEnum(string value)
        {
            return value switch
            {
                "fixed" => UserEventPayloadVariant227BudgetBudgetItemType.Fixed,
                _ => null,
            };
        }
    }
}