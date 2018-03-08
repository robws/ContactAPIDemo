using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ContactAPIDemo.Models;

namespace ContactAPIDemo.Controllers
{
	public class ContactsController : ApiController
	{
		Contact[] contacts = new Contact[]
			  {
		 new Contact{ Id = 1, Lastname= "Anderson", Firstname= "William", Email="william.anderson@somehost.com" },
		 new Contact{ Id = 2, Lastname= "Wilson", Firstname= "Margaret", Email="margaret@gmail.com" },
		 new Contact{ Id = 3, Lastname= "Jackson", Firstname= "Karen", Email="kjackson@yahoo.com" },
			  };



		public IEnumerable<Contact> GetAllContacts()
		{
			return contacts;
		}

		public IHttpActionResult GetContact(int id)
		{
			var Contact = contacts.FirstOrDefault((p) => p.Id == id);
			if (Contact == null)
			{
				return NotFound();
			}
			return Ok(Contact);
		}
	}
}

