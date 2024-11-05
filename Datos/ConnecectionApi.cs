using Negocio;
using Newtonsoft.Json;
using NLog;
using RestSharp;
using System.Configuration;
using System.Net;


namespace Datos
{
    public class ConnecectionApi
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        RestClient client;
        List<string> Categories;
        private readonly string? baseUrl;

        public ConnecectionApi()
        {
            baseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
            client = new RestClient(baseUrl);
        }

        public string GetProducts(List<ApiProducts> listProductsToUpdate)
        {
            try
            {
                var request = new RestRequest("products", Method.Get);
                var response = client.Get(request);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var products = JsonConvert.DeserializeObject<List<ApiProducts>>(response.Content);
                    logger.Info($"Productos obtenidos con exito: {products.Count}");
                    listProductsToUpdate.Clear();
                    listProductsToUpdate.AddRange(products);
                    logger.Info("Metodo GetProducts ejecutado satisfactoriamente. Lista de productos actualizada");
                    return "Productos cargados correctamente";
                }
                else
                {
                    logger.Error($"Fallo al obtener los productos. Codigo de estado: {response.StatusCode}");
                    return "Error al obtener los productos";
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error en el metodo GetProducts");
                return "Error al obtener los productos";
            }
        }

        public ApiProducts GetSingleProduct(List<ApiProducts> ListProductsToUpdate, int id)
        {
            try
            {
                logger.Info("Ejecutando metodo GetSingleProduct");
                var request = new RestRequest($"products/{id}", Method.Get);
                var response = client.Get(request);
                logger.Info($"Producto con ID {id} obtenido exitosamente");
                return ListProductsToUpdate.FirstOrDefault(p => p.Id == id);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error en el metodo GetSingleProduct");
                return null;
            }
        }

        public string GetCategories(List<string> ListCategoriesToUpdate)
        {
            try
            {
                logger.Info("Ejecutando metodo GetCategories");
                var request = new RestRequest("products/categories", Method.Get);
                var response = client.Get(request);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var categories = JsonConvert.DeserializeObject<List<string>>(response.Content);
                    ListCategoriesToUpdate.Clear();
                    ListCategoriesToUpdate.AddRange(categories);
                    logger.Info($"Categorias obtenidas correctamente: {string.Join(", ", categories)}");
                    return "Categorias obtenidas correctamente";
                }
                else
                {
                    logger.Warn($"Fallo al obtener las categorias. Codigo de estado: {response.StatusCode}");
                    return "Error al obtener las categorias";
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error en el metodo GetCategories");
                return "Error al obtener las categorias";
            }
        }

        public void GetInCategory(List<ApiProducts> ListProductsToUpdate, string category)
        {
            try
            {
                logger.Info("Ejecutando metodo GetInCategory");
                var request = new RestRequest($"products/categories/{category}", Method.Get);
                var response = client.Get(request);
                ListProductsToUpdate.RemoveAll(p => p.Category != category);
                logger.Info($"Productos filtrados por categoria: {category}. Total despues del filtro: {ListProductsToUpdate.Count}");
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error en el metodo GetInCategory");
            }
        }

        public string PostProducts(List<ApiProducts> listProductsToUpdate, ApiProducts newProduct)
        {
            try
            {
                logger.Info("Ejecutando metodo PostProducts");
                var request = new RestRequest("products", Method.Post);
                request.AddJsonBody(newProduct);
                var response = client.Post(request);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    listProductsToUpdate.Add(newProduct);
                    logger.Info($"Producto agregado exitosamente: {newProduct.Title}");
                    return "Producto agregado correctamente";
                }
                else
                {
                    logger.Warn($"Fallo al agregar producto {newProduct.Title}. Codigo de estado: {response.StatusCode}");
                    return "No se pudo agregar el producto";
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error en el metodo PostProducts");
                return "Error en el metodo PostProducts";
            }
        }

        public string DeleteProducts(List<ApiProducts> listProductsToUpdate, List<int> listIds)
        {
            try
            {
                foreach (int productId in listIds)
                {
                    logger.Info("Ejecutando metodo DeleteProducts");
                    var request = new RestRequest($"products/{productId}", Method.Delete);
                    var response = client.Delete(request);

                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        listProductsToUpdate.RemoveAll(item => listIds.Contains(item.Id));
                        logger.Info($"Producto(s) eliminado(s) correctamente: {listIds.Count}");
                        return "Productos eliminados correctamente";
                    }
                    else
                    {
                        logger.Warn($"Fallo al eliminar productos. Codigo de estado: {response.StatusCode}");
                        return "Error al llamar a DeleteProducts";
                    }
                }
                return "";
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error en el metodo DeleteProducts");
                return "Error al eliminar el producto";
            }
        }

        public string PutProducts(List<ApiProducts> ListProductsToUpdate, ApiProducts productToEdit)
        {
            try
            {
                logger.Info("Ejecutando metodo PutProducts");
                var request = new RestRequest($"products/{productToEdit.Id}", Method.Put);
                request.AddJsonBody(productToEdit);
                var response = client.Put(request);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var product = ListProductsToUpdate.First(item => item.Id == productToEdit.Id);
                    product.Title = productToEdit.Title;
                    product.Description = productToEdit.Description;
                    product.Category = productToEdit.Category;
                    product.Price = productToEdit.Price;
                    logger.Info($"Producto actualizado correctamente: ID {productToEdit.Id}");
                    return "Producto actualizado correctamente";
                }
                else
                {
                    logger.Warn($"Fallo en la actualizacion del producto. Codigo de estado: {response.StatusCode}");
                    return "Error al llamar a PutProducts";
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error en el metodo PutProducts");
                return "Error al editar el producto";
            }
        }

        public void SortResults(List<ApiProducts> listProductsToUpdate, string order)
        {
            try
            {
                logger.Info("Ejecutando metodo SortResults");
                var request = new RestRequest("products/products?sort=desc", Method.Get);
                var response = client.Get(request);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    if (order == "Ascendente")
                    {
                        listProductsToUpdate.Sort((p1, p2) => p1.Id.CompareTo(p2.Id));
                        logger.Info("Productos ordenados en orden ascendente");
                    }
                    else
                    {
                        listProductsToUpdate.Sort((p1, p2) => p2.Id.CompareTo(p1.Id));
                        logger.Info("Productos ordenados en orden descendente");
                    }
                }
                else
                {
                    logger.Warn($"Error al ordenar los productos. Codigo de estado: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error en el metodo SortResults");
            }
        }
    }


}