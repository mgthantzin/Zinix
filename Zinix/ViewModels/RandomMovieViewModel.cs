using System.Collections.Generic;
using Zinix.Models;

namespace Zinix.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}