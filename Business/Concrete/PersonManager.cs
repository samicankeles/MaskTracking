using System;
using Business.Abstract;
using Business.KPSPublic;
using Entities.Concrete;

namespace Business.Concrete
{
	public class PersonManager : IApplicantService
	{
		public PersonManager()
		{
		}

        public void ApplyForMask()
        {

        }

        public bool ChechPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(person.NationalIdentity, person.FirstName, person.LastName, person.DateOfBirthYear).Result.Body.TCKimlikNoDogrulaResult;
            //return client.TCKimlikNoDogrulaAsync(
              //  new TCKimlikNoDogrulaRequest(
                //    new TCKimlikNoDogrulaRequestBody(person.NationalIdentity,
                  //      person.FirstName,
                    //    person.LastName,
                      //  person.DateOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;
            
        }

        public List<Person> GetAll()
        {
            return null;
        }
    }
}

