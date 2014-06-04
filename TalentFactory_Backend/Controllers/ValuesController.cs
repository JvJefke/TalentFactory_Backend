using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TalentFactory_Backend.DataAccess.Services;
using TalentFactory_Backend.Models;
using TalentFactory_Backend.ViewModels;

namespace TalentFactory_Backend.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        private IContentService contentService = null;
        // private NominatieService nominatieService;

        public ValuesController() {}
        public ValuesController(IContentService contentService) {
            this.contentService = contentService;
        }

        // GET api/values
        [Route("api/home")]
        [HttpGet]
        public HttpResponseMessage GetHome()
        {
            HttpResponseMessage message = null;

            try
            {
                Home h = contentService.GetHomeData();
                message = new HttpResponseMessage(HttpStatusCode.OK);
                message.Content = new ObjectContent<Home>(h, Configuration.Formatters[0], "application/json");
            }
            catch (Exception ex)
            {
                message = new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }

            return message;
        }

        [Route("api/nieuws")]
        [HttpGet]
        public HttpResponseMessage GetNieuws(int iStartIndex, int iAantal)
        {
            HttpResponseMessage message = null;

            try
            {
                List<NieuwsItem> lNieuws = contentService.GetNieuwsItems(iStartIndex, iAantal);
                message = new HttpResponseMessage(HttpStatusCode.OK);
                message.Content = new ObjectContent<List<NieuwsItem>>(lNieuws, Configuration.Formatters[0], "application/json");
            }
            catch (Exception ex)
            {
                message = new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }

            return message;
        }

        [Route("api/nieuws")]
        [HttpGet]
        public HttpResponseMessage GetNieuws()
        {
            HttpResponseMessage message = null;

            try
            {
                List<NieuwsItem> lNieuws = contentService.GetNieuwsItems();
                message = new HttpResponseMessage(HttpStatusCode.OK);
                message.Content = new ObjectContent<List<NieuwsItem>>(lNieuws, Configuration.Formatters[0], "application/json");
            }
            catch (Exception ex)
            {
                message = new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }

            return message;
        }

        [Route("api/nieuwsItem/{id}")]
        [HttpGet]
        public HttpResponseMessage GetNieuwsItem(int id)
        {
            HttpResponseMessage message = null;

            try
            {
                NieuwsItem nieuwsItem = contentService.GetNieuwsItemById(id);
                message = new HttpResponseMessage(HttpStatusCode.OK);
                message.Content = new ObjectContent<NieuwsItem>(nieuwsItem, Configuration.Formatters[0], "application/json");
            }
            catch (Exception ex)
            {
                message = new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }

            return message;
        }

        [Route("api/sponsors/{id}")]
        [HttpGet]
        public HttpResponseMessage GetSponsors(int id)
        {
            HttpResponseMessage message = null;

            try
            {
                List<Sponsor> lSponsors = contentService.GetSponsorsByType(id);
                message = new HttpResponseMessage(HttpStatusCode.OK);
                message.Content = new ObjectContent<List<Sponsor>>(lSponsors, Configuration.Formatters[0], "application/json");
            }
            catch (Exception ex)
            {
                message = new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }

            return message;
        }

        [Route("api/sponsors")]
        [HttpGet]
        public HttpResponseMessage GetSponsors()
        {
            HttpResponseMessage message = null;

            try
            {
                List<Sponsor> lSponsors = contentService.GetSponsors();
                message = new HttpResponseMessage(HttpStatusCode.OK);
                message.Content = new ObjectContent<List<Sponsor>>(lSponsors, Configuration.Formatters[0], "application/json");
            }
            catch (Exception ex)
            {
                message = new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }

            return message;
        }

        [Route("api/media")]
        [HttpGet]
        public HttpResponseMessage GetMedia()
        {
            HttpResponseMessage message = null;

            try
            {
                List<FlickrAlbum> lFlickr = contentService.GetFlickrAlbums();
                message = new HttpResponseMessage(HttpStatusCode.OK);
                message.Content = new ObjectContent<List<FlickrAlbum>>(lFlickr, Configuration.Formatters[0], "application/json");
            }
            catch (Exception ex)
            {
                message = new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }

            return message;
        }

        [Route("api/halloffame")]
        [HttpGet]
        public HttpResponseMessage GetHallOfFame()
        {
            HttpResponseMessage message = null;

            try
            {
                List<HallOfFame> lHallOfFame = contentService.GetHallOfFameElements();
                message = new HttpResponseMessage(HttpStatusCode.OK);
                message.Content = new ObjectContent<List<HallOfFame>>(lHallOfFame, Configuration.Formatters[0], "application/json");
            }
            catch (Exception ex)
            {
                message = new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }

            return message;
        }

        [Route("api/contact")]
        [HttpGet]
        public HttpResponseMessage GetContact()
        {
            HttpResponseMessage message = null;

            try
            {
                Contact contact = contentService.GetContact();
                message = new HttpResponseMessage(HttpStatusCode.OK);
                message.Content = new ObjectContent<Contact>(contact, Configuration.Formatters[0], "application/json");
            }
            catch (Exception ex)
            {
                message = new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }

            return message;
        }

        [Route("api/awards")]
        [HttpGet]
        public HttpResponseMessage GetAwards()
        {
            HttpResponseMessage message = null;

            try
            {
                List<Award> lAwards = contentService.GetAwards();
                message = new HttpResponseMessage(HttpStatusCode.OK);
                message.Content = new ObjectContent<List<Award>>(lAwards, Configuration.Formatters[0], "application/json");
            }
            catch (Exception ex)
            {
                message = new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }

            return message;
        }

        [Route("api/nominaties")]
        [HttpGet]
        public HttpResponseMessage GetNominaties()
        {
            HttpResponseMessage message = null;

            try
            {
                List<Nominatie> lNominaties = contentService.GetNominaties();
                message = new HttpResponseMessage(HttpStatusCode.OK);
                message.Content = new ObjectContent<List<Nominatie>>(lNominaties, Configuration.Formatters[0], "application/json");
            }
            catch (Exception ex)
            {
                message = new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }

            return message;
        }

        [Route("api/nominaties/{id}")]
        [HttpGet]
        public HttpResponseMessage GetNominatiesByAward(int id)
        {
            HttpResponseMessage message = null;

            try
            {
                List<Nominatie> lNominaties = contentService.GetNominatiesByAward(id);
                message = new HttpResponseMessage(HttpStatusCode.OK);
                message.Content = new ObjectContent<List<Nominatie>>(lNominaties, Configuration.Formatters[0], "application/json");
            }
            catch (Exception ex)
            {
                message = new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }

            return message;
        }

        [Route("api/nominaties/{id}")]
        [HttpGet]
        public HttpResponseMessage GetNominatiesByAward(int id, int startIndex, int iAantal)
        {
            HttpResponseMessage message = null;

            try
            {
                List<Nominatie> lNominaties = contentService.GetNominatiesByAward(id, startIndex, iAantal);
                message = new HttpResponseMessage(HttpStatusCode.OK);
                message.Content = new ObjectContent<List<Nominatie>>(lNominaties, Configuration.Formatters[0], "application/json");
            }
            catch (Exception ex)
            {
                message = new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }

            return message;
        }

        [Route("api/JuryKeuzes")]
        [HttpPost]
        public void Post(List<JuryKeuzeAwardVM> VMs)
        {

        }

        [Route("api/RegistreerNominee")]
        [HttpPost]
        public void Post(List<JuryKeuzeAwardVM> VMs)
        {

        }

        /*

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }*/
    }
}
