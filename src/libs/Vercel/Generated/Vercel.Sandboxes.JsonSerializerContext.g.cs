
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.RunSessionCommandResponseVariant1, global::Vercel.RunSessionCommandResponseVariant2, global::Vercel.OneOf<global::Vercel.RunSessionCommandResponseVariant3Variant1, global::Vercel.RunSessionCommandResponseVariant3Variant2>?>), TypeInfoPropertyName = "RunSessionCommandResponseVariant3Variant2_d4a3859d7b714aad")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.CreateSandboxesV2RequestSourceVariant1, global::Vercel.CreateSandboxesV2RequestSourceVariant2, global::Vercel.CreateSandboxesV2RequestSourceVariant3>?), TypeInfoPropertyName = "CreateSandboxesV2RequestSourceVariant3_d041a3f018335c4c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.CreateSandboxesV3RequestSourceVariant1, global::Vercel.CreateSandboxesV3RequestSourceVariant2, global::Vercel.CreateSandboxesV3RequestSourceVariant3>?), TypeInfoPropertyName = "CreateSandboxesV3RequestSourceVariant3_587e8007c1765ac4")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.CreateSandboxesV4RequestSourceVariant1, global::Vercel.CreateSandboxesV4RequestSourceVariant2, global::Vercel.CreateSandboxesV4RequestSourceVariant3>?), TypeInfoPropertyName = "CreateSandboxesV4RequestSourceVariant3_79e5db621693090a")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.RunSessionCommandResponseVariant1, global::Vercel.RunSessionCommandResponseVariant2, global::Vercel.OneOf<global::Vercel.RunSessionCommandResponseVariant3Variant1, global::Vercel.RunSessionCommandResponseVariant3Variant2>?>?), TypeInfoPropertyName = "RunSessionCommandResponseVariant3Variant2_3490f370f981bf7b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.NamedSandbox))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.NamedSandboxArchitecture), TypeInfoPropertyName = "NamedSandboxArchitecture2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.NamedSandboxFailoverRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.NamedSandboxFailoverRegion), TypeInfoPropertyName = "NamedSandboxFailoverRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.NamedSandboxKeepLastSnapshots))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Vercel.NamedSandboxMounts2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.NamedSandboxMounts2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.NamedSandboxMountsMode), TypeInfoPropertyName = "NamedSandboxMountsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.NamedSandboxNetworkPolicy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.NamedSandboxNetworkPolicyMode), TypeInfoPropertyName = "NamedSandboxNetworkPolicyMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.NamedSandboxStatus), TypeInfoPropertyName = "NamedSandboxStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SandboxPublicRoute))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SandboxInjectionRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SandboxNetworkPolicy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.SandboxInjectionRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SandboxNetworkPolicyMode), TypeInfoPropertyName = "SandboxNetworkPolicyMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.Session))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SessionArchitecture), TypeInfoPropertyName = "SessionArchitecture2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SessionNetworkTransfer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SessionStatus), TypeInfoPropertyName = "SessionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.Drive))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.Snapshot))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SnapshotArchitecture), TypeInfoPropertyName = "SnapshotArchitecture2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SnapshotCreationMethod), TypeInfoPropertyName = "SnapshotCreationMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SnapshotStatus), TypeInfoPropertyName = "SnapshotStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SessionCommand))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedba1f75615f04b60c>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedba1f75615f04b60c))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared4f336dbaf7392e8f))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared4f336dbaf7392e8fMode), TypeInfoPropertyName = "AutoSDKShared4f336dbaf7392e8fMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedb0ea9e8a9b37de26>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared650e942fd9ba5744))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedcac2d258b36c4083), TypeInfoPropertyName = "AutoSDKSharedcac2d258b36c40832")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared650e942fd9ba5744Subnets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared9296e9c5692fbba2), TypeInfoPropertyName = "AutoSDKShared9296e9c5692fbba22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedba1f75615f04b60c>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedb0ea9e8a9b37de26))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedc97b32abf27d8b81))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedba1f75615f04b60cTransformItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedba1f75615f04b60cTransformItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedba1f75615f04b60cResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedc97b32abf27d8b81Path))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedc97b32abf27d8b81QueryStringItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedc97b32abf27d8b81QueryStringItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedc97b32abf27d8b81QueryStringItemKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedc97b32abf27d8b81QueryStringItemValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedc97b32abf27d8b81Header>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedc97b32abf27d8b81Header))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedc97b32abf27d8b81HeaderKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedc97b32abf27d8b81HeaderValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV2RequestRuntime), TypeInfoPropertyName = "CreateSandboxesV2RequestRuntime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV2RequestArchitecture), TypeInfoPropertyName = "CreateSandboxesV2RequestArchitecture2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV2RequestResources))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.CreateSandboxesV2RequestSourceVariant1, global::Vercel.CreateSandboxesV2RequestSourceVariant2, global::Vercel.CreateSandboxesV2RequestSourceVariant3>), TypeInfoPropertyName = "OneOfCreateSandboxesV2RequestSourceVariant1CreateSandboxesV2RequestSourceVariant2CreateSandboxesV2RequestSourceVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV2RequestSourceVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV2RequestSourceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV2RequestSourceVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Vercel.CreateSandboxesV2RequestMounts2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV2RequestMounts2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV2RequestMountsMode), TypeInfoPropertyName = "CreateSandboxesV2RequestMountsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV2RequestRegion), TypeInfoPropertyName = "CreateSandboxesV2RequestRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.CreateSandboxesV2RequestFailoverRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV2RequestFailoverRegion), TypeInfoPropertyName = "CreateSandboxesV2RequestFailoverRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<object, int?>), TypeInfoPropertyName = "OneOfObjectInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV2RequestKeepLastSnapshots))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrCreateDriveRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrCreateDriveRequestRegion), TypeInfoPropertyName = "GetOrCreateDriveRequestRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateSandboxRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateSandboxRequestResources))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateSandboxRequestRuntime), TypeInfoPropertyName = "UpdateSandboxRequestRuntime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.UpdateSandboxRequestKeepLastSnapshots>), TypeInfoPropertyName = "OneOfStringUpdateSandboxRequestKeepLastSnapshots2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateSandboxRequestKeepLastSnapshots))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateSandboxRequestRegion), TypeInfoPropertyName = "UpdateSandboxRequestRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.UpdateSandboxRequestFailoverRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateSandboxRequestFailoverRegion), TypeInfoPropertyName = "UpdateSandboxRequestFailoverRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Vercel.UpdateSandboxRequestMounts2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateSandboxRequestMounts2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateSandboxRequestMountsMode), TypeInfoPropertyName = "UpdateSandboxRequestMountsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RunSessionCommandRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.KillSessionCommandRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ExtendSessionTimeoutRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ReadSessionFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSessionDirectoryRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesSessionsBySessionIdSnapshotV2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesByNameForkV2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesByNameForkV2RequestResources))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Vercel.CreateSandboxesByNameForkV2RequestMounts2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesByNameForkV2RequestMounts2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesByNameForkV2RequestMountsMode), TypeInfoPropertyName = "CreateSandboxesByNameForkV2RequestMountsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesByNameForkV2RequestRegion), TypeInfoPropertyName = "CreateSandboxesByNameForkV2RequestRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.CreateSandboxesByNameForkV2RequestFailoverRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesByNameForkV2RequestFailoverRegion), TypeInfoPropertyName = "CreateSandboxesByNameForkV2RequestFailoverRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesByNameForkV2RequestKeepLastSnapshots))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV3RequestArchitecture), TypeInfoPropertyName = "CreateSandboxesV3RequestArchitecture2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV3RequestResources))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.CreateSandboxesV3RequestSourceVariant1, global::Vercel.CreateSandboxesV3RequestSourceVariant2, global::Vercel.CreateSandboxesV3RequestSourceVariant3>), TypeInfoPropertyName = "OneOfCreateSandboxesV3RequestSourceVariant1CreateSandboxesV3RequestSourceVariant2CreateSandboxesV3RequestSourceVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV3RequestSourceVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV3RequestSourceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV3RequestSourceVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Vercel.CreateSandboxesV3RequestMounts2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV3RequestMounts2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV3RequestMountsMode), TypeInfoPropertyName = "CreateSandboxesV3RequestMountsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV3RequestRegion), TypeInfoPropertyName = "CreateSandboxesV3RequestRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.CreateSandboxesV3RequestFailoverRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV3RequestFailoverRegion), TypeInfoPropertyName = "CreateSandboxesV3RequestFailoverRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV3RequestKeepLastSnapshots))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesSessionsBySessionIdSnapshotV3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesByNameForkV3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesByNameForkV3RequestResources))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Vercel.CreateSandboxesByNameForkV3RequestMounts2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesByNameForkV3RequestMounts2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesByNameForkV3RequestMountsMode), TypeInfoPropertyName = "CreateSandboxesByNameForkV3RequestMountsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesByNameForkV3RequestRegion), TypeInfoPropertyName = "CreateSandboxesByNameForkV3RequestRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.CreateSandboxesByNameForkV3RequestFailoverRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesByNameForkV3RequestFailoverRegion), TypeInfoPropertyName = "CreateSandboxesByNameForkV3RequestFailoverRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.CreateSandboxesByNameForkV3RequestKeepLastSnapshots>), TypeInfoPropertyName = "OneOfStringCreateSandboxesByNameForkV3RequestKeepLastSnapshots2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesByNameForkV3RequestKeepLastSnapshots))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV4Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV4RequestArchitecture), TypeInfoPropertyName = "CreateSandboxesV4RequestArchitecture2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV4RequestResources))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.CreateSandboxesV4RequestSourceVariant1, global::Vercel.CreateSandboxesV4RequestSourceVariant2, global::Vercel.CreateSandboxesV4RequestSourceVariant3>), TypeInfoPropertyName = "OneOfCreateSandboxesV4RequestSourceVariant1CreateSandboxesV4RequestSourceVariant2CreateSandboxesV4RequestSourceVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV4RequestSourceVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV4RequestSourceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV4RequestSourceVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Vercel.CreateSandboxesV4RequestMounts2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV4RequestMounts2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV4RequestMountsMode), TypeInfoPropertyName = "CreateSandboxesV4RequestMountsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV4RequestRegion), TypeInfoPropertyName = "CreateSandboxesV4RequestRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.CreateSandboxesV4RequestFailoverRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV4RequestFailoverRegion), TypeInfoPropertyName = "CreateSandboxesV4RequestFailoverRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.CreateSandboxesV4RequestKeepLastSnapshots>), TypeInfoPropertyName = "OneOfStringCreateSandboxesV4RequestKeepLastSnapshots2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV4RequestKeepLastSnapshots))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListNamedSandboxesSortBy), TypeInfoPropertyName = "ListNamedSandboxesSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListNamedSandboxesSortOrder), TypeInfoPropertyName = "ListNamedSandboxesSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListNamedSandboxesStatus), TypeInfoPropertyName = "ListNamedSandboxesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListDrivesSortBy), TypeInfoPropertyName = "ListDrivesSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListDrivesSortOrder), TypeInfoPropertyName = "ListDrivesSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListSessionSnapshotsSortOrder), TypeInfoPropertyName = "ListSessionSnapshotsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListSessionsSortOrder), TypeInfoPropertyName = "ListSessionsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetSessionCommandWait), TypeInfoPropertyName = "GetSessionCommandWait2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListNamedSandboxesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListNamedSandboxesResponsePagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.NamedSandbox>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.SandboxPublicRoute>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListDrivesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.Drive>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListDrivesResponsePagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrCreateDriveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrCreateDriveResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DeleteDriveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<object, global::Vercel.ListSessionSnapshotsResponseVariant2>), TypeInfoPropertyName = "OneOfObjectListSessionSnapshotsResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListSessionSnapshotsResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListSessionSnapshotsResponseVariant2Pagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.Snapshot>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetSessionSnapshotResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DeleteSessionSnapshotResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<object, global::Vercel.ListSessionsResponseVariant2>), TypeInfoPropertyName = "OneOfObjectListSessionsResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListSessionsResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListSessionsResponseVariant2Pagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.Session>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetSessionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetNamedSandboxResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.UpdateSandboxResponseVariant1, global::Vercel.UpdateSandboxResponseVariant2>), TypeInfoPropertyName = "OneOfUpdateSandboxResponseVariant1UpdateSandboxResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateSandboxResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateSandboxResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DeleteSandboxResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListSessionCommandsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.SessionCommand>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RunSessionCommandResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RunSessionCommandResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RunSessionCommandResponseVariant1Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RunSessionCommandResponseVariant1DataCode), TypeInfoPropertyName = "RunSessionCommandResponseVariant1DataCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RunSessionCommandResponseVariant1DataMessage), TypeInfoPropertyName = "RunSessionCommandResponseVariant1DataMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RunSessionCommandResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.RunSessionCommandResponseVariant3Variant1, global::Vercel.RunSessionCommandResponseVariant3Variant2>), TypeInfoPropertyName = "OneOfRunSessionCommandResponseVariant3Variant1RunSessionCommandResponseVariant3Variant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RunSessionCommandResponseVariant3Variant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RunSessionCommandResponseVariant3Variant1Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RunSessionCommandResponseVariant3Variant1DataCode), TypeInfoPropertyName = "RunSessionCommandResponseVariant3Variant1DataCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RunSessionCommandResponseVariant3Variant1DataMessage), TypeInfoPropertyName = "RunSessionCommandResponseVariant3Variant1DataMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RunSessionCommandResponseVariant3Variant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetSessionCommandResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.KillSessionCommandResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.GetSessionCommandLogsResponseVariant1, global::Vercel.GetSessionCommandLogsResponseVariant2>), TypeInfoPropertyName = "OneOfGetSessionCommandLogsResponseVariant1GetSessionCommandLogsResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetSessionCommandLogsResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetSessionCommandLogsResponseVariant1Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetSessionCommandLogsResponseVariant1DataCode), TypeInfoPropertyName = "GetSessionCommandLogsResponseVariant1DataCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetSessionCommandLogsResponseVariant1DataMessage), TypeInfoPropertyName = "GetSessionCommandLogsResponseVariant1DataMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetSessionCommandLogsResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.StopSessionResponseVariant1, global::Vercel.StopSessionResponseVariant2>), TypeInfoPropertyName = "OneOfStopSessionResponseVariant1StopSessionResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StopSessionResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StopSessionResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ExtendSessionTimeoutResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateSessionNetworkPolicyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesSessionsBySessionIdSnapshotV2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesByNameForkV2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV3Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesSessionsBySessionIdSnapshotV3Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesByNameForkV3Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV4Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.NamedSandboxArchitecture?), TypeInfoPropertyName = "NullableNamedSandboxArchitecture2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.NamedSandboxFailoverRegion?), TypeInfoPropertyName = "NullableNamedSandboxFailoverRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.NamedSandboxMountsMode?), TypeInfoPropertyName = "NullableNamedSandboxMountsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.NamedSandboxNetworkPolicyMode?), TypeInfoPropertyName = "NullableNamedSandboxNetworkPolicyMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.NamedSandboxStatus?), TypeInfoPropertyName = "NullableNamedSandboxStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SandboxNetworkPolicyMode?), TypeInfoPropertyName = "NullableSandboxNetworkPolicyMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SessionArchitecture?), TypeInfoPropertyName = "NullableSessionArchitecture2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SessionStatus?), TypeInfoPropertyName = "NullableSessionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SnapshotArchitecture?), TypeInfoPropertyName = "NullableSnapshotArchitecture2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SnapshotCreationMethod?), TypeInfoPropertyName = "NullableSnapshotCreationMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SnapshotStatus?), TypeInfoPropertyName = "NullableSnapshotStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared4f336dbaf7392e8fMode?), TypeInfoPropertyName = "NullableAutoSDKShared4f336dbaf7392e8fMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedcac2d258b36c4083?), TypeInfoPropertyName = "NullableAutoSDKSharedcac2d258b36c40832")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared9296e9c5692fbba2?), TypeInfoPropertyName = "NullableAutoSDKShared9296e9c5692fbba22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV2RequestRuntime?), TypeInfoPropertyName = "NullableCreateSandboxesV2RequestRuntime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV2RequestArchitecture?), TypeInfoPropertyName = "NullableCreateSandboxesV2RequestArchitecture2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV2RequestMountsMode?), TypeInfoPropertyName = "NullableCreateSandboxesV2RequestMountsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV2RequestRegion?), TypeInfoPropertyName = "NullableCreateSandboxesV2RequestRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV2RequestFailoverRegion?), TypeInfoPropertyName = "NullableCreateSandboxesV2RequestFailoverRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<object, int?>?), TypeInfoPropertyName = "NullableOneOfObjectInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrCreateDriveRequestRegion?), TypeInfoPropertyName = "NullableGetOrCreateDriveRequestRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateSandboxRequestRuntime?), TypeInfoPropertyName = "NullableUpdateSandboxRequestRuntime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.UpdateSandboxRequestKeepLastSnapshots>?), TypeInfoPropertyName = "NullableOneOfStringUpdateSandboxRequestKeepLastSnapshots2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateSandboxRequestRegion?), TypeInfoPropertyName = "NullableUpdateSandboxRequestRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateSandboxRequestFailoverRegion?), TypeInfoPropertyName = "NullableUpdateSandboxRequestFailoverRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateSandboxRequestMountsMode?), TypeInfoPropertyName = "NullableUpdateSandboxRequestMountsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesByNameForkV2RequestMountsMode?), TypeInfoPropertyName = "NullableCreateSandboxesByNameForkV2RequestMountsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesByNameForkV2RequestRegion?), TypeInfoPropertyName = "NullableCreateSandboxesByNameForkV2RequestRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesByNameForkV2RequestFailoverRegion?), TypeInfoPropertyName = "NullableCreateSandboxesByNameForkV2RequestFailoverRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV3RequestArchitecture?), TypeInfoPropertyName = "NullableCreateSandboxesV3RequestArchitecture2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV3RequestMountsMode?), TypeInfoPropertyName = "NullableCreateSandboxesV3RequestMountsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV3RequestRegion?), TypeInfoPropertyName = "NullableCreateSandboxesV3RequestRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV3RequestFailoverRegion?), TypeInfoPropertyName = "NullableCreateSandboxesV3RequestFailoverRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesByNameForkV3RequestMountsMode?), TypeInfoPropertyName = "NullableCreateSandboxesByNameForkV3RequestMountsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesByNameForkV3RequestRegion?), TypeInfoPropertyName = "NullableCreateSandboxesByNameForkV3RequestRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesByNameForkV3RequestFailoverRegion?), TypeInfoPropertyName = "NullableCreateSandboxesByNameForkV3RequestFailoverRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.CreateSandboxesByNameForkV3RequestKeepLastSnapshots>?), TypeInfoPropertyName = "NullableOneOfStringCreateSandboxesByNameForkV3RequestKeepLastSnapshots2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV4RequestArchitecture?), TypeInfoPropertyName = "NullableCreateSandboxesV4RequestArchitecture2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV4RequestMountsMode?), TypeInfoPropertyName = "NullableCreateSandboxesV4RequestMountsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV4RequestRegion?), TypeInfoPropertyName = "NullableCreateSandboxesV4RequestRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateSandboxesV4RequestFailoverRegion?), TypeInfoPropertyName = "NullableCreateSandboxesV4RequestFailoverRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.CreateSandboxesV4RequestKeepLastSnapshots>?), TypeInfoPropertyName = "NullableOneOfStringCreateSandboxesV4RequestKeepLastSnapshots2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListNamedSandboxesSortBy?), TypeInfoPropertyName = "NullableListNamedSandboxesSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListNamedSandboxesSortOrder?), TypeInfoPropertyName = "NullableListNamedSandboxesSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListNamedSandboxesStatus?), TypeInfoPropertyName = "NullableListNamedSandboxesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListDrivesSortBy?), TypeInfoPropertyName = "NullableListDrivesSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListDrivesSortOrder?), TypeInfoPropertyName = "NullableListDrivesSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListSessionSnapshotsSortOrder?), TypeInfoPropertyName = "NullableListSessionSnapshotsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListSessionsSortOrder?), TypeInfoPropertyName = "NullableListSessionsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetSessionCommandWait?), TypeInfoPropertyName = "NullableGetSessionCommandWait2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<object, global::Vercel.ListSessionSnapshotsResponseVariant2>?), TypeInfoPropertyName = "NullableOneOfObjectListSessionSnapshotsResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<object, global::Vercel.ListSessionsResponseVariant2>?), TypeInfoPropertyName = "NullableOneOfObjectListSessionsResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.UpdateSandboxResponseVariant1, global::Vercel.UpdateSandboxResponseVariant2>?), TypeInfoPropertyName = "NullableOneOfUpdateSandboxResponseVariant1UpdateSandboxResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RunSessionCommandResponseVariant1DataCode?), TypeInfoPropertyName = "NullableRunSessionCommandResponseVariant1DataCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RunSessionCommandResponseVariant1DataMessage?), TypeInfoPropertyName = "NullableRunSessionCommandResponseVariant1DataMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.RunSessionCommandResponseVariant3Variant1, global::Vercel.RunSessionCommandResponseVariant3Variant2>?), TypeInfoPropertyName = "NullableOneOfRunSessionCommandResponseVariant3Variant1RunSessionCommandResponseVariant3Variant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RunSessionCommandResponseVariant3Variant1DataCode?), TypeInfoPropertyName = "NullableRunSessionCommandResponseVariant3Variant1DataCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RunSessionCommandResponseVariant3Variant1DataMessage?), TypeInfoPropertyName = "NullableRunSessionCommandResponseVariant3Variant1DataMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.GetSessionCommandLogsResponseVariant1, global::Vercel.GetSessionCommandLogsResponseVariant2>?), TypeInfoPropertyName = "NullableOneOfGetSessionCommandLogsResponseVariant1GetSessionCommandLogsResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetSessionCommandLogsResponseVariant1DataCode?), TypeInfoPropertyName = "NullableGetSessionCommandLogsResponseVariant1DataCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetSessionCommandLogsResponseVariant1DataMessage?), TypeInfoPropertyName = "NullableGetSessionCommandLogsResponseVariant1DataMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.StopSessionResponseVariant1, global::Vercel.StopSessionResponseVariant2>?), TypeInfoPropertyName = "NullableOneOfStopSessionResponseVariant1StopSessionResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.NamedSandboxFailoverRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.SandboxInjectionRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.AutoSDKSharedba1f75615f04b60c>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.AutoSDKSharedb0ea9e8a9b37de26>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Vercel.AutoSDKSharedba1f75615f04b60c>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.AutoSDKSharedba1f75615f04b60cTransformItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.AutoSDKSharedc97b32abf27d8b81QueryStringItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.AutoSDKSharedc97b32abf27d8b81Header>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.CreateSandboxesV2RequestFailoverRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.UpdateSandboxRequestFailoverRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.CreateSandboxesByNameForkV2RequestFailoverRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.CreateSandboxesV3RequestFailoverRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.CreateSandboxesByNameForkV3RequestFailoverRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.CreateSandboxesV4RequestFailoverRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.NamedSandbox>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.SandboxPublicRoute>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.Drive>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.Snapshot>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.Session>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.SessionCommand>))]
    internal sealed partial class SandboxesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SandboxesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private SandboxesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Vercel.JsonConverters.AutoSDKShared9296e9c5692fbba2JsonConverter());
            options.Converters.Add(new global::Vercel.JsonConverters.AutoSDKSharedcac2d258b36c4083JsonConverter());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, object, global::System.Collections.Generic.IList<object>, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, object, global::System.Collections.Generic.IList<object>, bool?>());
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
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
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
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<object>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<object>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateSandboxesV2RequestSourceVariant1, global::Vercel.CreateSandboxesV2RequestSourceVariant2, global::Vercel.CreateSandboxesV2RequestSourceVariant3>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.UpdateSandboxRequestKeepLastSnapshots>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateSandboxesV3RequestSourceVariant1, global::Vercel.CreateSandboxesV3RequestSourceVariant2, global::Vercel.CreateSandboxesV3RequestSourceVariant3>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.CreateSandboxesByNameForkV3RequestKeepLastSnapshots>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateSandboxesV4RequestSourceVariant1, global::Vercel.CreateSandboxesV4RequestSourceVariant2, global::Vercel.CreateSandboxesV4RequestSourceVariant3>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.CreateSandboxesV4RequestKeepLastSnapshots>());
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
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, string, double?>());
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
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
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
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, global::Vercel.ListSessionSnapshotsResponseVariant2>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, global::Vercel.ListSessionsResponseVariant2>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UpdateSandboxResponseVariant1, global::Vercel.UpdateSandboxResponseVariant2>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.RunSessionCommandResponseVariant1, global::Vercel.RunSessionCommandResponseVariant2, global::Vercel.OneOf<global::Vercel.RunSessionCommandResponseVariant3Variant1, global::Vercel.RunSessionCommandResponseVariant3Variant2>?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.RunSessionCommandResponseVariant3Variant1, global::Vercel.RunSessionCommandResponseVariant3Variant2>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetSessionCommandLogsResponseVariant1, global::Vercel.GetSessionCommandLogsResponseVariant2>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.StopSessionResponseVariant1, global::Vercel.StopSessionResponseVariant2>());
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
                    typeToConvert == typeof(global::Vercel.NamedSandboxArchitecture)

                    || typeToConvert == typeof(global::Vercel.NamedSandboxArchitecture?)

                    || typeToConvert == typeof(global::Vercel.NamedSandboxFailoverRegion)

                    || typeToConvert == typeof(global::Vercel.NamedSandboxFailoverRegion?)

                    || typeToConvert == typeof(global::Vercel.NamedSandboxMountsMode)

                    || typeToConvert == typeof(global::Vercel.NamedSandboxMountsMode?)

                    || typeToConvert == typeof(global::Vercel.NamedSandboxNetworkPolicyMode)

                    || typeToConvert == typeof(global::Vercel.NamedSandboxNetworkPolicyMode?)

                    || typeToConvert == typeof(global::Vercel.NamedSandboxStatus)

                    || typeToConvert == typeof(global::Vercel.NamedSandboxStatus?)

                    || typeToConvert == typeof(global::Vercel.SandboxNetworkPolicyMode)

                    || typeToConvert == typeof(global::Vercel.SandboxNetworkPolicyMode?)

                    || typeToConvert == typeof(global::Vercel.SessionArchitecture)

                    || typeToConvert == typeof(global::Vercel.SessionArchitecture?)

                    || typeToConvert == typeof(global::Vercel.SessionStatus)

                    || typeToConvert == typeof(global::Vercel.SessionStatus?)

                    || typeToConvert == typeof(global::Vercel.SnapshotArchitecture)

                    || typeToConvert == typeof(global::Vercel.SnapshotArchitecture?)

                    || typeToConvert == typeof(global::Vercel.SnapshotCreationMethod)

                    || typeToConvert == typeof(global::Vercel.SnapshotCreationMethod?)

                    || typeToConvert == typeof(global::Vercel.SnapshotStatus)

                    || typeToConvert == typeof(global::Vercel.SnapshotStatus?)

                    || typeToConvert == typeof(global::Vercel.AutoSDKShared4f336dbaf7392e8fMode)

                    || typeToConvert == typeof(global::Vercel.AutoSDKShared4f336dbaf7392e8fMode?)

                    || typeToConvert == typeof(global::Vercel.CreateSandboxesV2RequestRuntime)

                    || typeToConvert == typeof(global::Vercel.CreateSandboxesV2RequestRuntime?)

                    || typeToConvert == typeof(global::Vercel.CreateSandboxesV2RequestArchitecture)

                    || typeToConvert == typeof(global::Vercel.CreateSandboxesV2RequestArchitecture?)

                    || typeToConvert == typeof(global::Vercel.CreateSandboxesV2RequestMountsMode)

                    || typeToConvert == typeof(global::Vercel.CreateSandboxesV2RequestMountsMode?)

                    || typeToConvert == typeof(global::Vercel.CreateSandboxesV2RequestRegion)

                    || typeToConvert == typeof(global::Vercel.CreateSandboxesV2RequestRegion?)

                    || typeToConvert == typeof(global::Vercel.CreateSandboxesV2RequestFailoverRegion)

                    || typeToConvert == typeof(global::Vercel.CreateSandboxesV2RequestFailoverRegion?)

                    || typeToConvert == typeof(global::Vercel.GetOrCreateDriveRequestRegion)

                    || typeToConvert == typeof(global::Vercel.GetOrCreateDriveRequestRegion?)

                    || typeToConvert == typeof(global::Vercel.UpdateSandboxRequestRuntime)

                    || typeToConvert == typeof(global::Vercel.UpdateSandboxRequestRuntime?)

                    || typeToConvert == typeof(global::Vercel.UpdateSandboxRequestRegion)

                    || typeToConvert == typeof(global::Vercel.UpdateSandboxRequestRegion?)

                    || typeToConvert == typeof(global::Vercel.UpdateSandboxRequestFailoverRegion)

                    || typeToConvert == typeof(global::Vercel.UpdateSandboxRequestFailoverRegion?)

                    || typeToConvert == typeof(global::Vercel.UpdateSandboxRequestMountsMode)

                    || typeToConvert == typeof(global::Vercel.UpdateSandboxRequestMountsMode?)

                    || typeToConvert == typeof(global::Vercel.CreateSandboxesByNameForkV2RequestMountsMode)

                    || typeToConvert == typeof(global::Vercel.CreateSandboxesByNameForkV2RequestMountsMode?)

                    || typeToConvert == typeof(global::Vercel.CreateSandboxesByNameForkV2RequestRegion)

                    || typeToConvert == typeof(global::Vercel.CreateSandboxesByNameForkV2RequestRegion?)

                    || typeToConvert == typeof(global::Vercel.CreateSandboxesByNameForkV2RequestFailoverRegion)

                    || typeToConvert == typeof(global::Vercel.CreateSandboxesByNameForkV2RequestFailoverRegion?)

                    || typeToConvert == typeof(global::Vercel.CreateSandboxesV3RequestArchitecture)

                    || typeToConvert == typeof(global::Vercel.CreateSandboxesV3RequestArchitecture?)

                    || typeToConvert == typeof(global::Vercel.CreateSandboxesV3RequestMountsMode)

                    || typeToConvert == typeof(global::Vercel.CreateSandboxesV3RequestMountsMode?)

                    || typeToConvert == typeof(global::Vercel.CreateSandboxesV3RequestRegion)

                    || typeToConvert == typeof(global::Vercel.CreateSandboxesV3RequestRegion?)

                    || typeToConvert == typeof(global::Vercel.CreateSandboxesV3RequestFailoverRegion)

                    || typeToConvert == typeof(global::Vercel.CreateSandboxesV3RequestFailoverRegion?)

                    || typeToConvert == typeof(global::Vercel.CreateSandboxesByNameForkV3RequestMountsMode)

                    || typeToConvert == typeof(global::Vercel.CreateSandboxesByNameForkV3RequestMountsMode?)

                    || typeToConvert == typeof(global::Vercel.CreateSandboxesByNameForkV3RequestRegion)

                    || typeToConvert == typeof(global::Vercel.CreateSandboxesByNameForkV3RequestRegion?)

                    || typeToConvert == typeof(global::Vercel.CreateSandboxesByNameForkV3RequestFailoverRegion)

                    || typeToConvert == typeof(global::Vercel.CreateSandboxesByNameForkV3RequestFailoverRegion?)

                    || typeToConvert == typeof(global::Vercel.CreateSandboxesV4RequestArchitecture)

                    || typeToConvert == typeof(global::Vercel.CreateSandboxesV4RequestArchitecture?)

                    || typeToConvert == typeof(global::Vercel.CreateSandboxesV4RequestMountsMode)

                    || typeToConvert == typeof(global::Vercel.CreateSandboxesV4RequestMountsMode?)

                    || typeToConvert == typeof(global::Vercel.CreateSandboxesV4RequestRegion)

                    || typeToConvert == typeof(global::Vercel.CreateSandboxesV4RequestRegion?)

                    || typeToConvert == typeof(global::Vercel.CreateSandboxesV4RequestFailoverRegion)

                    || typeToConvert == typeof(global::Vercel.CreateSandboxesV4RequestFailoverRegion?)

                    || typeToConvert == typeof(global::Vercel.ListNamedSandboxesSortBy)

                    || typeToConvert == typeof(global::Vercel.ListNamedSandboxesSortBy?)

                    || typeToConvert == typeof(global::Vercel.ListNamedSandboxesSortOrder)

                    || typeToConvert == typeof(global::Vercel.ListNamedSandboxesSortOrder?)

                    || typeToConvert == typeof(global::Vercel.ListNamedSandboxesStatus)

                    || typeToConvert == typeof(global::Vercel.ListNamedSandboxesStatus?)

                    || typeToConvert == typeof(global::Vercel.ListDrivesSortBy)

                    || typeToConvert == typeof(global::Vercel.ListDrivesSortBy?)

                    || typeToConvert == typeof(global::Vercel.ListDrivesSortOrder)

                    || typeToConvert == typeof(global::Vercel.ListDrivesSortOrder?)

                    || typeToConvert == typeof(global::Vercel.ListSessionSnapshotsSortOrder)

                    || typeToConvert == typeof(global::Vercel.ListSessionSnapshotsSortOrder?)

                    || typeToConvert == typeof(global::Vercel.ListSessionsSortOrder)

                    || typeToConvert == typeof(global::Vercel.ListSessionsSortOrder?)

                    || typeToConvert == typeof(global::Vercel.GetSessionCommandWait)

                    || typeToConvert == typeof(global::Vercel.GetSessionCommandWait?)

                    || typeToConvert == typeof(global::Vercel.RunSessionCommandResponseVariant1DataCode)

                    || typeToConvert == typeof(global::Vercel.RunSessionCommandResponseVariant1DataCode?)

                    || typeToConvert == typeof(global::Vercel.RunSessionCommandResponseVariant1DataMessage)

                    || typeToConvert == typeof(global::Vercel.RunSessionCommandResponseVariant1DataMessage?)

                    || typeToConvert == typeof(global::Vercel.RunSessionCommandResponseVariant3Variant1DataCode)

                    || typeToConvert == typeof(global::Vercel.RunSessionCommandResponseVariant3Variant1DataCode?)

                    || typeToConvert == typeof(global::Vercel.RunSessionCommandResponseVariant3Variant1DataMessage)

                    || typeToConvert == typeof(global::Vercel.RunSessionCommandResponseVariant3Variant1DataMessage?)

                    || typeToConvert == typeof(global::Vercel.GetSessionCommandLogsResponseVariant1DataCode)

                    || typeToConvert == typeof(global::Vercel.GetSessionCommandLogsResponseVariant1DataCode?)

                    || typeToConvert == typeof(global::Vercel.GetSessionCommandLogsResponseVariant1DataMessage)

                    || typeToConvert == typeof(global::Vercel.GetSessionCommandLogsResponseVariant1DataMessage?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Vercel.NamedSandboxArchitecture))
                {
                    return new global::Vercel.JsonConverters.NamedSandboxArchitectureJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.NamedSandboxArchitecture?))
                {
                    return new global::Vercel.JsonConverters.NamedSandboxArchitectureNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.NamedSandboxFailoverRegion))
                {
                    return new global::Vercel.JsonConverters.NamedSandboxFailoverRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.NamedSandboxFailoverRegion?))
                {
                    return new global::Vercel.JsonConverters.NamedSandboxFailoverRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.NamedSandboxMountsMode))
                {
                    return new global::Vercel.JsonConverters.NamedSandboxMountsModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.NamedSandboxMountsMode?))
                {
                    return new global::Vercel.JsonConverters.NamedSandboxMountsModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.NamedSandboxNetworkPolicyMode))
                {
                    return new global::Vercel.JsonConverters.NamedSandboxNetworkPolicyModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.NamedSandboxNetworkPolicyMode?))
                {
                    return new global::Vercel.JsonConverters.NamedSandboxNetworkPolicyModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.NamedSandboxStatus))
                {
                    return new global::Vercel.JsonConverters.NamedSandboxStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.NamedSandboxStatus?))
                {
                    return new global::Vercel.JsonConverters.NamedSandboxStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.SandboxNetworkPolicyMode))
                {
                    return new global::Vercel.JsonConverters.SandboxNetworkPolicyModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.SandboxNetworkPolicyMode?))
                {
                    return new global::Vercel.JsonConverters.SandboxNetworkPolicyModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.SessionArchitecture))
                {
                    return new global::Vercel.JsonConverters.SessionArchitectureJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.SessionArchitecture?))
                {
                    return new global::Vercel.JsonConverters.SessionArchitectureNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.SessionStatus))
                {
                    return new global::Vercel.JsonConverters.SessionStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.SessionStatus?))
                {
                    return new global::Vercel.JsonConverters.SessionStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.SnapshotArchitecture))
                {
                    return new global::Vercel.JsonConverters.SnapshotArchitectureJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.SnapshotArchitecture?))
                {
                    return new global::Vercel.JsonConverters.SnapshotArchitectureNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.SnapshotCreationMethod))
                {
                    return new global::Vercel.JsonConverters.SnapshotCreationMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.SnapshotCreationMethod?))
                {
                    return new global::Vercel.JsonConverters.SnapshotCreationMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.SnapshotStatus))
                {
                    return new global::Vercel.JsonConverters.SnapshotStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.SnapshotStatus?))
                {
                    return new global::Vercel.JsonConverters.SnapshotStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKShared4f336dbaf7392e8fMode))
                {
                    return new global::Vercel.JsonConverters.AutoSDKShared4f336dbaf7392e8fModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKShared4f336dbaf7392e8fMode?))
                {
                    return new global::Vercel.JsonConverters.AutoSDKShared4f336dbaf7392e8fModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateSandboxesV2RequestRuntime))
                {
                    return new global::Vercel.JsonConverters.CreateSandboxesV2RequestRuntimeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateSandboxesV2RequestRuntime?))
                {
                    return new global::Vercel.JsonConverters.CreateSandboxesV2RequestRuntimeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateSandboxesV2RequestArchitecture))
                {
                    return new global::Vercel.JsonConverters.CreateSandboxesV2RequestArchitectureJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateSandboxesV2RequestArchitecture?))
                {
                    return new global::Vercel.JsonConverters.CreateSandboxesV2RequestArchitectureNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateSandboxesV2RequestMountsMode))
                {
                    return new global::Vercel.JsonConverters.CreateSandboxesV2RequestMountsModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateSandboxesV2RequestMountsMode?))
                {
                    return new global::Vercel.JsonConverters.CreateSandboxesV2RequestMountsModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateSandboxesV2RequestRegion))
                {
                    return new global::Vercel.JsonConverters.CreateSandboxesV2RequestRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateSandboxesV2RequestRegion?))
                {
                    return new global::Vercel.JsonConverters.CreateSandboxesV2RequestRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateSandboxesV2RequestFailoverRegion))
                {
                    return new global::Vercel.JsonConverters.CreateSandboxesV2RequestFailoverRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateSandboxesV2RequestFailoverRegion?))
                {
                    return new global::Vercel.JsonConverters.CreateSandboxesV2RequestFailoverRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrCreateDriveRequestRegion))
                {
                    return new global::Vercel.JsonConverters.GetOrCreateDriveRequestRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrCreateDriveRequestRegion?))
                {
                    return new global::Vercel.JsonConverters.GetOrCreateDriveRequestRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateSandboxRequestRuntime))
                {
                    return new global::Vercel.JsonConverters.UpdateSandboxRequestRuntimeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateSandboxRequestRuntime?))
                {
                    return new global::Vercel.JsonConverters.UpdateSandboxRequestRuntimeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateSandboxRequestRegion))
                {
                    return new global::Vercel.JsonConverters.UpdateSandboxRequestRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateSandboxRequestRegion?))
                {
                    return new global::Vercel.JsonConverters.UpdateSandboxRequestRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateSandboxRequestFailoverRegion))
                {
                    return new global::Vercel.JsonConverters.UpdateSandboxRequestFailoverRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateSandboxRequestFailoverRegion?))
                {
                    return new global::Vercel.JsonConverters.UpdateSandboxRequestFailoverRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateSandboxRequestMountsMode))
                {
                    return new global::Vercel.JsonConverters.UpdateSandboxRequestMountsModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateSandboxRequestMountsMode?))
                {
                    return new global::Vercel.JsonConverters.UpdateSandboxRequestMountsModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateSandboxesByNameForkV2RequestMountsMode))
                {
                    return new global::Vercel.JsonConverters.CreateSandboxesByNameForkV2RequestMountsModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateSandboxesByNameForkV2RequestMountsMode?))
                {
                    return new global::Vercel.JsonConverters.CreateSandboxesByNameForkV2RequestMountsModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateSandboxesByNameForkV2RequestRegion))
                {
                    return new global::Vercel.JsonConverters.CreateSandboxesByNameForkV2RequestRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateSandboxesByNameForkV2RequestRegion?))
                {
                    return new global::Vercel.JsonConverters.CreateSandboxesByNameForkV2RequestRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateSandboxesByNameForkV2RequestFailoverRegion))
                {
                    return new global::Vercel.JsonConverters.CreateSandboxesByNameForkV2RequestFailoverRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateSandboxesByNameForkV2RequestFailoverRegion?))
                {
                    return new global::Vercel.JsonConverters.CreateSandboxesByNameForkV2RequestFailoverRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateSandboxesV3RequestArchitecture))
                {
                    return new global::Vercel.JsonConverters.CreateSandboxesV3RequestArchitectureJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateSandboxesV3RequestArchitecture?))
                {
                    return new global::Vercel.JsonConverters.CreateSandboxesV3RequestArchitectureNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateSandboxesV3RequestMountsMode))
                {
                    return new global::Vercel.JsonConverters.CreateSandboxesV3RequestMountsModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateSandboxesV3RequestMountsMode?))
                {
                    return new global::Vercel.JsonConverters.CreateSandboxesV3RequestMountsModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateSandboxesV3RequestRegion))
                {
                    return new global::Vercel.JsonConverters.CreateSandboxesV3RequestRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateSandboxesV3RequestRegion?))
                {
                    return new global::Vercel.JsonConverters.CreateSandboxesV3RequestRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateSandboxesV3RequestFailoverRegion))
                {
                    return new global::Vercel.JsonConverters.CreateSandboxesV3RequestFailoverRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateSandboxesV3RequestFailoverRegion?))
                {
                    return new global::Vercel.JsonConverters.CreateSandboxesV3RequestFailoverRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateSandboxesByNameForkV3RequestMountsMode))
                {
                    return new global::Vercel.JsonConverters.CreateSandboxesByNameForkV3RequestMountsModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateSandboxesByNameForkV3RequestMountsMode?))
                {
                    return new global::Vercel.JsonConverters.CreateSandboxesByNameForkV3RequestMountsModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateSandboxesByNameForkV3RequestRegion))
                {
                    return new global::Vercel.JsonConverters.CreateSandboxesByNameForkV3RequestRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateSandboxesByNameForkV3RequestRegion?))
                {
                    return new global::Vercel.JsonConverters.CreateSandboxesByNameForkV3RequestRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateSandboxesByNameForkV3RequestFailoverRegion))
                {
                    return new global::Vercel.JsonConverters.CreateSandboxesByNameForkV3RequestFailoverRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateSandboxesByNameForkV3RequestFailoverRegion?))
                {
                    return new global::Vercel.JsonConverters.CreateSandboxesByNameForkV3RequestFailoverRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateSandboxesV4RequestArchitecture))
                {
                    return new global::Vercel.JsonConverters.CreateSandboxesV4RequestArchitectureJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateSandboxesV4RequestArchitecture?))
                {
                    return new global::Vercel.JsonConverters.CreateSandboxesV4RequestArchitectureNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateSandboxesV4RequestMountsMode))
                {
                    return new global::Vercel.JsonConverters.CreateSandboxesV4RequestMountsModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateSandboxesV4RequestMountsMode?))
                {
                    return new global::Vercel.JsonConverters.CreateSandboxesV4RequestMountsModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateSandboxesV4RequestRegion))
                {
                    return new global::Vercel.JsonConverters.CreateSandboxesV4RequestRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateSandboxesV4RequestRegion?))
                {
                    return new global::Vercel.JsonConverters.CreateSandboxesV4RequestRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateSandboxesV4RequestFailoverRegion))
                {
                    return new global::Vercel.JsonConverters.CreateSandboxesV4RequestFailoverRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateSandboxesV4RequestFailoverRegion?))
                {
                    return new global::Vercel.JsonConverters.CreateSandboxesV4RequestFailoverRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListNamedSandboxesSortBy))
                {
                    return new global::Vercel.JsonConverters.ListNamedSandboxesSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListNamedSandboxesSortBy?))
                {
                    return new global::Vercel.JsonConverters.ListNamedSandboxesSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListNamedSandboxesSortOrder))
                {
                    return new global::Vercel.JsonConverters.ListNamedSandboxesSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListNamedSandboxesSortOrder?))
                {
                    return new global::Vercel.JsonConverters.ListNamedSandboxesSortOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListNamedSandboxesStatus))
                {
                    return new global::Vercel.JsonConverters.ListNamedSandboxesStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListNamedSandboxesStatus?))
                {
                    return new global::Vercel.JsonConverters.ListNamedSandboxesStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListDrivesSortBy))
                {
                    return new global::Vercel.JsonConverters.ListDrivesSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListDrivesSortBy?))
                {
                    return new global::Vercel.JsonConverters.ListDrivesSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListDrivesSortOrder))
                {
                    return new global::Vercel.JsonConverters.ListDrivesSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListDrivesSortOrder?))
                {
                    return new global::Vercel.JsonConverters.ListDrivesSortOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListSessionSnapshotsSortOrder))
                {
                    return new global::Vercel.JsonConverters.ListSessionSnapshotsSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListSessionSnapshotsSortOrder?))
                {
                    return new global::Vercel.JsonConverters.ListSessionSnapshotsSortOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListSessionsSortOrder))
                {
                    return new global::Vercel.JsonConverters.ListSessionsSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListSessionsSortOrder?))
                {
                    return new global::Vercel.JsonConverters.ListSessionsSortOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetSessionCommandWait))
                {
                    return new global::Vercel.JsonConverters.GetSessionCommandWaitJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetSessionCommandWait?))
                {
                    return new global::Vercel.JsonConverters.GetSessionCommandWaitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.RunSessionCommandResponseVariant1DataCode))
                {
                    return new global::Vercel.JsonConverters.RunSessionCommandResponseVariant1DataCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.RunSessionCommandResponseVariant1DataCode?))
                {
                    return new global::Vercel.JsonConverters.RunSessionCommandResponseVariant1DataCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.RunSessionCommandResponseVariant1DataMessage))
                {
                    return new global::Vercel.JsonConverters.RunSessionCommandResponseVariant1DataMessageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.RunSessionCommandResponseVariant1DataMessage?))
                {
                    return new global::Vercel.JsonConverters.RunSessionCommandResponseVariant1DataMessageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.RunSessionCommandResponseVariant3Variant1DataCode))
                {
                    return new global::Vercel.JsonConverters.RunSessionCommandResponseVariant3Variant1DataCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.RunSessionCommandResponseVariant3Variant1DataCode?))
                {
                    return new global::Vercel.JsonConverters.RunSessionCommandResponseVariant3Variant1DataCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.RunSessionCommandResponseVariant3Variant1DataMessage))
                {
                    return new global::Vercel.JsonConverters.RunSessionCommandResponseVariant3Variant1DataMessageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.RunSessionCommandResponseVariant3Variant1DataMessage?))
                {
                    return new global::Vercel.JsonConverters.RunSessionCommandResponseVariant3Variant1DataMessageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetSessionCommandLogsResponseVariant1DataCode))
                {
                    return new global::Vercel.JsonConverters.GetSessionCommandLogsResponseVariant1DataCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetSessionCommandLogsResponseVariant1DataCode?))
                {
                    return new global::Vercel.JsonConverters.GetSessionCommandLogsResponseVariant1DataCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetSessionCommandLogsResponseVariant1DataMessage))
                {
                    return new global::Vercel.JsonConverters.GetSessionCommandLogsResponseVariant1DataMessageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetSessionCommandLogsResponseVariant1DataMessage?))
                {
                    return new global::Vercel.JsonConverters.GetSessionCommandLogsResponseVariant1DataMessageNullableJsonConverter();
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
                    0 => new SandboxesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}