using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net


namespace Hello.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        public HelloController() {}

        [HttpGet]
        public ActionResult Get()
        {
            //return Ok("Opa, deu certo");

            /*
            return Ok(
            var requestURL = 'https://drive.google.com/file/d/10z5bRyNDMnwZZTyscIMPxckLiLrKce2K/view?usp=sharing'
            var request = new HttpWebRequest;
            )
           
            */

            using (WebClient webClient = new System.Net.WebClient())
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            var json = webClient.DownloadString("https://drive.google.com/file/d/10z5bRyNDMnwZZTyscIMPxckLiLrKce2K/view?usp=sharing");

            dynamic obj = JsonConvert.DeserializeObject(json);

            var btc = 0.0;


            foreach (var result in obj.BTC_EGX)

                btc = result.last;

        }

           

        }
    }

}