namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>HvrA provider specific input for test failover.</summary>
    public partial class HyperVReplicaAzureTestFailoverInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureTestFailoverInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureTestFailoverInputInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverProviderSpecificInput"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverProviderSpecificInput __testFailoverProviderSpecificInput = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.TestFailoverProviderSpecificInput();

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverProviderSpecificInputInternal)__testFailoverProviderSpecificInput).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverProviderSpecificInputInternal)__testFailoverProviderSpecificInput).InstanceType = value ?? null; }

        /// <summary>Backing field for <see cref="PrimaryKekCertificatePfx" /> property.</summary>
        private string _primaryKekCertificatePfx;

        /// <summary>Primary kek certificate pfx.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string PrimaryKekCertificatePfx { get => this._primaryKekCertificatePfx; set => this._primaryKekCertificatePfx = value; }

        /// <summary>Backing field for <see cref="RecoveryPointId" /> property.</summary>
        private string _recoveryPointId;

        /// <summary>
        /// The recovery point id to be passed to test failover to a particular recovery point. In case of latest recovery point,
        /// null should be passed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RecoveryPointId { get => this._recoveryPointId; set => this._recoveryPointId = value; }

        /// <summary>Backing field for <see cref="SecondaryKekCertificatePfx" /> property.</summary>
        private string _secondaryKekCertificatePfx;

        /// <summary>Secondary kek certificate pfx.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string SecondaryKekCertificatePfx { get => this._secondaryKekCertificatePfx; set => this._secondaryKekCertificatePfx = value; }

        /// <summary>Creates an new <see cref="HyperVReplicaAzureTestFailoverInput" /> instance.</summary>
        public HyperVReplicaAzureTestFailoverInput()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__testFailoverProviderSpecificInput), __testFailoverProviderSpecificInput);
            await eventListener.AssertObjectIsValid(nameof(__testFailoverProviderSpecificInput), __testFailoverProviderSpecificInput);
        }
    }
    /// HvrA provider specific input for test failover.
    public partial interface IHyperVReplicaAzureTestFailoverInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverProviderSpecificInput
    {
        /// <summary>Primary kek certificate pfx.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Primary kek certificate pfx.",
        SerializedName = @"primaryKekCertificatePfx",
        PossibleTypes = new [] { typeof(string) })]
        string PrimaryKekCertificatePfx { get; set; }
        /// <summary>
        /// The recovery point id to be passed to test failover to a particular recovery point. In case of latest recovery point,
        /// null should be passed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The recovery point id to be passed to test failover to a particular recovery point. In case of latest recovery point, null should be passed.",
        SerializedName = @"recoveryPointId",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryPointId { get; set; }
        /// <summary>Secondary kek certificate pfx.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Secondary kek certificate pfx.",
        SerializedName = @"secondaryKekCertificatePfx",
        PossibleTypes = new [] { typeof(string) })]
        string SecondaryKekCertificatePfx { get; set; }

    }
    /// HvrA provider specific input for test failover.
    internal partial interface IHyperVReplicaAzureTestFailoverInputInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverProviderSpecificInputInternal
    {
        /// <summary>Primary kek certificate pfx.</summary>
        string PrimaryKekCertificatePfx { get; set; }
        /// <summary>
        /// The recovery point id to be passed to test failover to a particular recovery point. In case of latest recovery point,
        /// null should be passed.
        /// </summary>
        string RecoveryPointId { get; set; }
        /// <summary>Secondary kek certificate pfx.</summary>
        string SecondaryKekCertificatePfx { get; set; }

    }
}