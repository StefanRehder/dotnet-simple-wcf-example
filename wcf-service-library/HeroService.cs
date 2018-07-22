using System.Net;
using System.ServiceModel.Web;
using wcf_service_library.Data;

namespace HeroServiceContracts
{
    public class HeroService : IHeroService
    {
        private static HeroCollection heroes = new HeroCollection();

        public Hero GetHero(string name)
        {
            Hero hero = heroes.GetHero(name);

            if (hero == null)
                WebOperationContext.Current.OutgoingResponse.SetStatusAsNotFound();

            return hero;
        }

        public Hero[] GetHeroList()
        {
            Hero[] heroArr = heroes.GetHeroes();
            return heroArr;
        }

        public void DeleteHero(string name)
        {
            heroes.DeleteHero(name);
            WebOperationContext.Current.OutgoingResponse.StatusCode = HttpStatusCode.NoContent;
        }

        public void PutHero(Hero hero)
        {
            if (hero != null)
            {
                heroes.PutHero(hero);
                WebOperationContext.Current.OutgoingResponse.StatusCode = HttpStatusCode.Created;
            }
            else
            {
                WebOperationContext.Current.OutgoingResponse.StatusCode = HttpStatusCode.BadRequest;
            }
        }
    }
}
