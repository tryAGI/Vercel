#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Vercel
{
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata,
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductProjectConnectionScope>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductGuide>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductGuideStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductGuideStepAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductSupportedProtocol>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.CreateIntegrationStoreDirectResponseStoreProtocolSettingsAuthenticationAppUrl>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.CreateIntegrationStoreDirectResponseStoreSecret>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.CreateIntegrationStoreDirectResponseStoreBillingPlanDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.CreateIntegrationStoreDirectResponseStoreBillingPlanHighlightedDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.CreateIntegrationStoreDirectResponseStoreBillingPlanQuoteItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.CreateIntegrationStoreDirectResponseStoreTarget>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetTeamMembersResponseMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetTeamMembersResponseMemberProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetTeamMembersResponseEmailInviteCode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetTeamMembersResponseEmailInviteCodeTeamRole>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetTeamMembersResponseEmailInviteCodeTeamPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.OneOf<global::Vercel.Team, global::Vercel.TeamLimited>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.AuthToken>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ListRepositoryTagsResponseTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.OneOf<string, global::Vercel.AggregatePageviewsResponseQueryGroupByItem?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::System.Collections.Generic.List<global::Vercel.AggregatePageviewsResponseDataVariant1Item>, global::System.Collections.Generic.List<global::Vercel.AggregatePageviewsResponseDataVariant2Item>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.AggregatePageviewsResponseDataVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.AggregatePageviewsResponseDataVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.OneOf<string, global::Vercel.AggregateEventsResponseQueryGroupByItem?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::System.Collections.Generic.List<global::Vercel.AggregateEventsResponseDataVariant1Item>, global::System.Collections.Generic.List<global::Vercel.AggregateEventsResponseDataVariant2Item>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.AggregateEventsResponseDataVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.AggregateEventsResponseDataVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.CreateWebhookResponseEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::System.Collections.Generic.List<global::Vercel.GetWebhooksResponseVariant1Item>, global::System.Collections.Generic.List<global::Vercel.GetWebhooksResponseVariant2Item>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetWebhooksResponseVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetWebhooksResponseVariant1ItemProjectsMetadataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetWebhooksResponseVariant1ItemEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetWebhooksResponseVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetWebhooksResponseVariant2ItemEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetWebhookResponseEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ListDeploymentAliasesResponseAliase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ListAliasesResponseAliase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::System.Collections.Generic.List<global::Vercel.ListAliasesResponseAliaseMicrofrontendsApplicationsVariant1Item>, global::System.Collections.Generic.List<global::Vercel.ListAliasesResponseAliaseMicrofrontendsApplicationsVariant2Item>, global::System.Collections.Generic.List<global::Vercel.ListAliasesResponseAliaseMicrofrontendsApplicationsVariant3Item>>), TypeInfoPropertyName = "ListAliasesResponseAliaseMicrofrontendsApplicationsVariant3Item_ebffb0ae5e58884b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ListAliasesResponseAliaseMicrofrontendsApplicationsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ListAliasesResponseAliaseMicrofrontendsApplicationsVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ListAliasesResponseAliaseMicrofrontendsApplicationsVariant3Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::System.Collections.Generic.List<global::Vercel.GetAliasResponseMicrofrontendsApplicationsVariant1Item>, global::System.Collections.Generic.List<global::Vercel.GetAliasResponseMicrofrontendsApplicationsVariant2Item>, global::System.Collections.Generic.List<global::Vercel.GetAliasResponseMicrofrontendsApplicationsVariant3Item>>), TypeInfoPropertyName = "GetAliasResponseMicrofrontendsApplicationsVariant3Item_37312b6da8f94d16")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetAliasResponseMicrofrontendsApplicationsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetAliasResponseMicrofrontendsApplicationsVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetAliasResponseMicrofrontendsApplicationsVariant3Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetCertsResponseCert>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetDeploymentsResponseDeployment>))]
    internal sealed partial class SourceGenerationContextChunk033 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}
