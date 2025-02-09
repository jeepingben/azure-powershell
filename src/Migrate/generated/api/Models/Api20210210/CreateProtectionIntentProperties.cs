namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Create protection intent input properties.</summary>
    public partial class CreateProtectionIntentProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateProtectionIntentProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateProtectionIntentPropertiesInternal
    {

        /// <summary>Internal Acessors for ProviderSpecificDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateProtectionIntentProviderSpecificDetails Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateProtectionIntentPropertiesInternal.ProviderSpecificDetail { get => (this._providerSpecificDetail = this._providerSpecificDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.CreateProtectionIntentProviderSpecificDetails()); set { {_providerSpecificDetail = value;} } }

        /// <summary>Backing field for <see cref="ProviderSpecificDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateProtectionIntentProviderSpecificDetails _providerSpecificDetail;

        /// <summary>
        /// The ReplicationProviderInput. For A2A provider, it will be A2ACreateProtectionIntentInput object.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateProtectionIntentProviderSpecificDetails ProviderSpecificDetail { get => (this._providerSpecificDetail = this._providerSpecificDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.CreateProtectionIntentProviderSpecificDetails()); set => this._providerSpecificDetail = value; }

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ProviderSpecificDetailInstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateProtectionIntentProviderSpecificDetailsInternal)ProviderSpecificDetail).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateProtectionIntentProviderSpecificDetailsInternal)ProviderSpecificDetail).InstanceType = value ?? null; }

        /// <summary>Creates an new <see cref="CreateProtectionIntentProperties" /> instance.</summary>
        public CreateProtectionIntentProperties()
        {

        }
    }
    /// Create protection intent input properties.
    public partial interface ICreateProtectionIntentProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The class type.",
        SerializedName = @"instanceType",
        PossibleTypes = new [] { typeof(string) })]
        string ProviderSpecificDetailInstanceType { get; set; }

    }
    /// Create protection intent input properties.
    internal partial interface ICreateProtectionIntentPropertiesInternal

    {
        /// <summary>
        /// The ReplicationProviderInput. For A2A provider, it will be A2ACreateProtectionIntentInput object.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateProtectionIntentProviderSpecificDetails ProviderSpecificDetail { get; set; }
        /// <summary>The class type.</summary>
        string ProviderSpecificDetailInstanceType { get; set; }

    }
}