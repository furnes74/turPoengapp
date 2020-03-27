using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using turPoeng1.Services;

namespace turPoeng1
{
    public class PersonRest : Application
    {
        	public PersonManager PersonItemManager { get; private set; }

        public PersonRest()
        {
            PersonItemManager = new PersonManager(new RestService());
        }
    }
}
