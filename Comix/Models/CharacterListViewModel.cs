using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Marvel.Api.Model.DomainObjects;
using Comix.Infrastructure;

namespace Comix.Models
{
    public class CharacterListViewModel
    {
        public IEnumerable<Character> Characters { get; set; }

        public PageModel PageInfo { get; set; }
    }
}