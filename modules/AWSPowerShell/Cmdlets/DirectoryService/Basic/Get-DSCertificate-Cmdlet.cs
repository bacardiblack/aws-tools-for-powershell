/*******************************************************************************
 *  Copyright 2012-2019 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *
 *  AWS Tools for Windows (TM) PowerShell (TM)
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using Amazon.PowerShell.Common;
using Amazon.Runtime;
using Amazon.DirectoryService;
using Amazon.DirectoryService.Model;

namespace Amazon.PowerShell.Cmdlets.DS
{
    /// <summary>
    /// Displays information about the certificate registered for a secured LDAP connection.
    /// </summary>
    [Cmdlet("Get", "DSCertificate")]
    [OutputType("Amazon.DirectoryService.Model.Certificate")]
    [AWSCmdlet("Calls the AWS Directory Service DescribeCertificate API operation.", Operation = new[] {"DescribeCertificate"}, SelectReturnType = typeof(Amazon.DirectoryService.Model.DescribeCertificateResponse))]
    [AWSCmdletOutput("Amazon.DirectoryService.Model.Certificate or Amazon.DirectoryService.Model.DescribeCertificateResponse",
        "This cmdlet returns an Amazon.DirectoryService.Model.Certificate object.",
        "The service call response (type Amazon.DirectoryService.Model.DescribeCertificateResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class GetDSCertificateCmdlet : AmazonDirectoryServiceClientCmdlet, IExecutor
    {
        
        #region Parameter CertificateId
        /// <summary>
        /// <para>
        /// <para>The identifier of the certificate.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        #else
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String CertificateId { get; set; }
        #endregion
        
        #region Parameter DirectoryId
        /// <summary>
        /// <para>
        /// <para>The identifier of the directory.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String DirectoryId { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'Certificate'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.DirectoryService.Model.DescribeCertificateResponse).
        /// Specifying the name of a property of type Amazon.DirectoryService.Model.DescribeCertificateResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "Certificate";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the CertificateId parameter.
        /// The -PassThru parameter is deprecated, use -Select '^CertificateId' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^CertificateId' instead. This parameter will be removed in a future version.")]
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter PassThru { get; set; }
        #endregion
        
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.DirectoryService.Model.DescribeCertificateResponse, GetDSCertificateCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.CertificateId;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.CertificateId = this.CertificateId;
            #if MODULAR
            if (this.CertificateId == null && ParameterWasBound(nameof(this.CertificateId)))
            {
                WriteWarning("You are passing $null as a value for parameter CertificateId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.DirectoryId = this.DirectoryId;
            #if MODULAR
            if (this.DirectoryId == null && ParameterWasBound(nameof(this.DirectoryId)))
            {
                WriteWarning("You are passing $null as a value for parameter DirectoryId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            
            // allow further manipulation of loaded context prior to processing
            PostExecutionContextLoad(context);
            
            var output = Execute(context) as CmdletOutput;
            ProcessOutput(output);
        }
        
        #region IExecutor Members
        
        public object Execute(ExecutorContext context)
        {
            var cmdletContext = context as CmdletContext;
            // create request
            var request = new Amazon.DirectoryService.Model.DescribeCertificateRequest();
            
            if (cmdletContext.CertificateId != null)
            {
                request.CertificateId = cmdletContext.CertificateId;
            }
            if (cmdletContext.DirectoryId != null)
            {
                request.DirectoryId = cmdletContext.DirectoryId;
            }
            
            CmdletOutput output;
            
            // issue call
            var client = Client ?? CreateClient(_CurrentCredentials, _RegionEndpoint);
            try
            {
                var response = CallAWSServiceOperation(client, request);
                object pipelineOutput = null;
                pipelineOutput = cmdletContext.Select(response, this);
                output = new CmdletOutput
                {
                    PipelineOutput = pipelineOutput,
                    ServiceResponse = response
                };
            }
            catch (Exception e)
            {
                output = new CmdletOutput { ErrorResponse = e };
            }
            
            return output;
        }
        
        public ExecutorContext CreateContext()
        {
            return new CmdletContext();
        }
        
        #endregion
        
        #region AWS Service Operation Call
        
        private Amazon.DirectoryService.Model.DescribeCertificateResponse CallAWSServiceOperation(IAmazonDirectoryService client, Amazon.DirectoryService.Model.DescribeCertificateRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Directory Service", "DescribeCertificate");
            try
            {
                #if DESKTOP
                return client.DescribeCertificate(request);
                #elif CORECLR
                return client.DescribeCertificateAsync(request).GetAwaiter().GetResult();
                #else
                        #error "Unknown build edition"
                #endif
            }
            catch (AmazonServiceException exc)
            {
                var webException = exc.InnerException as System.Net.WebException;
                if (webException != null)
                {
                    throw new Exception(Utils.Common.FormatNameResolutionFailureMessage(client.Config, webException.Message), webException);
                }
                throw;
            }
        }
        
        #endregion
        
        internal partial class CmdletContext : ExecutorContext
        {
            public System.String CertificateId { get; set; }
            public System.String DirectoryId { get; set; }
            public System.Func<Amazon.DirectoryService.Model.DescribeCertificateResponse, GetDSCertificateCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.Certificate;
        }
        
    }
}
