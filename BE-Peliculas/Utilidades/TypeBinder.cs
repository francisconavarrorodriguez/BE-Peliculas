using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;

namespace BE_Peliculas.Utilidades
{
    public class TypeBinder<T> : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var nombrePropiedad = bindingContext.ModelName;
            var valor = bindingContext.ValueProvider.GetValue(nombrePropiedad);

            if(valor == ValueProviderResult.None)
            {
                return Task.CompletedTask;
            }

            try
            {
                var valorDeserializado = JsonConvert.DeserializeObject<T>(valor.FirstValue);
                bindingContext.Result = ModelBindingResult.Success(valorDeserializado);
            }
            catch (Exception ex)
            {
                bindingContext.ModelState.TryAddModelError(nombrePropiedad, ex.Message);
            }

            return Task.CompletedTask;
        }
    }
}
