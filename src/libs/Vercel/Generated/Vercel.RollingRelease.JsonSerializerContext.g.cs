
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.GetRollingReleaseBillingStatusResponseVariant1, global::Vercel.GetRollingReleaseBillingStatusResponseVariant2, global::Vercel.GetRollingReleaseBillingStatusResponseVariant3, global::Vercel.GetRollingReleaseBillingStatusResponseVariant4>), TypeInfoPropertyName = "GetRollingReleaseBillingStatusResponseVariant4_b5df865dd71f7e5d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.GetRollingReleaseBillingStatusResponseVariant1, global::Vercel.GetRollingReleaseBillingStatusResponseVariant2, global::Vercel.GetRollingReleaseBillingStatusResponseVariant3, global::Vercel.GetRollingReleaseBillingStatusResponseVariant4>?), TypeInfoPropertyName = "GetRollingReleaseBillingStatusResponseVariant4_c711982a09f92f95")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ApproveRollingReleaseStageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StartRollingReleaseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CompleteRollingReleaseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseState), TypeInfoPropertyName = "GetRollingReleaseState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant1Reason), TypeInfoPropertyName = "GetRollingReleaseBillingStatusResponseVariant1Reason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant2AvailableSlots), TypeInfoPropertyName = "GetRollingReleaseBillingStatusResponseVariant2AvailableSlots2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant2Reason), TypeInfoPropertyName = "GetRollingReleaseBillingStatusResponseVariant2Reason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant3Reason), TypeInfoPropertyName = "GetRollingReleaseBillingStatusResponseVariant3Reason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant4Reason), TypeInfoPropertyName = "GetRollingReleaseBillingStatusResponseVariant4Reason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseConfigResponseRollingRelease))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseConfigResponseRollingReleaseGate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseConfigResponseRollingReleaseGateAction), TypeInfoPropertyName = "GetRollingReleaseConfigResponseRollingReleaseGateAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GetRollingReleaseConfigResponseRollingReleaseGateCheck>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseConfigResponseRollingReleaseGateCheck))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseConfigResponseRollingReleaseGateCheckType), TypeInfoPropertyName = "GetRollingReleaseConfigResponseRollingReleaseGateCheckType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GetRollingReleaseConfigResponseRollingReleaseStage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseConfigResponseRollingReleaseStage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DeleteRollingReleaseConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.UpdateRollingReleaseConfigResponseVariant1, global::Vercel.UpdateRollingReleaseConfigResponseVariant2>), TypeInfoPropertyName = "OneOfUpdateRollingReleaseConfigResponseVariant1UpdateRollingReleaseConfigResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateRollingReleaseConfigResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateRollingReleaseConfigResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateRollingReleaseConfigResponseVariant2RollingRelease))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.UpdateRollingReleaseConfigResponseVariant2RollingReleaseStage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateRollingReleaseConfigResponseVariant2RollingReleaseStage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseResponseRollingRelease))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseActiveStage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseAdvancementType), TypeInfoPropertyName = "GetRollingReleaseResponseRollingReleaseAdvancementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseCanaryDeployment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState), TypeInfoPropertyName = "GetRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseCanaryDeploymentSource), TypeInfoPropertyName = "GetRollingReleaseResponseRollingReleaseCanaryDeploymentSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseCanaryDeploymentTarget), TypeInfoPropertyName = "GetRollingReleaseResponseRollingReleaseCanaryDeploymentTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseCurrentDeployment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState), TypeInfoPropertyName = "GetRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseCurrentDeploymentSource), TypeInfoPropertyName = "GetRollingReleaseResponseRollingReleaseCurrentDeploymentSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseCurrentDeploymentTarget), TypeInfoPropertyName = "GetRollingReleaseResponseRollingReleaseCurrentDeploymentTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseNextStage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GetRollingReleaseResponseRollingReleaseStage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseStage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseState), TypeInfoPropertyName = "GetRollingReleaseResponseRollingReleaseState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseSubstate), TypeInfoPropertyName = "GetRollingReleaseResponseRollingReleaseSubstate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ApproveRollingReleaseStageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingRelease))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseActiveStage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseAdvancementType), TypeInfoPropertyName = "ApproveRollingReleaseStageResponseRollingReleaseAdvancementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCanaryDeployment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentReadyState), TypeInfoPropertyName = "ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentReadyState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentSource), TypeInfoPropertyName = "ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentTarget), TypeInfoPropertyName = "ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCurrentDeployment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentReadyState), TypeInfoPropertyName = "ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentReadyState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentSource), TypeInfoPropertyName = "ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentTarget), TypeInfoPropertyName = "ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseNextStage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseStage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseStage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseState), TypeInfoPropertyName = "ApproveRollingReleaseStageResponseRollingReleaseState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseSubstate), TypeInfoPropertyName = "ApproveRollingReleaseStageResponseRollingReleaseSubstate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StartRollingReleaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StartRollingReleaseResponseRollingRelease))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseActiveStage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseAdvancementType), TypeInfoPropertyName = "StartRollingReleaseResponseRollingReleaseAdvancementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseCanaryDeployment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState), TypeInfoPropertyName = "StartRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseCanaryDeploymentSource), TypeInfoPropertyName = "StartRollingReleaseResponseRollingReleaseCanaryDeploymentSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseCanaryDeploymentTarget), TypeInfoPropertyName = "StartRollingReleaseResponseRollingReleaseCanaryDeploymentTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseCurrentDeployment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState), TypeInfoPropertyName = "StartRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseCurrentDeploymentSource), TypeInfoPropertyName = "StartRollingReleaseResponseRollingReleaseCurrentDeploymentSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseCurrentDeploymentTarget), TypeInfoPropertyName = "StartRollingReleaseResponseRollingReleaseCurrentDeploymentTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseNextStage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.StartRollingReleaseResponseRollingReleaseStage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseStage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseState), TypeInfoPropertyName = "StartRollingReleaseResponseRollingReleaseState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseSubstate), TypeInfoPropertyName = "StartRollingReleaseResponseRollingReleaseSubstate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CompleteRollingReleaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CompleteRollingReleaseResponseRollingRelease))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseActiveStage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseAdvancementType), TypeInfoPropertyName = "CompleteRollingReleaseResponseRollingReleaseAdvancementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseCanaryDeployment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState), TypeInfoPropertyName = "CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentSource), TypeInfoPropertyName = "CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentTarget), TypeInfoPropertyName = "CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseCurrentDeployment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState), TypeInfoPropertyName = "CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentSource), TypeInfoPropertyName = "CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentTarget), TypeInfoPropertyName = "CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseNextStage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.CompleteRollingReleaseResponseRollingReleaseStage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseStage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseState), TypeInfoPropertyName = "CompleteRollingReleaseResponseRollingReleaseState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseSubstate), TypeInfoPropertyName = "CompleteRollingReleaseResponseRollingReleaseSubstate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseState?), TypeInfoPropertyName = "NullableGetRollingReleaseState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant1Reason?), TypeInfoPropertyName = "NullableGetRollingReleaseBillingStatusResponseVariant1Reason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant2AvailableSlots?), TypeInfoPropertyName = "NullableGetRollingReleaseBillingStatusResponseVariant2AvailableSlots2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant2Reason?), TypeInfoPropertyName = "NullableGetRollingReleaseBillingStatusResponseVariant2Reason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant3Reason?), TypeInfoPropertyName = "NullableGetRollingReleaseBillingStatusResponseVariant3Reason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant4Reason?), TypeInfoPropertyName = "NullableGetRollingReleaseBillingStatusResponseVariant4Reason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseConfigResponseRollingReleaseGateAction?), TypeInfoPropertyName = "NullableGetRollingReleaseConfigResponseRollingReleaseGateAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseConfigResponseRollingReleaseGateCheckType?), TypeInfoPropertyName = "NullableGetRollingReleaseConfigResponseRollingReleaseGateCheckType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.UpdateRollingReleaseConfigResponseVariant1, global::Vercel.UpdateRollingReleaseConfigResponseVariant2>?), TypeInfoPropertyName = "NullableOneOfUpdateRollingReleaseConfigResponseVariant1UpdateRollingReleaseConfigResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseAdvancementType?), TypeInfoPropertyName = "NullableGetRollingReleaseResponseRollingReleaseAdvancementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState?), TypeInfoPropertyName = "NullableGetRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseCanaryDeploymentSource?), TypeInfoPropertyName = "NullableGetRollingReleaseResponseRollingReleaseCanaryDeploymentSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseCanaryDeploymentTarget?), TypeInfoPropertyName = "NullableGetRollingReleaseResponseRollingReleaseCanaryDeploymentTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState?), TypeInfoPropertyName = "NullableGetRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseCurrentDeploymentSource?), TypeInfoPropertyName = "NullableGetRollingReleaseResponseRollingReleaseCurrentDeploymentSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseCurrentDeploymentTarget?), TypeInfoPropertyName = "NullableGetRollingReleaseResponseRollingReleaseCurrentDeploymentTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseState?), TypeInfoPropertyName = "NullableGetRollingReleaseResponseRollingReleaseState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseSubstate?), TypeInfoPropertyName = "NullableGetRollingReleaseResponseRollingReleaseSubstate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseAdvancementType?), TypeInfoPropertyName = "NullableApproveRollingReleaseStageResponseRollingReleaseAdvancementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentReadyState?), TypeInfoPropertyName = "NullableApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentReadyState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentSource?), TypeInfoPropertyName = "NullableApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentTarget?), TypeInfoPropertyName = "NullableApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentReadyState?), TypeInfoPropertyName = "NullableApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentReadyState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentSource?), TypeInfoPropertyName = "NullableApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentTarget?), TypeInfoPropertyName = "NullableApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseState?), TypeInfoPropertyName = "NullableApproveRollingReleaseStageResponseRollingReleaseState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseSubstate?), TypeInfoPropertyName = "NullableApproveRollingReleaseStageResponseRollingReleaseSubstate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseAdvancementType?), TypeInfoPropertyName = "NullableStartRollingReleaseResponseRollingReleaseAdvancementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState?), TypeInfoPropertyName = "NullableStartRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseCanaryDeploymentSource?), TypeInfoPropertyName = "NullableStartRollingReleaseResponseRollingReleaseCanaryDeploymentSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseCanaryDeploymentTarget?), TypeInfoPropertyName = "NullableStartRollingReleaseResponseRollingReleaseCanaryDeploymentTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState?), TypeInfoPropertyName = "NullableStartRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseCurrentDeploymentSource?), TypeInfoPropertyName = "NullableStartRollingReleaseResponseRollingReleaseCurrentDeploymentSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseCurrentDeploymentTarget?), TypeInfoPropertyName = "NullableStartRollingReleaseResponseRollingReleaseCurrentDeploymentTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseState?), TypeInfoPropertyName = "NullableStartRollingReleaseResponseRollingReleaseState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseSubstate?), TypeInfoPropertyName = "NullableStartRollingReleaseResponseRollingReleaseSubstate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseAdvancementType?), TypeInfoPropertyName = "NullableCompleteRollingReleaseResponseRollingReleaseAdvancementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState?), TypeInfoPropertyName = "NullableCompleteRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentSource?), TypeInfoPropertyName = "NullableCompleteRollingReleaseResponseRollingReleaseCanaryDeploymentSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentTarget?), TypeInfoPropertyName = "NullableCompleteRollingReleaseResponseRollingReleaseCanaryDeploymentTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState?), TypeInfoPropertyName = "NullableCompleteRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentSource?), TypeInfoPropertyName = "NullableCompleteRollingReleaseResponseRollingReleaseCurrentDeploymentSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentTarget?), TypeInfoPropertyName = "NullableCompleteRollingReleaseResponseRollingReleaseCurrentDeploymentTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseState?), TypeInfoPropertyName = "NullableCompleteRollingReleaseResponseRollingReleaseState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseSubstate?), TypeInfoPropertyName = "NullableCompleteRollingReleaseResponseRollingReleaseSubstate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetRollingReleaseConfigResponseRollingReleaseGateCheck>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetRollingReleaseConfigResponseRollingReleaseStage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.UpdateRollingReleaseConfigResponseVariant2RollingReleaseStage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetRollingReleaseResponseRollingReleaseStage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseStage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.StartRollingReleaseResponseRollingReleaseStage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.CompleteRollingReleaseResponseRollingReleaseStage>))]
    internal sealed partial class RollingReleaseSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RollingReleaseSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static RollingReleaseSourceGenerationContext Default { get; } = new(DefaultOptions);

        private RollingReleaseSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
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
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
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
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetRollingReleaseBillingStatusResponseVariant1, global::Vercel.GetRollingReleaseBillingStatusResponseVariant2, global::Vercel.GetRollingReleaseBillingStatusResponseVariant3, global::Vercel.GetRollingReleaseBillingStatusResponseVariant4>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UpdateRollingReleaseConfigResponseVariant1, global::Vercel.UpdateRollingReleaseConfigResponseVariant2>());
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
                    typeToConvert == typeof(global::Vercel.GetRollingReleaseState)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseState?)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant1Reason)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant1Reason?)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant2AvailableSlots)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant2AvailableSlots?)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant2Reason)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant2Reason?)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant3Reason)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant3Reason?)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant4Reason)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant4Reason?)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseConfigResponseRollingReleaseGateAction)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseConfigResponseRollingReleaseGateAction?)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseConfigResponseRollingReleaseGateCheckType)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseConfigResponseRollingReleaseGateCheckType?)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseAdvancementType)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseAdvancementType?)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState?)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseCanaryDeploymentSource)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseCanaryDeploymentSource?)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseCanaryDeploymentTarget)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseCanaryDeploymentTarget?)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState?)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseCurrentDeploymentSource)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseCurrentDeploymentSource?)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseCurrentDeploymentTarget)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseCurrentDeploymentTarget?)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseState)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseState?)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseSubstate)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseSubstate?)

                    || typeToConvert == typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseAdvancementType)

                    || typeToConvert == typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseAdvancementType?)

                    || typeToConvert == typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentReadyState)

                    || typeToConvert == typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentReadyState?)

                    || typeToConvert == typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentSource)

                    || typeToConvert == typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentSource?)

                    || typeToConvert == typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentTarget)

                    || typeToConvert == typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentTarget?)

                    || typeToConvert == typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentReadyState)

                    || typeToConvert == typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentReadyState?)

                    || typeToConvert == typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentSource)

                    || typeToConvert == typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentSource?)

                    || typeToConvert == typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentTarget)

                    || typeToConvert == typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentTarget?)

                    || typeToConvert == typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseState)

                    || typeToConvert == typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseState?)

                    || typeToConvert == typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseSubstate)

                    || typeToConvert == typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseSubstate?)

                    || typeToConvert == typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseAdvancementType)

                    || typeToConvert == typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseAdvancementType?)

                    || typeToConvert == typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState)

                    || typeToConvert == typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState?)

                    || typeToConvert == typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseCanaryDeploymentSource)

                    || typeToConvert == typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseCanaryDeploymentSource?)

                    || typeToConvert == typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseCanaryDeploymentTarget)

                    || typeToConvert == typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseCanaryDeploymentTarget?)

                    || typeToConvert == typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState)

                    || typeToConvert == typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState?)

                    || typeToConvert == typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseCurrentDeploymentSource)

                    || typeToConvert == typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseCurrentDeploymentSource?)

                    || typeToConvert == typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseCurrentDeploymentTarget)

                    || typeToConvert == typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseCurrentDeploymentTarget?)

                    || typeToConvert == typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseState)

                    || typeToConvert == typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseState?)

                    || typeToConvert == typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseSubstate)

                    || typeToConvert == typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseSubstate?)

                    || typeToConvert == typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseAdvancementType)

                    || typeToConvert == typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseAdvancementType?)

                    || typeToConvert == typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState)

                    || typeToConvert == typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState?)

                    || typeToConvert == typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentSource)

                    || typeToConvert == typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentSource?)

                    || typeToConvert == typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentTarget)

                    || typeToConvert == typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentTarget?)

                    || typeToConvert == typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState)

                    || typeToConvert == typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState?)

                    || typeToConvert == typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentSource)

                    || typeToConvert == typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentSource?)

                    || typeToConvert == typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentTarget)

                    || typeToConvert == typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentTarget?)

                    || typeToConvert == typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseState)

                    || typeToConvert == typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseState?)

                    || typeToConvert == typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseSubstate)

                    || typeToConvert == typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseSubstate?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseState))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseState?))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant1Reason))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseBillingStatusResponseVariant1ReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant1Reason?))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseBillingStatusResponseVariant1ReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant2AvailableSlots))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseBillingStatusResponseVariant2AvailableSlotsJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant2AvailableSlots?))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseBillingStatusResponseVariant2AvailableSlotsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant2Reason))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseBillingStatusResponseVariant2ReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant2Reason?))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseBillingStatusResponseVariant2ReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant3Reason))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseBillingStatusResponseVariant3ReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant3Reason?))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseBillingStatusResponseVariant3ReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant4Reason))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseBillingStatusResponseVariant4ReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant4Reason?))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseBillingStatusResponseVariant4ReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseConfigResponseRollingReleaseGateAction))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseConfigResponseRollingReleaseGateActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseConfigResponseRollingReleaseGateAction?))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseConfigResponseRollingReleaseGateActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseConfigResponseRollingReleaseGateCheckType))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseConfigResponseRollingReleaseGateCheckTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseConfigResponseRollingReleaseGateCheckType?))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseConfigResponseRollingReleaseGateCheckTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseAdvancementType))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseResponseRollingReleaseAdvancementTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseAdvancementType?))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseResponseRollingReleaseAdvancementTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseResponseRollingReleaseCanaryDeploymentReadyStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState?))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseResponseRollingReleaseCanaryDeploymentReadyStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseCanaryDeploymentSource))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseResponseRollingReleaseCanaryDeploymentSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseCanaryDeploymentSource?))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseResponseRollingReleaseCanaryDeploymentSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseCanaryDeploymentTarget))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseResponseRollingReleaseCanaryDeploymentTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseCanaryDeploymentTarget?))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseResponseRollingReleaseCanaryDeploymentTargetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseResponseRollingReleaseCurrentDeploymentReadyStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState?))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseResponseRollingReleaseCurrentDeploymentReadyStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseCurrentDeploymentSource))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseResponseRollingReleaseCurrentDeploymentSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseCurrentDeploymentSource?))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseResponseRollingReleaseCurrentDeploymentSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseCurrentDeploymentTarget))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseResponseRollingReleaseCurrentDeploymentTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseCurrentDeploymentTarget?))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseResponseRollingReleaseCurrentDeploymentTargetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseState))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseResponseRollingReleaseStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseState?))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseResponseRollingReleaseStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseSubstate))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseResponseRollingReleaseSubstateJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseResponseRollingReleaseSubstate?))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseResponseRollingReleaseSubstateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseAdvancementType))
                {
                    return new global::Vercel.JsonConverters.ApproveRollingReleaseStageResponseRollingReleaseAdvancementTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseAdvancementType?))
                {
                    return new global::Vercel.JsonConverters.ApproveRollingReleaseStageResponseRollingReleaseAdvancementTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentReadyState))
                {
                    return new global::Vercel.JsonConverters.ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentReadyStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentReadyState?))
                {
                    return new global::Vercel.JsonConverters.ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentReadyStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentSource))
                {
                    return new global::Vercel.JsonConverters.ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentSource?))
                {
                    return new global::Vercel.JsonConverters.ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentTarget))
                {
                    return new global::Vercel.JsonConverters.ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentTarget?))
                {
                    return new global::Vercel.JsonConverters.ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentTargetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentReadyState))
                {
                    return new global::Vercel.JsonConverters.ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentReadyStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentReadyState?))
                {
                    return new global::Vercel.JsonConverters.ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentReadyStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentSource))
                {
                    return new global::Vercel.JsonConverters.ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentSource?))
                {
                    return new global::Vercel.JsonConverters.ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentTarget))
                {
                    return new global::Vercel.JsonConverters.ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentTarget?))
                {
                    return new global::Vercel.JsonConverters.ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentTargetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseState))
                {
                    return new global::Vercel.JsonConverters.ApproveRollingReleaseStageResponseRollingReleaseStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseState?))
                {
                    return new global::Vercel.JsonConverters.ApproveRollingReleaseStageResponseRollingReleaseStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseSubstate))
                {
                    return new global::Vercel.JsonConverters.ApproveRollingReleaseStageResponseRollingReleaseSubstateJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseSubstate?))
                {
                    return new global::Vercel.JsonConverters.ApproveRollingReleaseStageResponseRollingReleaseSubstateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseAdvancementType))
                {
                    return new global::Vercel.JsonConverters.StartRollingReleaseResponseRollingReleaseAdvancementTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseAdvancementType?))
                {
                    return new global::Vercel.JsonConverters.StartRollingReleaseResponseRollingReleaseAdvancementTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState))
                {
                    return new global::Vercel.JsonConverters.StartRollingReleaseResponseRollingReleaseCanaryDeploymentReadyStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState?))
                {
                    return new global::Vercel.JsonConverters.StartRollingReleaseResponseRollingReleaseCanaryDeploymentReadyStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseCanaryDeploymentSource))
                {
                    return new global::Vercel.JsonConverters.StartRollingReleaseResponseRollingReleaseCanaryDeploymentSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseCanaryDeploymentSource?))
                {
                    return new global::Vercel.JsonConverters.StartRollingReleaseResponseRollingReleaseCanaryDeploymentSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseCanaryDeploymentTarget))
                {
                    return new global::Vercel.JsonConverters.StartRollingReleaseResponseRollingReleaseCanaryDeploymentTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseCanaryDeploymentTarget?))
                {
                    return new global::Vercel.JsonConverters.StartRollingReleaseResponseRollingReleaseCanaryDeploymentTargetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState))
                {
                    return new global::Vercel.JsonConverters.StartRollingReleaseResponseRollingReleaseCurrentDeploymentReadyStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState?))
                {
                    return new global::Vercel.JsonConverters.StartRollingReleaseResponseRollingReleaseCurrentDeploymentReadyStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseCurrentDeploymentSource))
                {
                    return new global::Vercel.JsonConverters.StartRollingReleaseResponseRollingReleaseCurrentDeploymentSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseCurrentDeploymentSource?))
                {
                    return new global::Vercel.JsonConverters.StartRollingReleaseResponseRollingReleaseCurrentDeploymentSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseCurrentDeploymentTarget))
                {
                    return new global::Vercel.JsonConverters.StartRollingReleaseResponseRollingReleaseCurrentDeploymentTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseCurrentDeploymentTarget?))
                {
                    return new global::Vercel.JsonConverters.StartRollingReleaseResponseRollingReleaseCurrentDeploymentTargetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseState))
                {
                    return new global::Vercel.JsonConverters.StartRollingReleaseResponseRollingReleaseStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseState?))
                {
                    return new global::Vercel.JsonConverters.StartRollingReleaseResponseRollingReleaseStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseSubstate))
                {
                    return new global::Vercel.JsonConverters.StartRollingReleaseResponseRollingReleaseSubstateJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.StartRollingReleaseResponseRollingReleaseSubstate?))
                {
                    return new global::Vercel.JsonConverters.StartRollingReleaseResponseRollingReleaseSubstateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseAdvancementType))
                {
                    return new global::Vercel.JsonConverters.CompleteRollingReleaseResponseRollingReleaseAdvancementTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseAdvancementType?))
                {
                    return new global::Vercel.JsonConverters.CompleteRollingReleaseResponseRollingReleaseAdvancementTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState))
                {
                    return new global::Vercel.JsonConverters.CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentReadyStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState?))
                {
                    return new global::Vercel.JsonConverters.CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentReadyStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentSource))
                {
                    return new global::Vercel.JsonConverters.CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentSource?))
                {
                    return new global::Vercel.JsonConverters.CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentTarget))
                {
                    return new global::Vercel.JsonConverters.CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentTarget?))
                {
                    return new global::Vercel.JsonConverters.CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentTargetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState))
                {
                    return new global::Vercel.JsonConverters.CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentReadyStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState?))
                {
                    return new global::Vercel.JsonConverters.CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentReadyStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentSource))
                {
                    return new global::Vercel.JsonConverters.CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentSource?))
                {
                    return new global::Vercel.JsonConverters.CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentTarget))
                {
                    return new global::Vercel.JsonConverters.CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentTarget?))
                {
                    return new global::Vercel.JsonConverters.CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentTargetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseState))
                {
                    return new global::Vercel.JsonConverters.CompleteRollingReleaseResponseRollingReleaseStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseState?))
                {
                    return new global::Vercel.JsonConverters.CompleteRollingReleaseResponseRollingReleaseStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseSubstate))
                {
                    return new global::Vercel.JsonConverters.CompleteRollingReleaseResponseRollingReleaseSubstateJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CompleteRollingReleaseResponseRollingReleaseSubstate?))
                {
                    return new global::Vercel.JsonConverters.CompleteRollingReleaseResponseRollingReleaseSubstateNullableJsonConverter();
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
                    0 => new RollingReleaseSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}