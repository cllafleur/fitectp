using Microsoft.SqlServer.Management.Sdk.Sfc;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ContosoUniversity.Tests.Tools
{
   public  static class FormDataHelper
    {
        public static void PopulateFormData(ControllerBase controller, object model)
        {
            FormCollection form = new FormCollection();
            foreach (var prop in model.GetType().GetProperties())
            {
                form.Add(prop.Name, prop.GetGetMethod().Invoke(model, null) as string);
            }
            controller.ValueProvider = form.ToValueProvider();
        }
    }
}
