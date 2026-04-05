
#nullable enable

namespace Vercel
{
    /// <summary>
    /// \"after\"/\"before\" require referenceId.
    /// </summary>
    public enum AddRouteRequestPositionPlacement
    {
        /// <summary>
        /// 
        /// </summary>
        After,
        /// <summary>
        /// 
        /// </summary>
        Before,
        /// <summary>
        /// 
        /// </summary>
        End,
        /// <summary>
        /// 
        /// </summary>
        Start,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AddRouteRequestPositionPlacementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddRouteRequestPositionPlacement value)
        {
            return value switch
            {
                AddRouteRequestPositionPlacement.After => "after",
                AddRouteRequestPositionPlacement.Before => "before",
                AddRouteRequestPositionPlacement.End => "end",
                AddRouteRequestPositionPlacement.Start => "start",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddRouteRequestPositionPlacement? ToEnum(string value)
        {
            return value switch
            {
                "after" => AddRouteRequestPositionPlacement.After,
                "before" => AddRouteRequestPositionPlacement.Before,
                "end" => AddRouteRequestPositionPlacement.End,
                "start" => AddRouteRequestPositionPlacement.Start,
                _ => null,
            };
        }
    }
}