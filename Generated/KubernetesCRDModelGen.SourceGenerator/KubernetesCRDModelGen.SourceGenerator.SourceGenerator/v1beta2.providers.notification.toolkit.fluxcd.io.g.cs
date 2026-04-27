#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.notification.toolkit.fluxcd.io;
/// <summary>Provider is the Schema for the providers API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("v1beta2 Provider is deprecated, upgrade to v1beta3")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ProviderList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Provider>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ProviderList";
    public const string KubeGroup = "notification.toolkit.fluxcd.io";
    public const string KubePluralName = "providers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "notification.toolkit.fluxcd.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ProviderList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Provider objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Provider> Items { get; set; }
}

/// <summary>
/// CertSecretRef specifies the Secret containing
/// a PEM-encoded CA certificate (in the `ca.crt` key).
/// 
/// Note: Support for the `caFile` key has
/// been deprecated.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("v1beta2 Provider is deprecated, upgrade to v1beta3")]
public partial class V1beta2ProviderSpecCertSecretRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// SecretRef specifies the Secret containing the authentication
/// credentials for this Provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("v1beta2 Provider is deprecated, upgrade to v1beta3")]
public partial class V1beta2ProviderSpecSecretRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Type specifies which Provider implementation to use.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ProviderSpecTypeEnum>))]
[global::System.Obsolete("v1beta2 Provider is deprecated, upgrade to v1beta3")]
public enum V1beta2ProviderSpecTypeEnum
{
    [EnumMember(Value = "slack"), JsonStringEnumMemberName("slack")]
    Slack,
    [EnumMember(Value = "discord"), JsonStringEnumMemberName("discord")]
    Discord,
    [EnumMember(Value = "msteams"), JsonStringEnumMemberName("msteams")]
    Msteams,
    [EnumMember(Value = "rocket"), JsonStringEnumMemberName("rocket")]
    Rocket,
    [EnumMember(Value = "generic"), JsonStringEnumMemberName("generic")]
    Generic,
    [EnumMember(Value = "generic-hmac"), JsonStringEnumMemberName("generic-hmac")]
    GenericHmac,
    [EnumMember(Value = "github"), JsonStringEnumMemberName("github")]
    Github,
    [EnumMember(Value = "gitlab"), JsonStringEnumMemberName("gitlab")]
    Gitlab,
    [EnumMember(Value = "gitea"), JsonStringEnumMemberName("gitea")]
    Gitea,
    [EnumMember(Value = "bitbucketserver"), JsonStringEnumMemberName("bitbucketserver")]
    Bitbucketserver,
    [EnumMember(Value = "bitbucket"), JsonStringEnumMemberName("bitbucket")]
    Bitbucket,
    [EnumMember(Value = "azuredevops"), JsonStringEnumMemberName("azuredevops")]
    Azuredevops,
    [EnumMember(Value = "googlechat"), JsonStringEnumMemberName("googlechat")]
    Googlechat,
    [EnumMember(Value = "googlepubsub"), JsonStringEnumMemberName("googlepubsub")]
    Googlepubsub,
    [EnumMember(Value = "webex"), JsonStringEnumMemberName("webex")]
    Webex,
    [EnumMember(Value = "sentry"), JsonStringEnumMemberName("sentry")]
    Sentry,
    [EnumMember(Value = "azureeventhub"), JsonStringEnumMemberName("azureeventhub")]
    Azureeventhub,
    [EnumMember(Value = "telegram"), JsonStringEnumMemberName("telegram")]
    Telegram,
    [EnumMember(Value = "lark"), JsonStringEnumMemberName("lark")]
    Lark,
    [EnumMember(Value = "matrix"), JsonStringEnumMemberName("matrix")]
    Matrix,
    [EnumMember(Value = "opsgenie"), JsonStringEnumMemberName("opsgenie")]
    Opsgenie,
    [EnumMember(Value = "alertmanager"), JsonStringEnumMemberName("alertmanager")]
    Alertmanager,
    [EnumMember(Value = "grafana"), JsonStringEnumMemberName("grafana")]
    Grafana,
    [EnumMember(Value = "githubdispatch"), JsonStringEnumMemberName("githubdispatch")]
    Githubdispatch,
    [EnumMember(Value = "pagerduty"), JsonStringEnumMemberName("pagerduty")]
    Pagerduty,
    [EnumMember(Value = "datadog"), JsonStringEnumMemberName("datadog")]
    Datadog
}

/// <summary>ProviderSpec defines the desired state of the Provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("v1beta2 Provider is deprecated, upgrade to v1beta3")]
public partial class V1beta2ProviderSpec
{
    /// <summary>
    /// Address specifies the endpoint, in a generic sense, to where alerts are sent.
    /// What kind of endpoint depends on the specific Provider type being used.
    /// For the generic Provider, for example, this is an HTTP/S address.
    /// For other Provider types this could be a project ID or a namespace.
    /// </summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>
    /// CertSecretRef specifies the Secret containing
    /// a PEM-encoded CA certificate (in the `ca.crt` key).
    /// 
    /// Note: Support for the `caFile` key has
    /// been deprecated.
    /// </summary>
    [JsonPropertyName("certSecretRef")]
    public V1beta2ProviderSpecCertSecretRef? CertSecretRef { get; set; }

    /// <summary>Channel specifies the destination channel where events should be posted.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>Interval at which to reconcile the Provider with its Secret references.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>Proxy the HTTP/S address of the proxy server.</summary>
    [JsonPropertyName("proxy")]
    public string? Proxy { get; set; }

    /// <summary>
    /// SecretRef specifies the Secret containing the authentication
    /// credentials for this Provider.
    /// </summary>
    [JsonPropertyName("secretRef")]
    public V1beta2ProviderSpecSecretRef? SecretRef { get; set; }

    /// <summary>
    /// Suspend tells the controller to suspend subsequent
    /// events handling for this Provider.
    /// </summary>
    [JsonPropertyName("suspend")]
    public bool? Suspend { get; set; }

    /// <summary>Timeout for sending alerts to the Provider.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }

    /// <summary>Type specifies which Provider implementation to use.</summary>
    [JsonPropertyName("type")]
    public required V1beta2ProviderSpecTypeEnum Type { get; set; }

    /// <summary>Username specifies the name under which events are posted.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ProviderStatusConditionsStatusEnum>))]
[global::System.Obsolete("v1beta2 Provider is deprecated, upgrade to v1beta3")]
public enum V1beta2ProviderStatusConditionsStatusEnum
{
    [EnumMember(Value = "True"), JsonStringEnumMemberName("True")]
    True,
    [EnumMember(Value = "False"), JsonStringEnumMemberName("False")]
    False,
    [EnumMember(Value = "Unknown"), JsonStringEnumMemberName("Unknown")]
    Unknown
}

/// <summary>Condition contains details for one aspect of the current state of this API Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("v1beta2 Provider is deprecated, upgrade to v1beta3")]
public partial class V1beta2ProviderStatusConditions
{
    /// <summary>
    /// lastTransitionTime is the last time the condition transitioned from one status to another.
    /// This should be when the underlying condition changed.  If that is not known, then using the time when the API field changed is acceptable.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// message is a human readable message indicating details about the transition.
    /// This may be an empty string.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// observedGeneration represents the .metadata.generation that the condition was set based upon.
    /// For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// reason contains a programmatic identifier indicating the reason for the condition&apos;s last transition.
    /// Producers of specific condition types may define expected values and meanings for this field,
    /// and whether the values are considered a guaranteed API.
    /// The value should be a CamelCase string.
    /// This field may not be empty.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required V1beta2ProviderStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>ProviderStatus defines the observed state of the Provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("v1beta2 Provider is deprecated, upgrade to v1beta3")]
public partial class V1beta2ProviderStatus
{
    /// <summary>Conditions holds the conditions for the Provider.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ProviderStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// LastHandledReconcileAt holds the value of the most recent
    /// reconcile request value, so a change of the annotation value
    /// can be detected.
    /// </summary>
    [JsonPropertyName("lastHandledReconcileAt")]
    public string? LastHandledReconcileAt { get; set; }

    /// <summary>ObservedGeneration is the last reconciled generation.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Provider is the Schema for the providers API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("v1beta2 Provider is deprecated, upgrade to v1beta3")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Provider : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ProviderSpec?>, IStatus<V1beta2ProviderStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Provider";
    public const string KubeGroup = "notification.toolkit.fluxcd.io";
    public const string KubePluralName = "providers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "notification.toolkit.fluxcd.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Provider";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ProviderSpec defines the desired state of the Provider.</summary>
    [JsonPropertyName("spec")]
    public V1beta2ProviderSpec? Spec { get; set; }

    /// <summary>ProviderStatus defines the observed state of the Provider.</summary>
    [JsonPropertyName("status")]
    public V1beta2ProviderStatus? Status { get; set; }
}