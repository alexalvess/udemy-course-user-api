using CursoMobile.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoMobile.Model
{
    public class ContactModel
    {
        public ContactTypeEnum ContactType { get; set; }

        public string Description { get; set; }
    }
}
