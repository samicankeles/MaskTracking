using System;
using Entities.Concrete;
using Business.Abstract;

namespace Business.Concrete
{
	public class PttManager
	{
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService)
		{
			_applicantService = applicantService;
		}
		
		public void GiveMask(Person person)
		{
			if (_applicantService.ChechPerson(person))
			{
				Console.WriteLine($" {person.NationalIdentity} ({person.FirstName} {person.LastName}) - The person was given a mask ");
			}
			else
			{
				Console.WriteLine($" {person.NationalIdentity} ({person.FirstName} {person.LastName}) - The person was NOT given a mask ");

			}
		}
	}
}

