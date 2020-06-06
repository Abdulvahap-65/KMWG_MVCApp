using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KMWG_MVCApp.Toolss
{
    public class Tools
    {
        public static string GetOptionSetValueLabel(string entityName, string fieldName, int optionSetValue, IOrganizationService service)
        {
            /*
             * For Example : 
             * entityName:uam_portaluser
             * fieldName: uzm_iscinsiyet
             * optionSetValue:1
            1.Parametre: OptionSet'in hangi entity'de olduğunu --> "contact" gibi
            2.Parametre: OptionSet alanının adını-- > "uzm_iscinsiyet" gibi
            3.Parametre: OptionSet değerini --> 1 gibi
            4.Parametre: Crm Service nesnesini
           */
            var attReq = new RetrieveAttributeRequest();
            attReq.EntityLogicalName = entityName;
            attReq.LogicalName = fieldName;
            attReq.RetrieveAsIfPublished = true;

            var attResponse = (RetrieveAttributeResponse)service.Execute(attReq);
            var attMetadata = (EnumAttributeMetadata)attResponse.AttributeMetadata;

            return attMetadata.OptionSet.Options.Where(x => x.Value == optionSetValue).FirstOrDefault().Label.UserLocalizedLabel.Label;
        }
    }
}