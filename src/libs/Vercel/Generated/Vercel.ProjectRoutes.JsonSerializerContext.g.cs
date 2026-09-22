
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.GetRoutesResponseVariant2RouteRouteMissingItemVariant1, global::Vercel.GetRoutesResponseVariant2RouteRouteMissingItemVariant2>?), TypeInfoPropertyName = "GetRoutesResponseVariant2RouteRouteMissingItemVariant2_b959e95b8c7859e1")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.GetRoutesResponseVariant3RouteRouteMissingItemVariant1, global::Vercel.GetRoutesResponseVariant3RouteRouteMissingItemVariant2>?), TypeInfoPropertyName = "GetRoutesResponseVariant3RouteRouteMissingItemVariant2_4f8710a39ac31699")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.GetRoutesResponseVariant4RouteRouteMissingItemVariant1, global::Vercel.GetRoutesResponseVariant4RouteRouteMissingItemVariant2>?), TypeInfoPropertyName = "GetRoutesResponseVariant4RouteRouteMissingItemVariant2_c204434331ddbedc")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, double?>), TypeInfoPropertyName = "OneOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StageRoutesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.StageRoutesRequestRoute>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StageRoutesRequestRoute))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StageRoutesRequestRouteRoute))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.StageRoutesRequestRouteRouteHa>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StageRoutesRequestRouteRouteHa))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StageRoutesRequestRouteRouteHaType), TypeInfoPropertyName = "StageRoutesRequestRouteRouteHaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.StageRoutesRequestRouteRouteMissingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StageRoutesRequestRouteRouteMissingItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StageRoutesRequestRouteRouteMissingItemType), TypeInfoPropertyName = "StageRoutesRequestRouteRouteMissingItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.StageRoutesRequestRouteRouteTransform>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StageRoutesRequestRouteRouteTransform))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StageRoutesRequestRouteRouteTransformType), TypeInfoPropertyName = "StageRoutesRequestRouteRouteTransformType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StageRoutesRequestRouteRouteTransformOp), TypeInfoPropertyName = "StageRoutesRequestRouteRouteTransformOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteRequestRoute))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteRequestRouteSrcSyntax), TypeInfoPropertyName = "AddRouteRequestRouteSrcSyntax2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteRequestRouteRoute))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.AddRouteRequestRouteRouteHa>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteRequestRouteRouteHa))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteRequestRouteRouteHaType), TypeInfoPropertyName = "AddRouteRequestRouteRouteHaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.AddRouteRequestRouteRouteMissingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteRequestRouteRouteMissingItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteRequestRouteRouteMissingItemType), TypeInfoPropertyName = "AddRouteRequestRouteRouteMissingItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.AddRouteRequestRouteRouteTransform>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteRequestRouteRouteTransform))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteRequestRouteRouteTransformType), TypeInfoPropertyName = "AddRouteRequestRouteRouteTransformType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteRequestRouteRouteTransformOp), TypeInfoPropertyName = "AddRouteRequestRouteRouteTransformOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteRequestPosition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteRequestPositionPlacement), TypeInfoPropertyName = "AddRouteRequestPositionPlacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DeleteRoutesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteRequestRoute))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteRequestRouteSrcSyntax), TypeInfoPropertyName = "EditRouteRequestRouteSrcSyntax2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteRequestRouteRoute))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.EditRouteRequestRouteRouteHa>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteRequestRouteRouteHa))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteRequestRouteRouteHaType), TypeInfoPropertyName = "EditRouteRequestRouteRouteHaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.EditRouteRequestRouteRouteMissingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteRequestRouteRouteMissingItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteRequestRouteRouteMissingItemType), TypeInfoPropertyName = "EditRouteRequestRouteRouteMissingItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.EditRouteRequestRouteRouteTransform>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteRequestRouteRouteTransform))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteRequestRouteRouteTransformType), TypeInfoPropertyName = "EditRouteRequestRouteRouteTransformType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteRequestRouteRouteTransformOp), TypeInfoPropertyName = "EditRouteRequestRouteRouteTransformOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteRequestCurrentRoute))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteRequestCurrentRoutePathCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GenerateRouteRequestCurrentRouteCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteRequestCurrentRouteCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GenerateRouteRequestCurrentRouteAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteRequestCurrentRouteAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GenerateRouteRequestCurrentRouteActionHeader>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteRequestCurrentRouteActionHeader))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateRouteVersionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateRouteVersionsRequestAction), TypeInfoPropertyName = "UpdateRouteVersionsRequestAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "OneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesFilter), TypeInfoPropertyName = "GetRoutesFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<bool?, global::Vercel.GetRoutesDiff2?>), TypeInfoPropertyName = "OneOfBooleanGetRoutesDiff22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesDiff2), TypeInfoPropertyName = "GetRoutesDiff22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<object, global::Vercel.GetRoutesResponseVariant2, global::Vercel.GetRoutesResponseVariant3, global::Vercel.GetRoutesResponseVariant4>), TypeInfoPropertyName = "OneOfObjectGetRoutesResponseVariant2GetRoutesResponseVariant3GetRoutesResponseVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GetRoutesResponseVariant2Route>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2Route))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2RouteRoute))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.GetRoutesResponseVariant2RouteRouteDestination>), TypeInfoPropertyName = "OneOfStringGetRoutesResponseVariant2RouteRouteDestination2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteDestination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteDestinationType), TypeInfoPropertyName = "GetRoutesResponseVariant2RouteRouteDestinationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetRoutesResponseVariant2RouteRouteHaVariant1, global::Vercel.GetRoutesResponseVariant2RouteRouteHaVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.GetRoutesResponseVariant2RouteRouteHaVariant1, global::Vercel.GetRoutesResponseVariant2RouteRouteHaVariant2>), TypeInfoPropertyName = "OneOfGetRoutesResponseVariant2RouteRouteHaVariant1GetRoutesResponseVariant2RouteRouteHaVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteHaVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteHaVariant1Type), TypeInfoPropertyName = "GetRoutesResponseVariant2RouteRouteHaVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.GetRoutesResponseVariant2RouteRouteHaVariant1Value>), TypeInfoPropertyName = "OneOfStringGetRoutesResponseVariant2RouteRouteHaVariant1Value2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteHaVariant1Value))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteHaVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteHaVariant2Type), TypeInfoPropertyName = "GetRoutesResponseVariant2RouteRouteHaVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.GetRoutesResponseVariant2RouteRouteHaVariant2Value>), TypeInfoPropertyName = "OneOfStringGetRoutesResponseVariant2RouteRouteHaVariant2Value2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteHaVariant2Value))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteLocale))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetRoutesResponseVariant2RouteRouteMissingItemVariant1, global::Vercel.GetRoutesResponseVariant2RouteRouteMissingItemVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.GetRoutesResponseVariant2RouteRouteMissingItemVariant1, global::Vercel.GetRoutesResponseVariant2RouteRouteMissingItemVariant2>), TypeInfoPropertyName = "OneOfGetRoutesResponseVariant2RouteRouteMissingItemVariant1GetRoutesResponseVariant2RouteRouteMissingItemVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteMissingItemVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteMissingItemVariant1Type), TypeInfoPropertyName = "GetRoutesResponseVariant2RouteRouteMissingItemVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.GetRoutesResponseVariant2RouteRouteMissingItemVariant1Value>), TypeInfoPropertyName = "OneOfStringGetRoutesResponseVariant2RouteRouteMissingItemVariant1Value2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteMissingItemVariant1Value))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteMissingItemVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteMissingItemVariant2Type), TypeInfoPropertyName = "GetRoutesResponseVariant2RouteRouteMissingItemVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.GetRoutesResponseVariant2RouteRouteMissingItemVariant2Value>), TypeInfoPropertyName = "OneOfStringGetRoutesResponseVariant2RouteRouteMissingItemVariant2Value2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteMissingItemVariant2Value))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteMitigate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteMitigateAction), TypeInfoPropertyName = "GetRoutesResponseVariant2RouteRouteMitigateAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetRoutesResponseVariant2RouteRouteTransformVariant1, global::Vercel.GetRoutesResponseVariant2RouteRouteTransformVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.GetRoutesResponseVariant2RouteRouteTransformVariant1, global::Vercel.GetRoutesResponseVariant2RouteRouteTransformVariant2>), TypeInfoPropertyName = "OneOfGetRoutesResponseVariant2RouteRouteTransformVariant1GetRoutesResponseVariant2RouteRouteTransformVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteTransformVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteTransformVariant1Op), TypeInfoPropertyName = "GetRoutesResponseVariant2RouteRouteTransformVariant1Op2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteTransformVariant1Target))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.GetRoutesResponseVariant2RouteRouteTransformVariant1TargetKey>), TypeInfoPropertyName = "OneOfStringGetRoutesResponseVariant2RouteRouteTransformVariant1TargetKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteTransformVariant1TargetKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteTransformVariant1Type), TypeInfoPropertyName = "GetRoutesResponseVariant2RouteRouteTransformVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteTransformVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteTransformVariant2Op), TypeInfoPropertyName = "GetRoutesResponseVariant2RouteRouteTransformVariant2Op2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteTransformVariant2Type), TypeInfoPropertyName = "GetRoutesResponseVariant2RouteRouteTransformVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteType), TypeInfoPropertyName = "GetRoutesResponseVariant2RouteRouteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2RouteSrcSyntax), TypeInfoPropertyName = "GetRoutesResponseVariant2RouteSrcSyntax2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2Version))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GetRoutesResponseVariant3Route>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3Route))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3RouteRoute))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.GetRoutesResponseVariant3RouteRouteDestination>), TypeInfoPropertyName = "OneOfStringGetRoutesResponseVariant3RouteRouteDestination2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteDestination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteDestinationType), TypeInfoPropertyName = "GetRoutesResponseVariant3RouteRouteDestinationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetRoutesResponseVariant3RouteRouteHaVariant1, global::Vercel.GetRoutesResponseVariant3RouteRouteHaVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.GetRoutesResponseVariant3RouteRouteHaVariant1, global::Vercel.GetRoutesResponseVariant3RouteRouteHaVariant2>), TypeInfoPropertyName = "OneOfGetRoutesResponseVariant3RouteRouteHaVariant1GetRoutesResponseVariant3RouteRouteHaVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteHaVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteHaVariant1Type), TypeInfoPropertyName = "GetRoutesResponseVariant3RouteRouteHaVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.GetRoutesResponseVariant3RouteRouteHaVariant1Value>), TypeInfoPropertyName = "OneOfStringGetRoutesResponseVariant3RouteRouteHaVariant1Value2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteHaVariant1Value))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteHaVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteHaVariant2Type), TypeInfoPropertyName = "GetRoutesResponseVariant3RouteRouteHaVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.GetRoutesResponseVariant3RouteRouteHaVariant2Value>), TypeInfoPropertyName = "OneOfStringGetRoutesResponseVariant3RouteRouteHaVariant2Value2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteHaVariant2Value))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteLocale))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetRoutesResponseVariant3RouteRouteMissingItemVariant1, global::Vercel.GetRoutesResponseVariant3RouteRouteMissingItemVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.GetRoutesResponseVariant3RouteRouteMissingItemVariant1, global::Vercel.GetRoutesResponseVariant3RouteRouteMissingItemVariant2>), TypeInfoPropertyName = "OneOfGetRoutesResponseVariant3RouteRouteMissingItemVariant1GetRoutesResponseVariant3RouteRouteMissingItemVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteMissingItemVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteMissingItemVariant1Type), TypeInfoPropertyName = "GetRoutesResponseVariant3RouteRouteMissingItemVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.GetRoutesResponseVariant3RouteRouteMissingItemVariant1Value>), TypeInfoPropertyName = "OneOfStringGetRoutesResponseVariant3RouteRouteMissingItemVariant1Value2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteMissingItemVariant1Value))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteMissingItemVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteMissingItemVariant2Type), TypeInfoPropertyName = "GetRoutesResponseVariant3RouteRouteMissingItemVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.GetRoutesResponseVariant3RouteRouteMissingItemVariant2Value>), TypeInfoPropertyName = "OneOfStringGetRoutesResponseVariant3RouteRouteMissingItemVariant2Value2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteMissingItemVariant2Value))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteMitigate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteMitigateAction), TypeInfoPropertyName = "GetRoutesResponseVariant3RouteRouteMitigateAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant1, global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant1, global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant2>), TypeInfoPropertyName = "OneOfGetRoutesResponseVariant3RouteRouteTransformVariant1GetRoutesResponseVariant3RouteRouteTransformVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant1Op), TypeInfoPropertyName = "GetRoutesResponseVariant3RouteRouteTransformVariant1Op2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant1Target))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant1TargetKey>), TypeInfoPropertyName = "OneOfStringGetRoutesResponseVariant3RouteRouteTransformVariant1TargetKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant1TargetKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant1Type), TypeInfoPropertyName = "GetRoutesResponseVariant3RouteRouteTransformVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant2Op), TypeInfoPropertyName = "GetRoutesResponseVariant3RouteRouteTransformVariant2Op2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant2Type), TypeInfoPropertyName = "GetRoutesResponseVariant3RouteRouteTransformVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteType), TypeInfoPropertyName = "GetRoutesResponseVariant3RouteRouteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3RouteSrcSyntax), TypeInfoPropertyName = "GetRoutesResponseVariant3RouteSrcSyntax2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3Version))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4Limit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GetRoutesResponseVariant4Route>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4Route))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4RouteRoute))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.GetRoutesResponseVariant4RouteRouteDestination>), TypeInfoPropertyName = "OneOfStringGetRoutesResponseVariant4RouteRouteDestination2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteDestination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteDestinationType), TypeInfoPropertyName = "GetRoutesResponseVariant4RouteRouteDestinationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetRoutesResponseVariant4RouteRouteHaVariant1, global::Vercel.GetRoutesResponseVariant4RouteRouteHaVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.GetRoutesResponseVariant4RouteRouteHaVariant1, global::Vercel.GetRoutesResponseVariant4RouteRouteHaVariant2>), TypeInfoPropertyName = "OneOfGetRoutesResponseVariant4RouteRouteHaVariant1GetRoutesResponseVariant4RouteRouteHaVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteHaVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteHaVariant1Type), TypeInfoPropertyName = "GetRoutesResponseVariant4RouteRouteHaVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.GetRoutesResponseVariant4RouteRouteHaVariant1Value>), TypeInfoPropertyName = "OneOfStringGetRoutesResponseVariant4RouteRouteHaVariant1Value2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteHaVariant1Value))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteHaVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteHaVariant2Type), TypeInfoPropertyName = "GetRoutesResponseVariant4RouteRouteHaVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.GetRoutesResponseVariant4RouteRouteHaVariant2Value>), TypeInfoPropertyName = "OneOfStringGetRoutesResponseVariant4RouteRouteHaVariant2Value2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteHaVariant2Value))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteLocale))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetRoutesResponseVariant4RouteRouteMissingItemVariant1, global::Vercel.GetRoutesResponseVariant4RouteRouteMissingItemVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.GetRoutesResponseVariant4RouteRouteMissingItemVariant1, global::Vercel.GetRoutesResponseVariant4RouteRouteMissingItemVariant2>), TypeInfoPropertyName = "OneOfGetRoutesResponseVariant4RouteRouteMissingItemVariant1GetRoutesResponseVariant4RouteRouteMissingItemVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteMissingItemVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteMissingItemVariant1Type), TypeInfoPropertyName = "GetRoutesResponseVariant4RouteRouteMissingItemVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.GetRoutesResponseVariant4RouteRouteMissingItemVariant1Value>), TypeInfoPropertyName = "OneOfStringGetRoutesResponseVariant4RouteRouteMissingItemVariant1Value2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteMissingItemVariant1Value))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteMissingItemVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteMissingItemVariant2Type), TypeInfoPropertyName = "GetRoutesResponseVariant4RouteRouteMissingItemVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.GetRoutesResponseVariant4RouteRouteMissingItemVariant2Value>), TypeInfoPropertyName = "OneOfStringGetRoutesResponseVariant4RouteRouteMissingItemVariant2Value2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteMissingItemVariant2Value))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteMitigate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteMitigateAction), TypeInfoPropertyName = "GetRoutesResponseVariant4RouteRouteMitigateAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant1, global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant1, global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant2>), TypeInfoPropertyName = "OneOfGetRoutesResponseVariant4RouteRouteTransformVariant1GetRoutesResponseVariant4RouteRouteTransformVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant1Op), TypeInfoPropertyName = "GetRoutesResponseVariant4RouteRouteTransformVariant1Op2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant1Target))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant1TargetKey>), TypeInfoPropertyName = "OneOfStringGetRoutesResponseVariant4RouteRouteTransformVariant1TargetKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant1TargetKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant1Type), TypeInfoPropertyName = "GetRoutesResponseVariant4RouteRouteTransformVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant2Op), TypeInfoPropertyName = "GetRoutesResponseVariant4RouteRouteTransformVariant2Op2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant2Type), TypeInfoPropertyName = "GetRoutesResponseVariant4RouteRouteTransformVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteType), TypeInfoPropertyName = "GetRoutesResponseVariant4RouteRouteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4RouteSrcSyntax), TypeInfoPropertyName = "GetRoutesResponseVariant4RouteSrcSyntax2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4Version))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StageRoutesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StageRoutesResponseVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseRoute))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseRouteRoute))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.AddRouteResponseRouteRouteDestination>), TypeInfoPropertyName = "OneOfStringAddRouteResponseRouteRouteDestination2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseRouteRouteDestination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseRouteRouteDestinationType), TypeInfoPropertyName = "AddRouteResponseRouteRouteDestinationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.AddRouteResponseRouteRouteHaVariant1, global::Vercel.AddRouteResponseRouteRouteHaVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.AddRouteResponseRouteRouteHaVariant1, global::Vercel.AddRouteResponseRouteRouteHaVariant2>), TypeInfoPropertyName = "OneOfAddRouteResponseRouteRouteHaVariant1AddRouteResponseRouteRouteHaVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseRouteRouteHaVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseRouteRouteHaVariant1Type), TypeInfoPropertyName = "AddRouteResponseRouteRouteHaVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.AddRouteResponseRouteRouteHaVariant1Value>), TypeInfoPropertyName = "OneOfStringAddRouteResponseRouteRouteHaVariant1Value2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseRouteRouteHaVariant1Value))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseRouteRouteHaVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseRouteRouteHaVariant2Type), TypeInfoPropertyName = "AddRouteResponseRouteRouteHaVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.AddRouteResponseRouteRouteHaVariant2Value>), TypeInfoPropertyName = "OneOfStringAddRouteResponseRouteRouteHaVariant2Value2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseRouteRouteHaVariant2Value))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseRouteRouteLocale))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.AddRouteResponseRouteRouteMissingItemVariant1, global::Vercel.AddRouteResponseRouteRouteMissingItemVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.AddRouteResponseRouteRouteMissingItemVariant1, global::Vercel.AddRouteResponseRouteRouteMissingItemVariant2>), TypeInfoPropertyName = "OneOfAddRouteResponseRouteRouteMissingItemVariant1AddRouteResponseRouteRouteMissingItemVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseRouteRouteMissingItemVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseRouteRouteMissingItemVariant1Type), TypeInfoPropertyName = "AddRouteResponseRouteRouteMissingItemVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.AddRouteResponseRouteRouteMissingItemVariant1Value>), TypeInfoPropertyName = "OneOfStringAddRouteResponseRouteRouteMissingItemVariant1Value2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseRouteRouteMissingItemVariant1Value))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseRouteRouteMissingItemVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseRouteRouteMissingItemVariant2Type), TypeInfoPropertyName = "AddRouteResponseRouteRouteMissingItemVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.AddRouteResponseRouteRouteMissingItemVariant2Value>), TypeInfoPropertyName = "OneOfStringAddRouteResponseRouteRouteMissingItemVariant2Value2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseRouteRouteMissingItemVariant2Value))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseRouteRouteMitigate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseRouteRouteMitigateAction), TypeInfoPropertyName = "AddRouteResponseRouteRouteMitigateAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.AddRouteResponseRouteRouteTransformVariant1, global::Vercel.AddRouteResponseRouteRouteTransformVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.AddRouteResponseRouteRouteTransformVariant1, global::Vercel.AddRouteResponseRouteRouteTransformVariant2>), TypeInfoPropertyName = "OneOfAddRouteResponseRouteRouteTransformVariant1AddRouteResponseRouteRouteTransformVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseRouteRouteTransformVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseRouteRouteTransformVariant1Op), TypeInfoPropertyName = "AddRouteResponseRouteRouteTransformVariant1Op2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseRouteRouteTransformVariant1Target))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.AddRouteResponseRouteRouteTransformVariant1TargetKey>), TypeInfoPropertyName = "OneOfStringAddRouteResponseRouteRouteTransformVariant1TargetKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseRouteRouteTransformVariant1TargetKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseRouteRouteTransformVariant1Type), TypeInfoPropertyName = "AddRouteResponseRouteRouteTransformVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseRouteRouteTransformVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseRouteRouteTransformVariant2Op), TypeInfoPropertyName = "AddRouteResponseRouteRouteTransformVariant2Op2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseRouteRouteTransformVariant2Type), TypeInfoPropertyName = "AddRouteResponseRouteRouteTransformVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseRouteRouteType), TypeInfoPropertyName = "AddRouteResponseRouteRouteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseRouteSrcSyntax), TypeInfoPropertyName = "AddRouteResponseRouteSrcSyntax2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DeleteRoutesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DeleteRoutesResponseVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseRoute))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseRouteRoute))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.EditRouteResponseRouteRouteDestination>), TypeInfoPropertyName = "OneOfStringEditRouteResponseRouteRouteDestination2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseRouteRouteDestination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseRouteRouteDestinationType), TypeInfoPropertyName = "EditRouteResponseRouteRouteDestinationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.EditRouteResponseRouteRouteHaVariant1, global::Vercel.EditRouteResponseRouteRouteHaVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.EditRouteResponseRouteRouteHaVariant1, global::Vercel.EditRouteResponseRouteRouteHaVariant2>), TypeInfoPropertyName = "OneOfEditRouteResponseRouteRouteHaVariant1EditRouteResponseRouteRouteHaVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseRouteRouteHaVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseRouteRouteHaVariant1Type), TypeInfoPropertyName = "EditRouteResponseRouteRouteHaVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.EditRouteResponseRouteRouteHaVariant1Value>), TypeInfoPropertyName = "OneOfStringEditRouteResponseRouteRouteHaVariant1Value2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseRouteRouteHaVariant1Value))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseRouteRouteHaVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseRouteRouteHaVariant2Type), TypeInfoPropertyName = "EditRouteResponseRouteRouteHaVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.EditRouteResponseRouteRouteHaVariant2Value>), TypeInfoPropertyName = "OneOfStringEditRouteResponseRouteRouteHaVariant2Value2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseRouteRouteHaVariant2Value))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseRouteRouteLocale))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.EditRouteResponseRouteRouteMissingItemVariant1, global::Vercel.EditRouteResponseRouteRouteMissingItemVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.EditRouteResponseRouteRouteMissingItemVariant1, global::Vercel.EditRouteResponseRouteRouteMissingItemVariant2>), TypeInfoPropertyName = "OneOfEditRouteResponseRouteRouteMissingItemVariant1EditRouteResponseRouteRouteMissingItemVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseRouteRouteMissingItemVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseRouteRouteMissingItemVariant1Type), TypeInfoPropertyName = "EditRouteResponseRouteRouteMissingItemVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.EditRouteResponseRouteRouteMissingItemVariant1Value>), TypeInfoPropertyName = "OneOfStringEditRouteResponseRouteRouteMissingItemVariant1Value2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseRouteRouteMissingItemVariant1Value))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseRouteRouteMissingItemVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseRouteRouteMissingItemVariant2Type), TypeInfoPropertyName = "EditRouteResponseRouteRouteMissingItemVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.EditRouteResponseRouteRouteMissingItemVariant2Value>), TypeInfoPropertyName = "OneOfStringEditRouteResponseRouteRouteMissingItemVariant2Value2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseRouteRouteMissingItemVariant2Value))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseRouteRouteMitigate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseRouteRouteMitigateAction), TypeInfoPropertyName = "EditRouteResponseRouteRouteMitigateAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.EditRouteResponseRouteRouteTransformVariant1, global::Vercel.EditRouteResponseRouteRouteTransformVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.EditRouteResponseRouteRouteTransformVariant1, global::Vercel.EditRouteResponseRouteRouteTransformVariant2>), TypeInfoPropertyName = "OneOfEditRouteResponseRouteRouteTransformVariant1EditRouteResponseRouteRouteTransformVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseRouteRouteTransformVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseRouteRouteTransformVariant1Op), TypeInfoPropertyName = "EditRouteResponseRouteRouteTransformVariant1Op2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseRouteRouteTransformVariant1Target))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.EditRouteResponseRouteRouteTransformVariant1TargetKey>), TypeInfoPropertyName = "OneOfStringEditRouteResponseRouteRouteTransformVariant1TargetKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseRouteRouteTransformVariant1TargetKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseRouteRouteTransformVariant1Type), TypeInfoPropertyName = "EditRouteResponseRouteRouteTransformVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseRouteRouteTransformVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseRouteRouteTransformVariant2Op), TypeInfoPropertyName = "EditRouteResponseRouteRouteTransformVariant2Op2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseRouteRouteTransformVariant2Type), TypeInfoPropertyName = "EditRouteResponseRouteRouteTransformVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseRouteRouteType), TypeInfoPropertyName = "EditRouteResponseRouteRouteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseRouteSrcSyntax), TypeInfoPropertyName = "EditRouteResponseRouteSrcSyntax2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteResponseRoute))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GenerateRouteResponseRouteAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteResponseRouteAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GenerateRouteResponseRouteActionHeader>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteResponseRouteActionHeader))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteResponseRouteActionHeaderOp), TypeInfoPropertyName = "GenerateRouteResponseRouteActionHeaderOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteResponseRouteActionSubType), TypeInfoPropertyName = "GenerateRouteResponseRouteActionSubType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteResponseRouteActionType), TypeInfoPropertyName = "GenerateRouteResponseRouteActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GenerateRouteResponseRouteCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteResponseRouteCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteResponseRouteConditionField), TypeInfoPropertyName = "GenerateRouteResponseRouteConditionField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteResponseRouteConditionOperator), TypeInfoPropertyName = "GenerateRouteResponseRouteConditionOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteResponseRoutePathCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteResponseRoutePathConditionSyntax), TypeInfoPropertyName = "GenerateRouteResponseRoutePathConditionSyntax2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRouteVersionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GetRouteVersionsResponseVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRouteVersionsResponseVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateRouteVersionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateRouteVersionsResponseVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, double?>?), TypeInfoPropertyName = "NullableOneOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StageRoutesRequestRouteRouteHaType?), TypeInfoPropertyName = "NullableStageRoutesRequestRouteRouteHaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StageRoutesRequestRouteRouteMissingItemType?), TypeInfoPropertyName = "NullableStageRoutesRequestRouteRouteMissingItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StageRoutesRequestRouteRouteTransformType?), TypeInfoPropertyName = "NullableStageRoutesRequestRouteRouteTransformType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StageRoutesRequestRouteRouteTransformOp?), TypeInfoPropertyName = "NullableStageRoutesRequestRouteRouteTransformOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteRequestRouteSrcSyntax?), TypeInfoPropertyName = "NullableAddRouteRequestRouteSrcSyntax2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteRequestRouteRouteHaType?), TypeInfoPropertyName = "NullableAddRouteRequestRouteRouteHaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteRequestRouteRouteMissingItemType?), TypeInfoPropertyName = "NullableAddRouteRequestRouteRouteMissingItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteRequestRouteRouteTransformType?), TypeInfoPropertyName = "NullableAddRouteRequestRouteRouteTransformType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteRequestRouteRouteTransformOp?), TypeInfoPropertyName = "NullableAddRouteRequestRouteRouteTransformOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteRequestPositionPlacement?), TypeInfoPropertyName = "NullableAddRouteRequestPositionPlacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteRequestRouteSrcSyntax?), TypeInfoPropertyName = "NullableEditRouteRequestRouteSrcSyntax2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteRequestRouteRouteHaType?), TypeInfoPropertyName = "NullableEditRouteRequestRouteRouteHaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteRequestRouteRouteMissingItemType?), TypeInfoPropertyName = "NullableEditRouteRequestRouteRouteMissingItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteRequestRouteRouteTransformType?), TypeInfoPropertyName = "NullableEditRouteRequestRouteRouteTransformType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteRequestRouteRouteTransformOp?), TypeInfoPropertyName = "NullableEditRouteRequestRouteRouteTransformOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateRouteVersionsRequestAction?), TypeInfoPropertyName = "NullableUpdateRouteVersionsRequestAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableOneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesFilter?), TypeInfoPropertyName = "NullableGetRoutesFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<bool?, global::Vercel.GetRoutesDiff2?>?), TypeInfoPropertyName = "NullableOneOfBooleanGetRoutesDiff22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesDiff2?), TypeInfoPropertyName = "NullableGetRoutesDiff22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<object, global::Vercel.GetRoutesResponseVariant2, global::Vercel.GetRoutesResponseVariant3, global::Vercel.GetRoutesResponseVariant4>?), TypeInfoPropertyName = "NullableOneOfObjectGetRoutesResponseVariant2GetRoutesResponseVariant3GetRoutesResponseVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.GetRoutesResponseVariant2RouteRouteDestination>?), TypeInfoPropertyName = "NullableOneOfStringGetRoutesResponseVariant2RouteRouteDestination2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteDestinationType?), TypeInfoPropertyName = "NullableGetRoutesResponseVariant2RouteRouteDestinationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.GetRoutesResponseVariant2RouteRouteHaVariant1, global::Vercel.GetRoutesResponseVariant2RouteRouteHaVariant2>?), TypeInfoPropertyName = "NullableOneOfGetRoutesResponseVariant2RouteRouteHaVariant1GetRoutesResponseVariant2RouteRouteHaVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteHaVariant1Type?), TypeInfoPropertyName = "NullableGetRoutesResponseVariant2RouteRouteHaVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.GetRoutesResponseVariant2RouteRouteHaVariant1Value>?), TypeInfoPropertyName = "NullableOneOfStringGetRoutesResponseVariant2RouteRouteHaVariant1Value2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteHaVariant2Type?), TypeInfoPropertyName = "NullableGetRoutesResponseVariant2RouteRouteHaVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.GetRoutesResponseVariant2RouteRouteHaVariant2Value>?), TypeInfoPropertyName = "NullableOneOfStringGetRoutesResponseVariant2RouteRouteHaVariant2Value2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteMissingItemVariant1Type?), TypeInfoPropertyName = "NullableGetRoutesResponseVariant2RouteRouteMissingItemVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.GetRoutesResponseVariant2RouteRouteMissingItemVariant1Value>?), TypeInfoPropertyName = "NullableOneOfStringGetRoutesResponseVariant2RouteRouteMissingItemVariant1Value2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteMissingItemVariant2Type?), TypeInfoPropertyName = "NullableGetRoutesResponseVariant2RouteRouteMissingItemVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.GetRoutesResponseVariant2RouteRouteMissingItemVariant2Value>?), TypeInfoPropertyName = "NullableOneOfStringGetRoutesResponseVariant2RouteRouteMissingItemVariant2Value2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteMitigateAction?), TypeInfoPropertyName = "NullableGetRoutesResponseVariant2RouteRouteMitigateAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.GetRoutesResponseVariant2RouteRouteTransformVariant1, global::Vercel.GetRoutesResponseVariant2RouteRouteTransformVariant2>?), TypeInfoPropertyName = "NullableOneOfGetRoutesResponseVariant2RouteRouteTransformVariant1GetRoutesResponseVariant2RouteRouteTransformVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteTransformVariant1Op?), TypeInfoPropertyName = "NullableGetRoutesResponseVariant2RouteRouteTransformVariant1Op2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.GetRoutesResponseVariant2RouteRouteTransformVariant1TargetKey>?), TypeInfoPropertyName = "NullableOneOfStringGetRoutesResponseVariant2RouteRouteTransformVariant1TargetKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteTransformVariant1Type?), TypeInfoPropertyName = "NullableGetRoutesResponseVariant2RouteRouteTransformVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteTransformVariant2Op?), TypeInfoPropertyName = "NullableGetRoutesResponseVariant2RouteRouteTransformVariant2Op2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteTransformVariant2Type?), TypeInfoPropertyName = "NullableGetRoutesResponseVariant2RouteRouteTransformVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteType?), TypeInfoPropertyName = "NullableGetRoutesResponseVariant2RouteRouteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2RouteSrcSyntax?), TypeInfoPropertyName = "NullableGetRoutesResponseVariant2RouteSrcSyntax2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.GetRoutesResponseVariant3RouteRouteDestination>?), TypeInfoPropertyName = "NullableOneOfStringGetRoutesResponseVariant3RouteRouteDestination2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteDestinationType?), TypeInfoPropertyName = "NullableGetRoutesResponseVariant3RouteRouteDestinationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.GetRoutesResponseVariant3RouteRouteHaVariant1, global::Vercel.GetRoutesResponseVariant3RouteRouteHaVariant2>?), TypeInfoPropertyName = "NullableOneOfGetRoutesResponseVariant3RouteRouteHaVariant1GetRoutesResponseVariant3RouteRouteHaVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteHaVariant1Type?), TypeInfoPropertyName = "NullableGetRoutesResponseVariant3RouteRouteHaVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.GetRoutesResponseVariant3RouteRouteHaVariant1Value>?), TypeInfoPropertyName = "NullableOneOfStringGetRoutesResponseVariant3RouteRouteHaVariant1Value2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteHaVariant2Type?), TypeInfoPropertyName = "NullableGetRoutesResponseVariant3RouteRouteHaVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.GetRoutesResponseVariant3RouteRouteHaVariant2Value>?), TypeInfoPropertyName = "NullableOneOfStringGetRoutesResponseVariant3RouteRouteHaVariant2Value2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteMissingItemVariant1Type?), TypeInfoPropertyName = "NullableGetRoutesResponseVariant3RouteRouteMissingItemVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.GetRoutesResponseVariant3RouteRouteMissingItemVariant1Value>?), TypeInfoPropertyName = "NullableOneOfStringGetRoutesResponseVariant3RouteRouteMissingItemVariant1Value2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteMissingItemVariant2Type?), TypeInfoPropertyName = "NullableGetRoutesResponseVariant3RouteRouteMissingItemVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.GetRoutesResponseVariant3RouteRouteMissingItemVariant2Value>?), TypeInfoPropertyName = "NullableOneOfStringGetRoutesResponseVariant3RouteRouteMissingItemVariant2Value2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteMitigateAction?), TypeInfoPropertyName = "NullableGetRoutesResponseVariant3RouteRouteMitigateAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant1, global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant2>?), TypeInfoPropertyName = "NullableOneOfGetRoutesResponseVariant3RouteRouteTransformVariant1GetRoutesResponseVariant3RouteRouteTransformVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant1Op?), TypeInfoPropertyName = "NullableGetRoutesResponseVariant3RouteRouteTransformVariant1Op2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant1TargetKey>?), TypeInfoPropertyName = "NullableOneOfStringGetRoutesResponseVariant3RouteRouteTransformVariant1TargetKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant1Type?), TypeInfoPropertyName = "NullableGetRoutesResponseVariant3RouteRouteTransformVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant2Op?), TypeInfoPropertyName = "NullableGetRoutesResponseVariant3RouteRouteTransformVariant2Op2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant2Type?), TypeInfoPropertyName = "NullableGetRoutesResponseVariant3RouteRouteTransformVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteType?), TypeInfoPropertyName = "NullableGetRoutesResponseVariant3RouteRouteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3RouteSrcSyntax?), TypeInfoPropertyName = "NullableGetRoutesResponseVariant3RouteSrcSyntax2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.GetRoutesResponseVariant4RouteRouteDestination>?), TypeInfoPropertyName = "NullableOneOfStringGetRoutesResponseVariant4RouteRouteDestination2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteDestinationType?), TypeInfoPropertyName = "NullableGetRoutesResponseVariant4RouteRouteDestinationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.GetRoutesResponseVariant4RouteRouteHaVariant1, global::Vercel.GetRoutesResponseVariant4RouteRouteHaVariant2>?), TypeInfoPropertyName = "NullableOneOfGetRoutesResponseVariant4RouteRouteHaVariant1GetRoutesResponseVariant4RouteRouteHaVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteHaVariant1Type?), TypeInfoPropertyName = "NullableGetRoutesResponseVariant4RouteRouteHaVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.GetRoutesResponseVariant4RouteRouteHaVariant1Value>?), TypeInfoPropertyName = "NullableOneOfStringGetRoutesResponseVariant4RouteRouteHaVariant1Value2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteHaVariant2Type?), TypeInfoPropertyName = "NullableGetRoutesResponseVariant4RouteRouteHaVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.GetRoutesResponseVariant4RouteRouteHaVariant2Value>?), TypeInfoPropertyName = "NullableOneOfStringGetRoutesResponseVariant4RouteRouteHaVariant2Value2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteMissingItemVariant1Type?), TypeInfoPropertyName = "NullableGetRoutesResponseVariant4RouteRouteMissingItemVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.GetRoutesResponseVariant4RouteRouteMissingItemVariant1Value>?), TypeInfoPropertyName = "NullableOneOfStringGetRoutesResponseVariant4RouteRouteMissingItemVariant1Value2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteMissingItemVariant2Type?), TypeInfoPropertyName = "NullableGetRoutesResponseVariant4RouteRouteMissingItemVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.GetRoutesResponseVariant4RouteRouteMissingItemVariant2Value>?), TypeInfoPropertyName = "NullableOneOfStringGetRoutesResponseVariant4RouteRouteMissingItemVariant2Value2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteMitigateAction?), TypeInfoPropertyName = "NullableGetRoutesResponseVariant4RouteRouteMitigateAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant1, global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant2>?), TypeInfoPropertyName = "NullableOneOfGetRoutesResponseVariant4RouteRouteTransformVariant1GetRoutesResponseVariant4RouteRouteTransformVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant1Op?), TypeInfoPropertyName = "NullableGetRoutesResponseVariant4RouteRouteTransformVariant1Op2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant1TargetKey>?), TypeInfoPropertyName = "NullableOneOfStringGetRoutesResponseVariant4RouteRouteTransformVariant1TargetKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant1Type?), TypeInfoPropertyName = "NullableGetRoutesResponseVariant4RouteRouteTransformVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant2Op?), TypeInfoPropertyName = "NullableGetRoutesResponseVariant4RouteRouteTransformVariant2Op2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant2Type?), TypeInfoPropertyName = "NullableGetRoutesResponseVariant4RouteRouteTransformVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteType?), TypeInfoPropertyName = "NullableGetRoutesResponseVariant4RouteRouteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4RouteSrcSyntax?), TypeInfoPropertyName = "NullableGetRoutesResponseVariant4RouteSrcSyntax2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.AddRouteResponseRouteRouteDestination>?), TypeInfoPropertyName = "NullableOneOfStringAddRouteResponseRouteRouteDestination2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseRouteRouteDestinationType?), TypeInfoPropertyName = "NullableAddRouteResponseRouteRouteDestinationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.AddRouteResponseRouteRouteHaVariant1, global::Vercel.AddRouteResponseRouteRouteHaVariant2>?), TypeInfoPropertyName = "NullableOneOfAddRouteResponseRouteRouteHaVariant1AddRouteResponseRouteRouteHaVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseRouteRouteHaVariant1Type?), TypeInfoPropertyName = "NullableAddRouteResponseRouteRouteHaVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.AddRouteResponseRouteRouteHaVariant1Value>?), TypeInfoPropertyName = "NullableOneOfStringAddRouteResponseRouteRouteHaVariant1Value2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseRouteRouteHaVariant2Type?), TypeInfoPropertyName = "NullableAddRouteResponseRouteRouteHaVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.AddRouteResponseRouteRouteHaVariant2Value>?), TypeInfoPropertyName = "NullableOneOfStringAddRouteResponseRouteRouteHaVariant2Value2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.AddRouteResponseRouteRouteMissingItemVariant1, global::Vercel.AddRouteResponseRouteRouteMissingItemVariant2>?), TypeInfoPropertyName = "NullableOneOfAddRouteResponseRouteRouteMissingItemVariant1AddRouteResponseRouteRouteMissingItemVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseRouteRouteMissingItemVariant1Type?), TypeInfoPropertyName = "NullableAddRouteResponseRouteRouteMissingItemVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.AddRouteResponseRouteRouteMissingItemVariant1Value>?), TypeInfoPropertyName = "NullableOneOfStringAddRouteResponseRouteRouteMissingItemVariant1Value2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseRouteRouteMissingItemVariant2Type?), TypeInfoPropertyName = "NullableAddRouteResponseRouteRouteMissingItemVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.AddRouteResponseRouteRouteMissingItemVariant2Value>?), TypeInfoPropertyName = "NullableOneOfStringAddRouteResponseRouteRouteMissingItemVariant2Value2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseRouteRouteMitigateAction?), TypeInfoPropertyName = "NullableAddRouteResponseRouteRouteMitigateAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.AddRouteResponseRouteRouteTransformVariant1, global::Vercel.AddRouteResponseRouteRouteTransformVariant2>?), TypeInfoPropertyName = "NullableOneOfAddRouteResponseRouteRouteTransformVariant1AddRouteResponseRouteRouteTransformVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseRouteRouteTransformVariant1Op?), TypeInfoPropertyName = "NullableAddRouteResponseRouteRouteTransformVariant1Op2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.AddRouteResponseRouteRouteTransformVariant1TargetKey>?), TypeInfoPropertyName = "NullableOneOfStringAddRouteResponseRouteRouteTransformVariant1TargetKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseRouteRouteTransformVariant1Type?), TypeInfoPropertyName = "NullableAddRouteResponseRouteRouteTransformVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseRouteRouteTransformVariant2Op?), TypeInfoPropertyName = "NullableAddRouteResponseRouteRouteTransformVariant2Op2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseRouteRouteTransformVariant2Type?), TypeInfoPropertyName = "NullableAddRouteResponseRouteRouteTransformVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseRouteRouteType?), TypeInfoPropertyName = "NullableAddRouteResponseRouteRouteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseRouteSrcSyntax?), TypeInfoPropertyName = "NullableAddRouteResponseRouteSrcSyntax2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.EditRouteResponseRouteRouteDestination>?), TypeInfoPropertyName = "NullableOneOfStringEditRouteResponseRouteRouteDestination2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseRouteRouteDestinationType?), TypeInfoPropertyName = "NullableEditRouteResponseRouteRouteDestinationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.EditRouteResponseRouteRouteHaVariant1, global::Vercel.EditRouteResponseRouteRouteHaVariant2>?), TypeInfoPropertyName = "NullableOneOfEditRouteResponseRouteRouteHaVariant1EditRouteResponseRouteRouteHaVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseRouteRouteHaVariant1Type?), TypeInfoPropertyName = "NullableEditRouteResponseRouteRouteHaVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.EditRouteResponseRouteRouteHaVariant1Value>?), TypeInfoPropertyName = "NullableOneOfStringEditRouteResponseRouteRouteHaVariant1Value2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseRouteRouteHaVariant2Type?), TypeInfoPropertyName = "NullableEditRouteResponseRouteRouteHaVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.EditRouteResponseRouteRouteHaVariant2Value>?), TypeInfoPropertyName = "NullableOneOfStringEditRouteResponseRouteRouteHaVariant2Value2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.EditRouteResponseRouteRouteMissingItemVariant1, global::Vercel.EditRouteResponseRouteRouteMissingItemVariant2>?), TypeInfoPropertyName = "NullableOneOfEditRouteResponseRouteRouteMissingItemVariant1EditRouteResponseRouteRouteMissingItemVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseRouteRouteMissingItemVariant1Type?), TypeInfoPropertyName = "NullableEditRouteResponseRouteRouteMissingItemVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.EditRouteResponseRouteRouteMissingItemVariant1Value>?), TypeInfoPropertyName = "NullableOneOfStringEditRouteResponseRouteRouteMissingItemVariant1Value2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseRouteRouteMissingItemVariant2Type?), TypeInfoPropertyName = "NullableEditRouteResponseRouteRouteMissingItemVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.EditRouteResponseRouteRouteMissingItemVariant2Value>?), TypeInfoPropertyName = "NullableOneOfStringEditRouteResponseRouteRouteMissingItemVariant2Value2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseRouteRouteMitigateAction?), TypeInfoPropertyName = "NullableEditRouteResponseRouteRouteMitigateAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.EditRouteResponseRouteRouteTransformVariant1, global::Vercel.EditRouteResponseRouteRouteTransformVariant2>?), TypeInfoPropertyName = "NullableOneOfEditRouteResponseRouteRouteTransformVariant1EditRouteResponseRouteRouteTransformVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseRouteRouteTransformVariant1Op?), TypeInfoPropertyName = "NullableEditRouteResponseRouteRouteTransformVariant1Op2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.EditRouteResponseRouteRouteTransformVariant1TargetKey>?), TypeInfoPropertyName = "NullableOneOfStringEditRouteResponseRouteRouteTransformVariant1TargetKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseRouteRouteTransformVariant1Type?), TypeInfoPropertyName = "NullableEditRouteResponseRouteRouteTransformVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseRouteRouteTransformVariant2Op?), TypeInfoPropertyName = "NullableEditRouteResponseRouteRouteTransformVariant2Op2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseRouteRouteTransformVariant2Type?), TypeInfoPropertyName = "NullableEditRouteResponseRouteRouteTransformVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseRouteRouteType?), TypeInfoPropertyName = "NullableEditRouteResponseRouteRouteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseRouteSrcSyntax?), TypeInfoPropertyName = "NullableEditRouteResponseRouteSrcSyntax2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteResponseRouteActionHeaderOp?), TypeInfoPropertyName = "NullableGenerateRouteResponseRouteActionHeaderOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteResponseRouteActionSubType?), TypeInfoPropertyName = "NullableGenerateRouteResponseRouteActionSubType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteResponseRouteActionType?), TypeInfoPropertyName = "NullableGenerateRouteResponseRouteActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteResponseRouteConditionField?), TypeInfoPropertyName = "NullableGenerateRouteResponseRouteConditionField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteResponseRouteConditionOperator?), TypeInfoPropertyName = "NullableGenerateRouteResponseRouteConditionOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteResponseRoutePathConditionSyntax?), TypeInfoPropertyName = "NullableGenerateRouteResponseRoutePathConditionSyntax2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.StageRoutesRequestRoute>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.StageRoutesRequestRouteRouteHa>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.StageRoutesRequestRouteRouteMissingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.StageRoutesRequestRouteRouteTransform>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.AddRouteRequestRouteRouteHa>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.AddRouteRequestRouteRouteMissingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.AddRouteRequestRouteRouteTransform>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.EditRouteRequestRouteRouteHa>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.EditRouteRequestRouteRouteMissingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.EditRouteRequestRouteRouteTransform>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GenerateRouteRequestCurrentRouteCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GenerateRouteRequestCurrentRouteAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GenerateRouteRequestCurrentRouteActionHeader>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetRoutesResponseVariant2Route>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.OneOf<global::Vercel.GetRoutesResponseVariant2RouteRouteHaVariant1, global::Vercel.GetRoutesResponseVariant2RouteRouteHaVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.OneOf<global::Vercel.GetRoutesResponseVariant2RouteRouteMissingItemVariant1, global::Vercel.GetRoutesResponseVariant2RouteRouteMissingItemVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.OneOf<global::Vercel.GetRoutesResponseVariant2RouteRouteTransformVariant1, global::Vercel.GetRoutesResponseVariant2RouteRouteTransformVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetRoutesResponseVariant3Route>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.OneOf<global::Vercel.GetRoutesResponseVariant3RouteRouteHaVariant1, global::Vercel.GetRoutesResponseVariant3RouteRouteHaVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.OneOf<global::Vercel.GetRoutesResponseVariant3RouteRouteMissingItemVariant1, global::Vercel.GetRoutesResponseVariant3RouteRouteMissingItemVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.OneOf<global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant1, global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetRoutesResponseVariant4Route>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.OneOf<global::Vercel.GetRoutesResponseVariant4RouteRouteHaVariant1, global::Vercel.GetRoutesResponseVariant4RouteRouteHaVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.OneOf<global::Vercel.GetRoutesResponseVariant4RouteRouteMissingItemVariant1, global::Vercel.GetRoutesResponseVariant4RouteRouteMissingItemVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.OneOf<global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant1, global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.OneOf<global::Vercel.AddRouteResponseRouteRouteHaVariant1, global::Vercel.AddRouteResponseRouteRouteHaVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.OneOf<global::Vercel.AddRouteResponseRouteRouteMissingItemVariant1, global::Vercel.AddRouteResponseRouteRouteMissingItemVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.OneOf<global::Vercel.AddRouteResponseRouteRouteTransformVariant1, global::Vercel.AddRouteResponseRouteRouteTransformVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.OneOf<global::Vercel.EditRouteResponseRouteRouteHaVariant1, global::Vercel.EditRouteResponseRouteRouteHaVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.OneOf<global::Vercel.EditRouteResponseRouteRouteMissingItemVariant1, global::Vercel.EditRouteResponseRouteRouteMissingItemVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.OneOf<global::Vercel.EditRouteResponseRouteRouteTransformVariant1, global::Vercel.EditRouteResponseRouteRouteTransformVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GenerateRouteResponseRouteAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GenerateRouteResponseRouteActionHeader>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GenerateRouteResponseRouteCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetRouteVersionsResponseVersion>))]
    internal sealed partial class ProjectRoutesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectRoutesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ProjectRoutesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ProjectRoutesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, object, global::System.Collections.Generic.IList<object>, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<object>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<object>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<bool?, global::Vercel.GetRoutesDiff2?>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, object, global::System.Collections.Generic.IList<object>, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, object, global::System.Collections.Generic.IList<object>, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, object, global::System.Collections.Generic.IList<object>, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, global::Vercel.GetRoutesResponseVariant2, global::Vercel.GetRoutesResponseVariant3, global::Vercel.GetRoutesResponseVariant4>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.GetRoutesResponseVariant2RouteRouteDestination>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetRoutesResponseVariant2RouteRouteHaVariant1, global::Vercel.GetRoutesResponseVariant2RouteRouteHaVariant2>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.GetRoutesResponseVariant2RouteRouteHaVariant1Value>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.GetRoutesResponseVariant2RouteRouteHaVariant2Value>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetRoutesResponseVariant2RouteRouteMissingItemVariant1, global::Vercel.GetRoutesResponseVariant2RouteRouteMissingItemVariant2>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.GetRoutesResponseVariant2RouteRouteMissingItemVariant1Value>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.GetRoutesResponseVariant2RouteRouteMissingItemVariant2Value>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetRoutesResponseVariant2RouteRouteTransformVariant1, global::Vercel.GetRoutesResponseVariant2RouteRouteTransformVariant2>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.GetRoutesResponseVariant2RouteRouteTransformVariant1TargetKey>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.GetRoutesResponseVariant3RouteRouteDestination>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetRoutesResponseVariant3RouteRouteHaVariant1, global::Vercel.GetRoutesResponseVariant3RouteRouteHaVariant2>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.GetRoutesResponseVariant3RouteRouteHaVariant1Value>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.GetRoutesResponseVariant3RouteRouteHaVariant2Value>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetRoutesResponseVariant3RouteRouteMissingItemVariant1, global::Vercel.GetRoutesResponseVariant3RouteRouteMissingItemVariant2>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.GetRoutesResponseVariant3RouteRouteMissingItemVariant1Value>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.GetRoutesResponseVariant3RouteRouteMissingItemVariant2Value>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant1, global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant2>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant1TargetKey>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.GetRoutesResponseVariant4RouteRouteDestination>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetRoutesResponseVariant4RouteRouteHaVariant1, global::Vercel.GetRoutesResponseVariant4RouteRouteHaVariant2>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.GetRoutesResponseVariant4RouteRouteHaVariant1Value>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.GetRoutesResponseVariant4RouteRouteHaVariant2Value>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetRoutesResponseVariant4RouteRouteMissingItemVariant1, global::Vercel.GetRoutesResponseVariant4RouteRouteMissingItemVariant2>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.GetRoutesResponseVariant4RouteRouteMissingItemVariant1Value>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.GetRoutesResponseVariant4RouteRouteMissingItemVariant2Value>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant1, global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant2>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant1TargetKey>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.AddRouteResponseRouteRouteDestination>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AddRouteResponseRouteRouteHaVariant1, global::Vercel.AddRouteResponseRouteRouteHaVariant2>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.AddRouteResponseRouteRouteHaVariant1Value>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.AddRouteResponseRouteRouteHaVariant2Value>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AddRouteResponseRouteRouteMissingItemVariant1, global::Vercel.AddRouteResponseRouteRouteMissingItemVariant2>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.AddRouteResponseRouteRouteMissingItemVariant1Value>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.AddRouteResponseRouteRouteMissingItemVariant2Value>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AddRouteResponseRouteRouteTransformVariant1, global::Vercel.AddRouteResponseRouteRouteTransformVariant2>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.AddRouteResponseRouteRouteTransformVariant1TargetKey>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.EditRouteResponseRouteRouteDestination>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.EditRouteResponseRouteRouteHaVariant1, global::Vercel.EditRouteResponseRouteRouteHaVariant2>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.EditRouteResponseRouteRouteHaVariant1Value>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.EditRouteResponseRouteRouteHaVariant2Value>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.EditRouteResponseRouteRouteMissingItemVariant1, global::Vercel.EditRouteResponseRouteRouteMissingItemVariant2>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.EditRouteResponseRouteRouteMissingItemVariant1Value>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.EditRouteResponseRouteRouteMissingItemVariant2Value>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.EditRouteResponseRouteRouteTransformVariant1, global::Vercel.EditRouteResponseRouteRouteTransformVariant2>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.EditRouteResponseRouteRouteTransformVariant1TargetKey>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Vercel.StageRoutesRequestRouteRouteHaType)

                    || typeToConvert == typeof(global::Vercel.StageRoutesRequestRouteRouteHaType?)

                    || typeToConvert == typeof(global::Vercel.StageRoutesRequestRouteRouteMissingItemType)

                    || typeToConvert == typeof(global::Vercel.StageRoutesRequestRouteRouteMissingItemType?)

                    || typeToConvert == typeof(global::Vercel.StageRoutesRequestRouteRouteTransformType)

                    || typeToConvert == typeof(global::Vercel.StageRoutesRequestRouteRouteTransformType?)

                    || typeToConvert == typeof(global::Vercel.StageRoutesRequestRouteRouteTransformOp)

                    || typeToConvert == typeof(global::Vercel.StageRoutesRequestRouteRouteTransformOp?)

                    || typeToConvert == typeof(global::Vercel.AddRouteRequestRouteSrcSyntax)

                    || typeToConvert == typeof(global::Vercel.AddRouteRequestRouteSrcSyntax?)

                    || typeToConvert == typeof(global::Vercel.AddRouteRequestRouteRouteHaType)

                    || typeToConvert == typeof(global::Vercel.AddRouteRequestRouteRouteHaType?)

                    || typeToConvert == typeof(global::Vercel.AddRouteRequestRouteRouteMissingItemType)

                    || typeToConvert == typeof(global::Vercel.AddRouteRequestRouteRouteMissingItemType?)

                    || typeToConvert == typeof(global::Vercel.AddRouteRequestRouteRouteTransformType)

                    || typeToConvert == typeof(global::Vercel.AddRouteRequestRouteRouteTransformType?)

                    || typeToConvert == typeof(global::Vercel.AddRouteRequestRouteRouteTransformOp)

                    || typeToConvert == typeof(global::Vercel.AddRouteRequestRouteRouteTransformOp?)

                    || typeToConvert == typeof(global::Vercel.AddRouteRequestPositionPlacement)

                    || typeToConvert == typeof(global::Vercel.AddRouteRequestPositionPlacement?)

                    || typeToConvert == typeof(global::Vercel.EditRouteRequestRouteSrcSyntax)

                    || typeToConvert == typeof(global::Vercel.EditRouteRequestRouteSrcSyntax?)

                    || typeToConvert == typeof(global::Vercel.EditRouteRequestRouteRouteHaType)

                    || typeToConvert == typeof(global::Vercel.EditRouteRequestRouteRouteHaType?)

                    || typeToConvert == typeof(global::Vercel.EditRouteRequestRouteRouteMissingItemType)

                    || typeToConvert == typeof(global::Vercel.EditRouteRequestRouteRouteMissingItemType?)

                    || typeToConvert == typeof(global::Vercel.EditRouteRequestRouteRouteTransformType)

                    || typeToConvert == typeof(global::Vercel.EditRouteRequestRouteRouteTransformType?)

                    || typeToConvert == typeof(global::Vercel.EditRouteRequestRouteRouteTransformOp)

                    || typeToConvert == typeof(global::Vercel.EditRouteRequestRouteRouteTransformOp?)

                    || typeToConvert == typeof(global::Vercel.UpdateRouteVersionsRequestAction)

                    || typeToConvert == typeof(global::Vercel.UpdateRouteVersionsRequestAction?)

                    || typeToConvert == typeof(global::Vercel.GetRoutesFilter)

                    || typeToConvert == typeof(global::Vercel.GetRoutesFilter?)

                    || typeToConvert == typeof(global::Vercel.GetRoutesDiff2)

                    || typeToConvert == typeof(global::Vercel.GetRoutesDiff2?)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteDestinationType)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteDestinationType?)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteHaVariant1Type)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteHaVariant1Type?)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteHaVariant2Type)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteHaVariant2Type?)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteMissingItemVariant1Type)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteMissingItemVariant1Type?)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteMissingItemVariant2Type)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteMissingItemVariant2Type?)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteMitigateAction)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteMitigateAction?)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteTransformVariant1Op)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteTransformVariant1Op?)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteTransformVariant1Type)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteTransformVariant1Type?)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteTransformVariant2Op)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteTransformVariant2Op?)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteTransformVariant2Type)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteTransformVariant2Type?)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteType)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteType?)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteSrcSyntax)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteSrcSyntax?)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteDestinationType)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteDestinationType?)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteHaVariant1Type)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteHaVariant1Type?)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteHaVariant2Type)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteHaVariant2Type?)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteMissingItemVariant1Type)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteMissingItemVariant1Type?)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteMissingItemVariant2Type)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteMissingItemVariant2Type?)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteMitigateAction)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteMitigateAction?)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant1Op)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant1Op?)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant1Type)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant1Type?)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant2Op)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant2Op?)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant2Type)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant2Type?)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteType)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteType?)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteSrcSyntax)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteSrcSyntax?)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteDestinationType)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteDestinationType?)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteHaVariant1Type)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteHaVariant1Type?)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteHaVariant2Type)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteHaVariant2Type?)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteMissingItemVariant1Type)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteMissingItemVariant1Type?)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteMissingItemVariant2Type)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteMissingItemVariant2Type?)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteMitigateAction)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteMitigateAction?)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant1Op)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant1Op?)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant1Type)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant1Type?)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant2Op)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant2Op?)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant2Type)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant2Type?)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteType)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteType?)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteSrcSyntax)

                    || typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteSrcSyntax?)

                    || typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteDestinationType)

                    || typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteDestinationType?)

                    || typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteHaVariant1Type)

                    || typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteHaVariant1Type?)

                    || typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteHaVariant2Type)

                    || typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteHaVariant2Type?)

                    || typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteMissingItemVariant1Type)

                    || typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteMissingItemVariant1Type?)

                    || typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteMissingItemVariant2Type)

                    || typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteMissingItemVariant2Type?)

                    || typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteMitigateAction)

                    || typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteMitigateAction?)

                    || typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteTransformVariant1Op)

                    || typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteTransformVariant1Op?)

                    || typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteTransformVariant1Type)

                    || typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteTransformVariant1Type?)

                    || typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteTransformVariant2Op)

                    || typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteTransformVariant2Op?)

                    || typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteTransformVariant2Type)

                    || typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteTransformVariant2Type?)

                    || typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteType)

                    || typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteType?)

                    || typeToConvert == typeof(global::Vercel.AddRouteResponseRouteSrcSyntax)

                    || typeToConvert == typeof(global::Vercel.AddRouteResponseRouteSrcSyntax?)

                    || typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteDestinationType)

                    || typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteDestinationType?)

                    || typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteHaVariant1Type)

                    || typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteHaVariant1Type?)

                    || typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteHaVariant2Type)

                    || typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteHaVariant2Type?)

                    || typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteMissingItemVariant1Type)

                    || typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteMissingItemVariant1Type?)

                    || typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteMissingItemVariant2Type)

                    || typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteMissingItemVariant2Type?)

                    || typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteMitigateAction)

                    || typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteMitigateAction?)

                    || typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteTransformVariant1Op)

                    || typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteTransformVariant1Op?)

                    || typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteTransformVariant1Type)

                    || typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteTransformVariant1Type?)

                    || typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteTransformVariant2Op)

                    || typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteTransformVariant2Op?)

                    || typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteTransformVariant2Type)

                    || typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteTransformVariant2Type?)

                    || typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteType)

                    || typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteType?)

                    || typeToConvert == typeof(global::Vercel.EditRouteResponseRouteSrcSyntax)

                    || typeToConvert == typeof(global::Vercel.EditRouteResponseRouteSrcSyntax?)

                    || typeToConvert == typeof(global::Vercel.GenerateRouteResponseRouteActionHeaderOp)

                    || typeToConvert == typeof(global::Vercel.GenerateRouteResponseRouteActionHeaderOp?)

                    || typeToConvert == typeof(global::Vercel.GenerateRouteResponseRouteActionSubType)

                    || typeToConvert == typeof(global::Vercel.GenerateRouteResponseRouteActionSubType?)

                    || typeToConvert == typeof(global::Vercel.GenerateRouteResponseRouteActionType)

                    || typeToConvert == typeof(global::Vercel.GenerateRouteResponseRouteActionType?)

                    || typeToConvert == typeof(global::Vercel.GenerateRouteResponseRouteConditionField)

                    || typeToConvert == typeof(global::Vercel.GenerateRouteResponseRouteConditionField?)

                    || typeToConvert == typeof(global::Vercel.GenerateRouteResponseRouteConditionOperator)

                    || typeToConvert == typeof(global::Vercel.GenerateRouteResponseRouteConditionOperator?)

                    || typeToConvert == typeof(global::Vercel.GenerateRouteResponseRoutePathConditionSyntax)

                    || typeToConvert == typeof(global::Vercel.GenerateRouteResponseRoutePathConditionSyntax?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Vercel.StageRoutesRequestRouteRouteHaType))
                {
                    return new global::Vercel.JsonConverters.StageRoutesRequestRouteRouteHaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.StageRoutesRequestRouteRouteHaType?))
                {
                    return new global::Vercel.JsonConverters.StageRoutesRequestRouteRouteHaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.StageRoutesRequestRouteRouteMissingItemType))
                {
                    return new global::Vercel.JsonConverters.StageRoutesRequestRouteRouteMissingItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.StageRoutesRequestRouteRouteMissingItemType?))
                {
                    return new global::Vercel.JsonConverters.StageRoutesRequestRouteRouteMissingItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.StageRoutesRequestRouteRouteTransformType))
                {
                    return new global::Vercel.JsonConverters.StageRoutesRequestRouteRouteTransformTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.StageRoutesRequestRouteRouteTransformType?))
                {
                    return new global::Vercel.JsonConverters.StageRoutesRequestRouteRouteTransformTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.StageRoutesRequestRouteRouteTransformOp))
                {
                    return new global::Vercel.JsonConverters.StageRoutesRequestRouteRouteTransformOpJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.StageRoutesRequestRouteRouteTransformOp?))
                {
                    return new global::Vercel.JsonConverters.StageRoutesRequestRouteRouteTransformOpNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AddRouteRequestRouteSrcSyntax))
                {
                    return new global::Vercel.JsonConverters.AddRouteRequestRouteSrcSyntaxJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AddRouteRequestRouteSrcSyntax?))
                {
                    return new global::Vercel.JsonConverters.AddRouteRequestRouteSrcSyntaxNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AddRouteRequestRouteRouteHaType))
                {
                    return new global::Vercel.JsonConverters.AddRouteRequestRouteRouteHaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AddRouteRequestRouteRouteHaType?))
                {
                    return new global::Vercel.JsonConverters.AddRouteRequestRouteRouteHaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AddRouteRequestRouteRouteMissingItemType))
                {
                    return new global::Vercel.JsonConverters.AddRouteRequestRouteRouteMissingItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AddRouteRequestRouteRouteMissingItemType?))
                {
                    return new global::Vercel.JsonConverters.AddRouteRequestRouteRouteMissingItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AddRouteRequestRouteRouteTransformType))
                {
                    return new global::Vercel.JsonConverters.AddRouteRequestRouteRouteTransformTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AddRouteRequestRouteRouteTransformType?))
                {
                    return new global::Vercel.JsonConverters.AddRouteRequestRouteRouteTransformTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AddRouteRequestRouteRouteTransformOp))
                {
                    return new global::Vercel.JsonConverters.AddRouteRequestRouteRouteTransformOpJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AddRouteRequestRouteRouteTransformOp?))
                {
                    return new global::Vercel.JsonConverters.AddRouteRequestRouteRouteTransformOpNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AddRouteRequestPositionPlacement))
                {
                    return new global::Vercel.JsonConverters.AddRouteRequestPositionPlacementJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AddRouteRequestPositionPlacement?))
                {
                    return new global::Vercel.JsonConverters.AddRouteRequestPositionPlacementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.EditRouteRequestRouteSrcSyntax))
                {
                    return new global::Vercel.JsonConverters.EditRouteRequestRouteSrcSyntaxJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.EditRouteRequestRouteSrcSyntax?))
                {
                    return new global::Vercel.JsonConverters.EditRouteRequestRouteSrcSyntaxNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.EditRouteRequestRouteRouteHaType))
                {
                    return new global::Vercel.JsonConverters.EditRouteRequestRouteRouteHaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.EditRouteRequestRouteRouteHaType?))
                {
                    return new global::Vercel.JsonConverters.EditRouteRequestRouteRouteHaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.EditRouteRequestRouteRouteMissingItemType))
                {
                    return new global::Vercel.JsonConverters.EditRouteRequestRouteRouteMissingItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.EditRouteRequestRouteRouteMissingItemType?))
                {
                    return new global::Vercel.JsonConverters.EditRouteRequestRouteRouteMissingItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.EditRouteRequestRouteRouteTransformType))
                {
                    return new global::Vercel.JsonConverters.EditRouteRequestRouteRouteTransformTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.EditRouteRequestRouteRouteTransformType?))
                {
                    return new global::Vercel.JsonConverters.EditRouteRequestRouteRouteTransformTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.EditRouteRequestRouteRouteTransformOp))
                {
                    return new global::Vercel.JsonConverters.EditRouteRequestRouteRouteTransformOpJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.EditRouteRequestRouteRouteTransformOp?))
                {
                    return new global::Vercel.JsonConverters.EditRouteRequestRouteRouteTransformOpNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateRouteVersionsRequestAction))
                {
                    return new global::Vercel.JsonConverters.UpdateRouteVersionsRequestActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateRouteVersionsRequestAction?))
                {
                    return new global::Vercel.JsonConverters.UpdateRouteVersionsRequestActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesFilter))
                {
                    return new global::Vercel.JsonConverters.GetRoutesFilterJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesFilter?))
                {
                    return new global::Vercel.JsonConverters.GetRoutesFilterNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesDiff2))
                {
                    return new global::Vercel.JsonConverters.GetRoutesDiff2JsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesDiff2?))
                {
                    return new global::Vercel.JsonConverters.GetRoutesDiff2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteDestinationType))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant2RouteRouteDestinationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteDestinationType?))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant2RouteRouteDestinationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteHaVariant1Type))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant2RouteRouteHaVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteHaVariant1Type?))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant2RouteRouteHaVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteHaVariant2Type))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant2RouteRouteHaVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteHaVariant2Type?))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant2RouteRouteHaVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteMissingItemVariant1Type))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant2RouteRouteMissingItemVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteMissingItemVariant1Type?))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant2RouteRouteMissingItemVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteMissingItemVariant2Type))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant2RouteRouteMissingItemVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteMissingItemVariant2Type?))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant2RouteRouteMissingItemVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteMitigateAction))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant2RouteRouteMitigateActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteMitigateAction?))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant2RouteRouteMitigateActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteTransformVariant1Op))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant2RouteRouteTransformVariant1OpJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteTransformVariant1Op?))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant2RouteRouteTransformVariant1OpNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteTransformVariant1Type))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant2RouteRouteTransformVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteTransformVariant1Type?))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant2RouteRouteTransformVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteTransformVariant2Op))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant2RouteRouteTransformVariant2OpJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteTransformVariant2Op?))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant2RouteRouteTransformVariant2OpNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteTransformVariant2Type))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant2RouteRouteTransformVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteTransformVariant2Type?))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant2RouteRouteTransformVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteType))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant2RouteRouteTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteRouteType?))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant2RouteRouteTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteSrcSyntax))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant2RouteSrcSyntaxJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant2RouteSrcSyntax?))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant2RouteSrcSyntaxNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteDestinationType))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant3RouteRouteDestinationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteDestinationType?))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant3RouteRouteDestinationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteHaVariant1Type))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant3RouteRouteHaVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteHaVariant1Type?))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant3RouteRouteHaVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteHaVariant2Type))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant3RouteRouteHaVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteHaVariant2Type?))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant3RouteRouteHaVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteMissingItemVariant1Type))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant3RouteRouteMissingItemVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteMissingItemVariant1Type?))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant3RouteRouteMissingItemVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteMissingItemVariant2Type))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant3RouteRouteMissingItemVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteMissingItemVariant2Type?))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant3RouteRouteMissingItemVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteMitigateAction))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant3RouteRouteMitigateActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteMitigateAction?))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant3RouteRouteMitigateActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant1Op))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant3RouteRouteTransformVariant1OpJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant1Op?))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant3RouteRouteTransformVariant1OpNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant1Type))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant3RouteRouteTransformVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant1Type?))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant3RouteRouteTransformVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant2Op))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant3RouteRouteTransformVariant2OpJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant2Op?))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant3RouteRouteTransformVariant2OpNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant2Type))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant3RouteRouteTransformVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant2Type?))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant3RouteRouteTransformVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteType))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant3RouteRouteTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteRouteType?))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant3RouteRouteTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteSrcSyntax))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant3RouteSrcSyntaxJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant3RouteSrcSyntax?))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant3RouteSrcSyntaxNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteDestinationType))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant4RouteRouteDestinationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteDestinationType?))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant4RouteRouteDestinationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteHaVariant1Type))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant4RouteRouteHaVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteHaVariant1Type?))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant4RouteRouteHaVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteHaVariant2Type))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant4RouteRouteHaVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteHaVariant2Type?))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant4RouteRouteHaVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteMissingItemVariant1Type))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant4RouteRouteMissingItemVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteMissingItemVariant1Type?))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant4RouteRouteMissingItemVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteMissingItemVariant2Type))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant4RouteRouteMissingItemVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteMissingItemVariant2Type?))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant4RouteRouteMissingItemVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteMitigateAction))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant4RouteRouteMitigateActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteMitigateAction?))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant4RouteRouteMitigateActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant1Op))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant4RouteRouteTransformVariant1OpJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant1Op?))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant4RouteRouteTransformVariant1OpNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant1Type))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant4RouteRouteTransformVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant1Type?))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant4RouteRouteTransformVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant2Op))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant4RouteRouteTransformVariant2OpJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant2Op?))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant4RouteRouteTransformVariant2OpNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant2Type))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant4RouteRouteTransformVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant2Type?))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant4RouteRouteTransformVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteType))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant4RouteRouteTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteRouteType?))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant4RouteRouteTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteSrcSyntax))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant4RouteSrcSyntaxJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesResponseVariant4RouteSrcSyntax?))
                {
                    return new global::Vercel.JsonConverters.GetRoutesResponseVariant4RouteSrcSyntaxNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteDestinationType))
                {
                    return new global::Vercel.JsonConverters.AddRouteResponseRouteRouteDestinationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteDestinationType?))
                {
                    return new global::Vercel.JsonConverters.AddRouteResponseRouteRouteDestinationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteHaVariant1Type))
                {
                    return new global::Vercel.JsonConverters.AddRouteResponseRouteRouteHaVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteHaVariant1Type?))
                {
                    return new global::Vercel.JsonConverters.AddRouteResponseRouteRouteHaVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteHaVariant2Type))
                {
                    return new global::Vercel.JsonConverters.AddRouteResponseRouteRouteHaVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteHaVariant2Type?))
                {
                    return new global::Vercel.JsonConverters.AddRouteResponseRouteRouteHaVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteMissingItemVariant1Type))
                {
                    return new global::Vercel.JsonConverters.AddRouteResponseRouteRouteMissingItemVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteMissingItemVariant1Type?))
                {
                    return new global::Vercel.JsonConverters.AddRouteResponseRouteRouteMissingItemVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteMissingItemVariant2Type))
                {
                    return new global::Vercel.JsonConverters.AddRouteResponseRouteRouteMissingItemVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteMissingItemVariant2Type?))
                {
                    return new global::Vercel.JsonConverters.AddRouteResponseRouteRouteMissingItemVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteMitigateAction))
                {
                    return new global::Vercel.JsonConverters.AddRouteResponseRouteRouteMitigateActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteMitigateAction?))
                {
                    return new global::Vercel.JsonConverters.AddRouteResponseRouteRouteMitigateActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteTransformVariant1Op))
                {
                    return new global::Vercel.JsonConverters.AddRouteResponseRouteRouteTransformVariant1OpJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteTransformVariant1Op?))
                {
                    return new global::Vercel.JsonConverters.AddRouteResponseRouteRouteTransformVariant1OpNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteTransformVariant1Type))
                {
                    return new global::Vercel.JsonConverters.AddRouteResponseRouteRouteTransformVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteTransformVariant1Type?))
                {
                    return new global::Vercel.JsonConverters.AddRouteResponseRouteRouteTransformVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteTransformVariant2Op))
                {
                    return new global::Vercel.JsonConverters.AddRouteResponseRouteRouteTransformVariant2OpJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteTransformVariant2Op?))
                {
                    return new global::Vercel.JsonConverters.AddRouteResponseRouteRouteTransformVariant2OpNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteTransformVariant2Type))
                {
                    return new global::Vercel.JsonConverters.AddRouteResponseRouteRouteTransformVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteTransformVariant2Type?))
                {
                    return new global::Vercel.JsonConverters.AddRouteResponseRouteRouteTransformVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteType))
                {
                    return new global::Vercel.JsonConverters.AddRouteResponseRouteRouteTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AddRouteResponseRouteRouteType?))
                {
                    return new global::Vercel.JsonConverters.AddRouteResponseRouteRouteTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AddRouteResponseRouteSrcSyntax))
                {
                    return new global::Vercel.JsonConverters.AddRouteResponseRouteSrcSyntaxJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AddRouteResponseRouteSrcSyntax?))
                {
                    return new global::Vercel.JsonConverters.AddRouteResponseRouteSrcSyntaxNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteDestinationType))
                {
                    return new global::Vercel.JsonConverters.EditRouteResponseRouteRouteDestinationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteDestinationType?))
                {
                    return new global::Vercel.JsonConverters.EditRouteResponseRouteRouteDestinationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteHaVariant1Type))
                {
                    return new global::Vercel.JsonConverters.EditRouteResponseRouteRouteHaVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteHaVariant1Type?))
                {
                    return new global::Vercel.JsonConverters.EditRouteResponseRouteRouteHaVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteHaVariant2Type))
                {
                    return new global::Vercel.JsonConverters.EditRouteResponseRouteRouteHaVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteHaVariant2Type?))
                {
                    return new global::Vercel.JsonConverters.EditRouteResponseRouteRouteHaVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteMissingItemVariant1Type))
                {
                    return new global::Vercel.JsonConverters.EditRouteResponseRouteRouteMissingItemVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteMissingItemVariant1Type?))
                {
                    return new global::Vercel.JsonConverters.EditRouteResponseRouteRouteMissingItemVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteMissingItemVariant2Type))
                {
                    return new global::Vercel.JsonConverters.EditRouteResponseRouteRouteMissingItemVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteMissingItemVariant2Type?))
                {
                    return new global::Vercel.JsonConverters.EditRouteResponseRouteRouteMissingItemVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteMitigateAction))
                {
                    return new global::Vercel.JsonConverters.EditRouteResponseRouteRouteMitigateActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteMitigateAction?))
                {
                    return new global::Vercel.JsonConverters.EditRouteResponseRouteRouteMitigateActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteTransformVariant1Op))
                {
                    return new global::Vercel.JsonConverters.EditRouteResponseRouteRouteTransformVariant1OpJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteTransformVariant1Op?))
                {
                    return new global::Vercel.JsonConverters.EditRouteResponseRouteRouteTransformVariant1OpNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteTransformVariant1Type))
                {
                    return new global::Vercel.JsonConverters.EditRouteResponseRouteRouteTransformVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteTransformVariant1Type?))
                {
                    return new global::Vercel.JsonConverters.EditRouteResponseRouteRouteTransformVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteTransformVariant2Op))
                {
                    return new global::Vercel.JsonConverters.EditRouteResponseRouteRouteTransformVariant2OpJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteTransformVariant2Op?))
                {
                    return new global::Vercel.JsonConverters.EditRouteResponseRouteRouteTransformVariant2OpNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteTransformVariant2Type))
                {
                    return new global::Vercel.JsonConverters.EditRouteResponseRouteRouteTransformVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteTransformVariant2Type?))
                {
                    return new global::Vercel.JsonConverters.EditRouteResponseRouteRouteTransformVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteType))
                {
                    return new global::Vercel.JsonConverters.EditRouteResponseRouteRouteTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.EditRouteResponseRouteRouteType?))
                {
                    return new global::Vercel.JsonConverters.EditRouteResponseRouteRouteTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.EditRouteResponseRouteSrcSyntax))
                {
                    return new global::Vercel.JsonConverters.EditRouteResponseRouteSrcSyntaxJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.EditRouteResponseRouteSrcSyntax?))
                {
                    return new global::Vercel.JsonConverters.EditRouteResponseRouteSrcSyntaxNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GenerateRouteResponseRouteActionHeaderOp))
                {
                    return new global::Vercel.JsonConverters.GenerateRouteResponseRouteActionHeaderOpJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GenerateRouteResponseRouteActionHeaderOp?))
                {
                    return new global::Vercel.JsonConverters.GenerateRouteResponseRouteActionHeaderOpNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GenerateRouteResponseRouteActionSubType))
                {
                    return new global::Vercel.JsonConverters.GenerateRouteResponseRouteActionSubTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GenerateRouteResponseRouteActionSubType?))
                {
                    return new global::Vercel.JsonConverters.GenerateRouteResponseRouteActionSubTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GenerateRouteResponseRouteActionType))
                {
                    return new global::Vercel.JsonConverters.GenerateRouteResponseRouteActionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GenerateRouteResponseRouteActionType?))
                {
                    return new global::Vercel.JsonConverters.GenerateRouteResponseRouteActionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GenerateRouteResponseRouteConditionField))
                {
                    return new global::Vercel.JsonConverters.GenerateRouteResponseRouteConditionFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GenerateRouteResponseRouteConditionField?))
                {
                    return new global::Vercel.JsonConverters.GenerateRouteResponseRouteConditionFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GenerateRouteResponseRouteConditionOperator))
                {
                    return new global::Vercel.JsonConverters.GenerateRouteResponseRouteConditionOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GenerateRouteResponseRouteConditionOperator?))
                {
                    return new global::Vercel.JsonConverters.GenerateRouteResponseRouteConditionOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GenerateRouteResponseRoutePathConditionSyntax))
                {
                    return new global::Vercel.JsonConverters.GenerateRouteResponseRoutePathConditionSyntaxJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GenerateRouteResponseRoutePathConditionSyntax?))
                {
                    return new global::Vercel.JsonConverters.GenerateRouteResponseRoutePathConditionSyntaxNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new ProjectRoutesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}