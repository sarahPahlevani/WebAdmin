using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateAdmin.Models.DAL.Contracts
{
    public interface IRecaptchaForm
    {
        string RecaptchaToken { get; set; }
    }
}
