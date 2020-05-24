﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.Xrm.Sdk;
//using Microsoft.Xrm.Sdk.Query;
//using Microsoft.Xrm.Sdk.Workflow;
using System.Activities;

namespace MyCustomWorkflows
{
    public class GetTaxWorkFlow : CodeActivity
    {
        [Input("Key")]
        public InArgument<string> Key { get; set; }
        [Output("Tax")]
        public OutArgument<string>Tax { get; set; }
        protected override void Execute(CodeActivityContext executionContext)
        {    //https://docs.microsoft.com/en-us/powerapps/developer/common-data-service/workflow/sample-create-custom-workflow-activity
            // Create the tracing service
            ITracingService tracingService = executionContext.GetExtension<ITracingService>();

            //Create the context
            IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();
            IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
            string key = Key.Get(executionContext);
            //Get data from Configuration Entitiy
            //Call organization web service
            QueryByAttribute query = new QueryByAttribute("vhp_configuration");
            query.ColumnSet = new ColumnSet(new string[] {"vhp_value" });
            query.AddAttributeValue("vhp_name",key);
            EntityCollection collection=service.RetrieveMultiple(query);
            if(collection.Entities.Count!=1)
            {
                tracingService.Trace("Something wrong with configuration");
            }
            Entity config=collection.Entities.FirstOrDefault();
           
            Tax.Set(executionContext, config.Attributes["cont value"].ToString());
        }
    }
}
