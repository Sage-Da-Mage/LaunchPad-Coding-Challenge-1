using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.ComponentModel.DataAnnotations;


namespace CC1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumsController : ControllerBase
    {

        // This default getAlbums endpoint will return all albums from https://jsonplaceholder.typicode.com/
        [HttpGet]
        public async Task<string> getAlbums()
        {

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(@"https://jsonplaceholder.typicode.com");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                return await client.GetStringAsync("/albums");

            }

        }

        // This getAlbums will get any album that contains the search string in it's title



        public class AlbumFormat
        {
            public string userId { get; set; }
            public string id { get; set; }
            public string title { get; set; }
        
        }



    }
}
