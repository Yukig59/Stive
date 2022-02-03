using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stive.Client.Data.Methods
{
    public abstract class Entity<T>
    {
        public int Id { get; set; } 
        private string url = "https://localhost:7189/api/";


        /// <summary>
        /// 
        /// </summary>
        /// <param name="route"></param>
        /// <returns></returns>
        public List<T> Get(string route)
        {
            var client = new RestClient(url);
            var request = new RestRequest(route, Method.GET);
            var result = client.Get(request);
            var data = JsonConvert.DeserializeObject<List<T>>(result.Content);
            return data;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="route"></param>
        /// <returns></returns>
        public Entity<T> GetById(string route)
        {
            var client = new RestClient(url);
            var request = new RestRequest(route, Method.GET);
            var result = client.Get(request);
            var data = JsonConvert.DeserializeObject<Entity<T>>(result.Content);
            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="route"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Create(string route)
        {
            var client = new RestClient(url);
            var request = new RestRequest(route, Method.POST);
            string json = JsonConvert.SerializeObject(this);
            request.AddParameter("application/json; charset=utf-8", json, ParameterType.RequestBody);
            request.AddJsonBody(json);
            request.RequestFormat = DataFormat.Json;
            try
            {
                client.Execute(request);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="route"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Update(string route, Entity<T> entity)
        {
            var client = new RestClient(url);
            var request = new RestRequest(route+"/"+entity.Id, Method.PUT);
            string json = JsonConvert.SerializeObject(entity);
            request.AddParameter("application/json; charset=utf-8", json, ParameterType.RequestBody);
            request.AddJsonBody(json);
            request.RequestFormat = DataFormat.Json;
            try
            {
                client.Execute(request);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="route"></param>
        /// <returns></returns>
        public bool Delete(string route)
        {
            var client = new RestClient(url);
            var request = new RestRequest(route, Method.DELETE);
            try
            {
                client.Execute(request);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

    }
}
