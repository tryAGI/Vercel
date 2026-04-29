
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant46Action
    {
        /// <summary>
        /// 
        /// </summary>
        ResumePlan,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant46ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant46Action value)
        {
            return value switch
            {
                UserEventPayloadVariant46Action.ResumePlan => "resume_plan",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant46Action? ToEnum(string value)
        {
            return value switch
            {
                "resume_plan" => UserEventPayloadVariant46Action.ResumePlan,
                _ => null,
            };
        }
    }
}