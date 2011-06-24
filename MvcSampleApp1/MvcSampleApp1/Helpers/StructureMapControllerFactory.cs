using System;
using System.Web.Mvc;
using System.Web.Routing;

using StructureMap;

namespace MvcSampleApp1.Helpers
{
	public class StructureMapControllerFactory : DefaultControllerFactory {
		protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType) {
			if (controllerType == null) {
				return base.GetControllerInstance(requestContext, controllerType);
			}
			return (IController)ObjectFactory.GetInstance(controllerType);
		}
	}

	public class StructureMapModelBinder : DefaultModelBinder
	{
		protected override object CreateModel(ControllerContext controllerContext, ModelBindingContext bindingContext, Type modelType)
		{
			return ObjectFactory.GetInstance(modelType);
		}
	}
}