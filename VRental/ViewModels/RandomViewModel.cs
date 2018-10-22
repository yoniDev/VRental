using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using VRental.Models;

namespace VRental.ViewModels
{
    public class RandomViewModel
    {
        public List<Movie> Movies { get; set; }
        public List<Customer> Customers { get; set; }
    }
}