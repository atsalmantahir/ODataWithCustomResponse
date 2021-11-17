using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using ODataWithCustomResponse.Entities;

namespace ODataWithCustomResponse.OData
{
    public class ODataEntityDataModel
    {
        public IEdmModel GetEntityDataModel()
        {
            var builder = new ODataConventionModelBuilder();
            builder.Namespace = "SwaggerDocumentation";
            builder.ContainerName = "SwaggerDocumentationContainer";

            builder.EntitySet<Products>("Products");
            return builder.GetEdmModel();
        }
    }
}
