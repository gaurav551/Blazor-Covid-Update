using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BlazorCrud.Models;
using Newtonsoft.Json;

namespace BlazorCrud.Data
{
    public class CovidStatus
    {
        public async Task<Rootobject> GetAsync()
        {
            try
            {
                Rootobject CovidStatusList = new Rootobject();
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync("https://api.covid19api.com/summary"))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        CovidStatusList = JsonConvert.DeserializeObject<Rootobject>(apiResponse);
                    }
                }
                return CovidStatusList;
            }
            catch (Exception)
            {
                return null;
            }

        }
        public async Task<NepalCoronaStatus> GetNepalCoronaStatusAsync()
        {
            try{
            NepalCoronaStatus nepalStatus = new NepalCoronaStatus();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://nepalcorona.info/api/v1/data/nepal"))
                {
                     string apiResponse = await response.Content.ReadAsStringAsync();
                     nepalStatus = JsonConvert.DeserializeObject<NepalCoronaStatus>(apiResponse);

                }
            }
            return nepalStatus;
            }
            catch(Exception e)
            {
                System.Console.WriteLine(e);

                return null;
            }

        }
        public async Task<List<NepalDistrictWise>> GetNepalDistrictWiseAsync()
        {

            List<NepalDistrictWise> nepalStatus = new List<NepalDistrictWise>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://data.nepalcorona.info/api/v1/districts"))
                {
                     string apiResponse = await response.Content.ReadAsStringAsync();

                     nepalStatus = JsonConvert.DeserializeObject<List<NepalDistrictWise>>(apiResponse);

                }
            }

            return nepalStatus.ToList();




        }
    }
}