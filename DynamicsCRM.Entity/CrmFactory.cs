using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace DynamicsCRM.Entity
{
    public class CrmFactory
    {
        #region Fields
        private static CrmFactory serviceInstance;
        private static object lockobject = new object();
        private IOrganizationService organizationService;
        private OrganizationServiceContext context;
        private Guid guid;

        public IOrganizationService OrganizationService
        {
            get
            {
                if (((OrganizationServiceProxy)organizationService).IsAuthenticated == false) ((OrganizationServiceProxy)organizationService).Authenticate();
                return organizationService;
            }
        }
        public OrganizationServiceContext Context()
        {
            return context;
        }
        public Guid _guid
        {
            get { return guid; }
        }
        #endregion

        #region Private CTOR
        private CrmFactory(Guid controlID)
        {
            Uri serviceUri = new Uri("https://uzmancrmdemo.api.crm4.dynamics.com/XRMServices/2011/Organization.svc");
            ClientCredentials serviceCredentials = new ClientCredentials();
            serviceCredentials.UserName.UserName = "abdulvahapselcuk@uzmancrmdemo.onmicrosoft.com";
            serviceCredentials.UserName.Password = "Avs4574482*";
            OrganizationServiceProxy organizationServiceProxy = new OrganizationServiceProxy(serviceUri, null, serviceCredentials, null);
            organizationServiceProxy.EnableProxyTypes();

            this.organizationService = (IOrganizationService)organizationServiceProxy;
            this.guid = controlID;
            this.context = new OrganizationServiceContext(organizationService);
        }
        #endregion


        public static CrmFactory GetService()
        {
            try
            {
                if (serviceInstance == null)
                {
                    lock (lockobject)
                    {
                        if (serviceInstance == null)
                            serviceInstance = new CrmFactory(Guid.NewGuid());

                    }
                }
                if (((OrganizationServiceProxy)serviceInstance.organizationService).SecurityTokenResponse != null)
                {
                    if (DateTime.Now > (((System.IdentityModel.Tokens.GenericXmlSecurityToken)((OrganizationServiceProxy)serviceInstance.organizationService).SecurityTokenResponse.Token).ValidTo))
                    {
                        ((OrganizationServiceProxy)serviceInstance.OrganizationService).Authenticate();
                        ((OrganizationServiceProxy)serviceInstance.OrganizationService).Timeout = new TimeSpan(12, 0, 0);
                    }
                }
                return serviceInstance;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
