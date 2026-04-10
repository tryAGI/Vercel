
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The budget type
    /// </summary>
    public enum UserEventPayloadVariant228BudgetBudgetItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Fixed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant228BudgetBudgetItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant228BudgetBudgetItemType value)
        {
            return value switch
            {
                UserEventPayloadVariant228BudgetBudgetItemType.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant228BudgetBudgetItemType? ToEnum(string value)
        {
            return value switch
            {
                "fixed" => UserEventPayloadVariant228BudgetBudgetItemType.Fixed,
                _ => null,
            };
        }
    }
}